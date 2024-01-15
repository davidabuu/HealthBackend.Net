using Microsoft.EntityFrameworkCore;

namespace Health.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options) { 

        }  
    }
}
