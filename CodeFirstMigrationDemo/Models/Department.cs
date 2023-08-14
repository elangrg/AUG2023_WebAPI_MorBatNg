using Microsoft.EntityFrameworkCore;

namespace CodeFirstMigrationDemo.Models
{
    public class Department
    {

        public int DepartmentId { get; set; }
        public string DeptName { get; set; }


        public string Location { get; set; }

    }



    public class DeptContext:DbContext
    {
        public DbSet<Department>    Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        modelBuilder .Entity<Department>().HasKey(e => e.DepartmentId);
            modelBuilder.Entity<Department>().Property(d => d.DepartmentId).ValueGeneratedOnAdd();


            modelBuilder.Entity<Department>().Property(d => d.DeptName).IsRequired().IsUnicode(false).HasMaxLength(50);


            modelBuilder.Entity<Department>().Property(d => d.Location).IsRequired().IsUnicode(false).HasMaxLength(100);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=TMPCFDeptDb;Integrated Security=True;");

        }


    }



}
