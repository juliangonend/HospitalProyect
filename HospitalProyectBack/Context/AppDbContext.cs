using HospitalProyect.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalProyect.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        
        
        
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
