namespace project_management_system_backend.Models
{
    using Microsoft.EntityFrameworkCore;

    public class RequestDbContext : DbContext
    {
        public RequestDbContext(DbContextOptions<RequestDbContext> options) : base(options)
        {
        }

        public DbSet<AddRequest> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the entity mappings if necessary
            // modelBuilder.Entity<Request>(). ...

            base.OnModelCreating(modelBuilder);
        }
    }
}
