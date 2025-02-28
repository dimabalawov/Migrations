using Microsoft.EntityFrameworkCore;
using Migrations.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

public class UniversityContext : DbContext
{
    public DbSet<Curator> Curators { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
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
}
