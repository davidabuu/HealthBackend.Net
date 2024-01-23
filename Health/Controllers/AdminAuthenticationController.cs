using Health.Data;
using Health.Dto;
using Health.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Health.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : Controller
{
    private readonly UserManager<AdminRegistration> _adminManager;

    private readonly ApiDbContext _context;
    private readonly TokenValidationParameters _tokenValidationParameters;
    private readonly IConfiguration _configuration;
    public AuthenticationController(UserManager<AdminRegistration> adminManager, IConfiguration configuration, ApiDbContext context, TokenValidationParameters tokenValidationParameters)
    {
        _adminManager = adminManager;
        _configuration = configuration;
        _context = context;
        _tokenValidationParameters = tokenValidationParameters;
    }

    [HttpPost]
    [Route("Register/Admin")]
    public async Task<IActionResult> Register( AdminRegistration adminRegistration)
    {
        if (ModelState.IsValid)
        {
            var admin_Exists = await _adminManager.FindByEmailAsync(adminRegistration.Email!);
            if (admin_Exists != null)
            {

                return BadRequest(new AuthResult()
                {
                    Result = false,
                    Errors = new List<string>()
                    {
                        "Email Already Exists"
                    }
                }
                    );
            }
            //Create A New Admin
            var new_Admin = new AdminRegistration()
            {
                Email = adminRegistration.Email,
                UserName = adminRegistration.Email,
                FirstName = adminRegistration.FirstName,
                LastName = adminRegistration.LastName,

            };
            var isCreated = await _adminManager.CreateAsync(new_Admin, adminRegistration.Password!);
            if (isCreated.Succeeded)
            {
                var currentAdmin = await _adminManager.FindByEmailAsync(new_Admin.Email!);
                if (currentAdmin != null)
                {
                    var addUserRole = await _adminManager.AddToRoleAsync(currentAdmin, adminRegistration.Role!);
                    if (addUserRole.Succeeded)
                    {
                        //Generate Token
                        var token = await GenerateToken(new_Admin);

                        return Ok(token);
                    }

                }
                return BadRequest(new AuthResult()
                {
                    Result = false,
                    Errors = new List<string>()
                    {
                        "Server Error"
                    }
                }
                 );
            }
            return BadRequest(new AuthResult()
            {
                Result = false,
                Errors = new List<string>()
                    {
                        isCreated.ToString()
                    }
            }
            );


        }
        return BadRequest();
    }
    private async Task<AuthResult> GenerateToken(IdentityUser admin)
    {
        var jwtTokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtConfig:Secret").Value!);

        // Token Descriptorc
        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("Id", admin.Id),
                new Claim(JwtRegisteredClaimNames.Sub, admin.Email!),
                new Claim(JwtRegisteredClaimNames.Email, admin.Email !),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToUniversalTime().ToString()),

            }),
            Expires = DateTime.UtcNow.Add(TimeSpan.Parse(_configuration.GetSection("JwtConfig:ExpiryTimeFrame").Value!)),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
        };

        var token = jwtTokenHandler.CreateToken(tokenDescriptor);
        var jwtToken = jwtTokenHandler.WriteToken(token);
        var refreshToken = new RefreshToken()
        {
            JwtId = token.Id,
            Token = RandomStringGeneration(23),
            AddedDate = DateTime.UtcNow,
            ExpiryDate = DateTime.UtcNow.AddMonths(6),
            IsRevoked = false,
            IsUsed = false,
            UserId = admin.Id
        };
        await _context.RefreshTokens.AddAsync(refreshToken);
        await _context.SaveChangesAsync();
        return new AuthResult()
        {
            Token = jwtToken,
            RefreshToken = refreshToken.Token,
            Result = true

        };

    }
    private string RandomStringGeneration(int length)
    {
        var random = new Random();
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXY123456789abucdefghijklmnoipqrus";
        return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
    }
}