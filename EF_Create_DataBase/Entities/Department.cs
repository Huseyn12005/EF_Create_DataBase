using EF_Create_DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DataAnnotation.Entities;


[Index(nameof(Name), IsUnique = true)]
public class Department : BaseEntity
{

    [Required]
    [Range(1, 5, ErrorMessage = "Error")]
    public int BuildingNum { get; set; }

    [Required]
    [Column(TypeName = "money")]
    [Range(0, double.MaxValue, ErrorMessage = "Error")]
    [DefaultValue(0)]
    public double Financing { get; set; }

    [Required]
    [Column(TypeName = "Error")]
    [MinLength(1)]
    public string Name { get; set; }



    // Foreign Key
    [Required]
    [ForeignKey(nameof(Faculty))]
    public int FacultyId { get; set; }



    // Navigation property
    public Faculty Faculty { get; set; }
}
