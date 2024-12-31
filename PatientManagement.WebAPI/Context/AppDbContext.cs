using Microsoft.EntityFrameworkCore;
using PatientManagement.WebAPI.Models;

namespace PatientManagement.WebAPI.Context
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
    }
}
