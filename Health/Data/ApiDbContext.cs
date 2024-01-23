using Health.Dto;
using Health.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Health.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<AdminRegistration> AdminRegistrations { get; set; }
        public DbSet<AttendanceEntry> AttendanceEntries { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<AvailabilitySlot> AvailabilitySlots { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        public DbSet<DoctorRegistration> DoctorRegistrations { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<LabRadiologyOrder> LabRadiologyOrders { get; set; }
        public DbSet<LabTest> LabTests { get; set; }
        public DbSet<MedicalHistoryEntry> MedicalHistoryEntries { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<PatientBill> PatientBills { get; set; }
        public DbSet<PatientRegistration> PatientRegistrations { get; set; }
        public DbSet<StaffManagement> StaffManagements { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
           
             
        }
    }
}
