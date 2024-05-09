using Microsoft.EntityFrameworkCore;

namespace SigmaApi.DAL.Data.Context
{
    public class SigmaContext : DbContext
    {
        public SigmaContext(DbContextOptions<SigmaContext> options) : base(options)
        {
        }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
