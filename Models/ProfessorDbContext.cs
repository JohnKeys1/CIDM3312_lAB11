using Microsoft.EntityFrameworkCore;


namespace CIDM3312_lAB11.Models
{
    public class ProfessorDbContext : DbContext
    {
        public ProfessorDbContext (DbContextOptions<ProfessorDbContext> options)
            : base(options)
            
        {
        }

        public DbSet<CIDM3312_lAB11.Models.Professor> Professor { get; set; }
        


     
    }
    
}