using ContosoCore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCore.DAL.EF
{
    public class ContosoCoreContext: DbContext
    {
        public ContosoCoreContext()
        {
           
            
        }
        public ContosoCoreContext(DbContextOptions<ContosoCoreContext> options)
            :base(options)
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server =(localdb)\MSSQLLocalDB;Database=ContosoCoreDB;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }
    }
}
