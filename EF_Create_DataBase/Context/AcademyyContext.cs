using EF_DataAnnotation.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_DataAnnotation.Contexts;

public class AcademyyContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string Constr = "Data Source=DESKTOP-SDREM5J\\SQLEXPRESS;Initial Catalog=Academyy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;";
        optionsBuilder.UseSqlServer(Constr);
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Curator> Curators { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set;}
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupCurator> GroupsCurators { get; set;}
    public DbSet<GroupLecture> GroupsLectures { get; set; }
    public DbSet<GroupStudent> GroupsStudents { get; set;}
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}
