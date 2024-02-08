using EF_Create_DataBase.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DataAnnotation.Entities;

public class Teacher : BaseEntity
{


    [Column(TypeName = "bit")]
    [DefaultValue(0)]
    [Required]
    public bool IsProfessor { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    [MinLength(1)]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "money")]
    [Range(1, double.MaxValue, ErrorMessage = "Error")]
    public double Salary { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    [MinLength(1)]
    public string Surname { get; set; }

    // Navigation property
    public ICollection<Lecture> Lectures { get; set; }
}
