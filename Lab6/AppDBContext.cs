using Lab6.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections.Generic;


namespace Lab6
{
    public class BloggingContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(@"Server=DVTL6Q7JXF2;Database=TrainingDB;Trusted_Connection=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
             : base(options)
        { }

        public DbSet<Dietary> Dietaries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<AddressDetail> AddressDetails { get; set; }
        public DbSet<Delegate> Delegates { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TrainingPayment> TrainingPayments { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Registration> Registration { get; set; }
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DVTL6Q7JXF2;Database=TrainingDB;Trusted_Connection=True;");
        }
    }
}
