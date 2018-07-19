using Lab6.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Lab6
{
    public class AppDbContext: DbContext
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
    }
}
