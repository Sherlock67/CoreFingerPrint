using FingerPrintSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace FingerPrintSolution.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {




        }
        public DbSet<FingerPrint> Fingerprints { get; set; }
    }
}
