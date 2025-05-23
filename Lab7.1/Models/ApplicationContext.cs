using Microsoft.EntityFrameworkCore;
using Lab7._1.Models;

namespace Lab7._1.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Student> students = null!;

        public ApplicationContext() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = Program.config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Lab7._1.Models.Student> Student { get; set; } = default!;

        // Fluent API
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>().HasData(
        //        new Student(1, "Ivan", 18, "Moscow,Lenina,3"),
        //        new Student(2, "John", 19, "Krasnodar,Zelyonaya,10"),
        //        new Student(3, "Ben", 23, "Orel,Michurina,56"),
        //        new Student(4, "Antony", 20, "Kerch,Komsomolskaya,35"),
        //        new Student(5, "Alex", 27, "Abakan,Gagarina,5"));

        //    //this.Database.GetDbConnection();
        //    //modelBuilder.Entity<Student>().MapToStoredProcedures();

        //}
    }
}
