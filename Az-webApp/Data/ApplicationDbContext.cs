using Microsoft.EntityFrameworkCore;

namespace Az_webApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
                
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
                
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person { Id=1 , FirstName="Mina" , LastName="Morcos", DateOfBirth = "test 145145" });
            base.OnModelCreating(modelBuilder);
        }

    }

}
