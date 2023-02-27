using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(s => s.StudentId).IsRequired();
            modelBuilder.Entity<Group>().Property(g => g.GroupId).IsRequired();
            modelBuilder.Entity<Department>().Property(d => d.DepartmentId).IsRequired();

            modelBuilder.Entity<Group>()
            .HasMany(x => x.Students)
            .WithOne(c => c.Group)
            .HasForeignKey(fk => fk.GroupId);
        }
        public DbSet<Department> Department { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }


    }
}
