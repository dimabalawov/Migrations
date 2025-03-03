using Microsoft.EntityFrameworkCore;
using Migrations.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

public class UniversityContext : DbContext
{
    public DbSet<Curator> Curators { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupCurator> GroupsCurators { get; set; }
    public DbSet<GroupLecture> GroupsLectures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=UniversityDB;Integrated Security=true;TrustServerCertificate=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Teacher>()
            .HasKey(t => t.Id);
        modelBuilder.Entity<Teacher>()
            .UseTptMappingStrategy();

        modelBuilder.Entity<Teacher>()
            .ToTable("Teachers")
            .HasDiscriminator<string>("Discriminator")
            .HasValue<Teacher>("Teacher")
            .HasValue<Curator>("Curator")
            .HasValue<Assistant>("Assistant")
            .HasValue<Head>("Head")
            .HasValue<Dean>("Dean");



        modelBuilder.Entity<Subject>()
            .HasKey(s => s.Id);
        modelBuilder.Entity<Subject>()
            .HasIndex(s => s.Name)
            .IsUnique();
        modelBuilder.Entity<Subject>()
            .Property(s => s.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder.Entity<Subject>()
            .ToTable(t => t.HasCheckConstraint("CK_Subject_Name", "LEN(Name) > 0"));

        modelBuilder.Entity<Teacher>()
            .Property(t => t.Name)
            .IsRequired()
            .HasColumnType("nvarchar");
        modelBuilder.Entity<Teacher>()
            .ToTable(t => t.HasCheckConstraint("CK_Teacher_Name", "LEN(Name) > 0"));
        modelBuilder.Entity<Teacher>()
            .Property(t => t.Surname)
            .IsRequired()
            .HasColumnType("nvarchar");
        modelBuilder.Entity<Teacher>()
            .ToTable(t => t.HasCheckConstraint("CK_Teacher_Surname", "LEN(Surname) > 0"));

        modelBuilder.Entity<Assistant>()
            .HasOne(a => a.Teacher)
            .WithOne(t => t.Assistant)
            .HasForeignKey<Assistant>(a => a.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Head>()
            .HasOne(h => h.Teacher)
            .WithOne(t => t.Head)
            .HasForeignKey<Head>(h => h.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Dean>()
            .HasOne(d => d.Teacher)
            .WithOne(t => t.Dean)
            .HasForeignKey<Dean>(d => d.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);



        modelBuilder.Entity<LectureRoom>()
            .HasKey(l => l.Id);
        modelBuilder.Entity<LectureRoom>()
            .Property(l => l.Building)
            .IsRequired();
        modelBuilder.Entity<LectureRoom>()
            .ToTable(t => t.HasCheckConstraint("CK_LectureRoom_Building", "Building>=1 AND Building <=5"));

        modelBuilder.Entity<Lecture>()
            .HasKey(l => l.Id);
        modelBuilder.Entity<Lecture>()
            .HasOne(l => l.Subject)
            .WithOne(s => s.Lecture)
            .HasForeignKey<Lecture>(l => l.SubjectId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Lecture>()
            .Property(l => l.TeacherId)
            .IsRequired(false);

        modelBuilder.Entity<Lecture>()
            .HasOne(l => l.Teacher)
            .WithOne(t => t.Lecture)
            .HasForeignKey<Lecture>(l => l.TeacherId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Schedule>()
            .HasKey(s => s.Id);
        modelBuilder.Entity<Schedule>()
            .Property(s => s.Class)
            .IsRequired();
        modelBuilder.Entity<Schedule>()
            .ToTable(t => t.HasCheckConstraint("CK_Schedule_Class", "Class >= 1 AND Class <=8"));
        modelBuilder.Entity<Schedule>()
            .Property(s => s.Week)
            .IsRequired();
        modelBuilder.Entity<Schedule>()
            .ToTable(t => t.HasCheckConstraint("CK_Schedule_Week", "Week>=1 AND Week<=52"));
        modelBuilder.Entity<Schedule>()
            .HasOne(s => s.Lecture)
            .WithOne(l => l.Schedule)
            .HasForeignKey<Schedule>(s => s.LectureId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Schedule>()
            .Property(s => s.LectureRoomId)
            .IsRequired(false);
        modelBuilder.Entity<Schedule>()
            .HasOne(s => s.LectureRoom)
            .WithOne(l => l.Schedule)
            .HasForeignKey<Schedule>(s => s.LectureRoomId)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<Faculty>()
            .HasKey(f => f.Id);
        modelBuilder.Entity<Faculty>()
            .Property(f => f.Building)
            .IsRequired();
        modelBuilder.Entity<Faculty>()
            .ToTable(t => t.HasCheckConstraint("CK_Faculty_Building", "Building>=1 AND Building<=5"));
        modelBuilder.Entity<Faculty>()
            .Property(f => f.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder.Entity<Faculty>()
            .HasIndex(f => f.Name)
            .IsUnique();
        modelBuilder.Entity<Faculty>()
            .ToTable(t => t.HasCheckConstraint("CK_Faculty_Name", "LEN(Name)>0"));
        modelBuilder.Entity<Faculty>()
            .HasOne(f => f.Dean)
            .WithOne(d => d.Faculty)
            .HasForeignKey<Faculty>(f => f.DeanId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Department>()
            .HasKey(d => d.Id);
        modelBuilder.Entity<Department>()
            .Property(d => d.Building)
            .IsRequired();
        modelBuilder.Entity<Department>()
            .ToTable(t => t.HasCheckConstraint("CK_Department_Building", "Building>=1 AND Building<=5"));
        modelBuilder.Entity<Department>()
            .Property(d => d.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder.Entity<Department>()
            .HasIndex(d => d.Name)
            .IsUnique();
        modelBuilder.Entity<Department>()
            .ToTable(t => t.HasCheckConstraint("CK_Department_Name", "LEN(Name)>0"));
        modelBuilder.Entity<Department>()
            .HasOne(d => d.Faculty)
            .WithOne(f => f.Department)
            .HasForeignKey<Department>(d => d.FacultyId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Department>()
            .Property(d => d.HeadId)
            .IsRequired(false);
        modelBuilder.Entity<Department>()
            .HasOne(d => d.Head)
            .WithOne(h => h.Department)
            .HasForeignKey<Department>(d => d.HeadId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Group>()
            .HasKey(g => g.Id);
        modelBuilder.Entity<Group>()
            .HasIndex(g => g.Name)
            .IsUnique();
        modelBuilder.Entity<Group>()
            .Property(g => g.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(10)
            .IsRequired();
        modelBuilder.Entity<Group>()
            .ToTable(t => t.HasCheckConstraint("CK_Group_Name", "LEN(Name)>0"));
        modelBuilder.Entity<Group>()
            .Property(g => g.Year)
            .IsRequired();
        modelBuilder.Entity<Group>()
            .ToTable(t => t.HasCheckConstraint("CK_Group_Year", "Year>=1 AND Year<=5"));
        modelBuilder.Entity<Group>()
            .HasOne(g => g.Department)
            .WithOne(d => d.Group)
            .HasForeignKey<Group>(g => g.DepartmentId);

        modelBuilder.Entity<Group>()
            .HasMany(g => g.Lectures)
            .WithMany(l => l.Groups)
            .UsingEntity("GroupsLectures");

        modelBuilder.Entity<Group>()
            .HasMany(g => g.Curators)
            .WithMany(c => c.Groups)
            .UsingEntity("GroupCurators");
    }
}
}
