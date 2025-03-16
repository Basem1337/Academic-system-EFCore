using AcademicDatabaseSystem.DataRepository;
using AcademicDatabaseSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademicDatabaseSystem.Context
{
    class DatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=AcademicSystem;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StdCrs>().HasKey(sc => new { sc.StdID, sc.CrsID });

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.InstructorsMng)
                .WithOne(i => i.ManagedAt)
                .HasForeignKey<Department>(d => d.ManagerID);



            modelBuilder.Entity<Student>().HasData(Repository.getStuds());
            modelBuilder.Entity<Instructor>().HasData(Repository.getInsts());
            modelBuilder.Entity<Department>().HasData(Repository.getDepts());
            modelBuilder.Entity<Course>().HasData(Repository.getCrs());
            modelBuilder.Entity<CourseSession>().HasData(Repository.getCrsSessions());
            modelBuilder.Entity<CourseSessionAttendance>().HasData(Repository.getCrsSessionAtts());
            modelBuilder.Entity<StdCrs>().HasData(Repository.getStdCrs());

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSession> Crs_Sessions { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<StdCrs> Std_Courses { get; set; }
        public virtual DbSet<CourseSessionAttendance> CrsSessionAtts { get; set; }
    }
}
