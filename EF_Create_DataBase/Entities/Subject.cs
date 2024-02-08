using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using EF_Create_DataBase.Entities;

namespace EF_DataAnnotation.Entities;


[Index(nameof(Name), IsUnique = true)]
public class Subject : BaseEntity
{


    [Required]
    [Column(TypeName = "nvarchar(100)")]
    [MinLength(1)]
    public string Name { get; set; }

    // Navigation property
    public ICollection<Lecture> Lectures { get; set; }
}
