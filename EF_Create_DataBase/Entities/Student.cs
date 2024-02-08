using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EF_Create_DataBase.Entities;

namespace EF_DataAnnotation.Entities;

public class Student : BaseEntity
{

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    [MinLength(1)]
    public string Name { get; set; }

    [Required]
    [Range(0, 5, ErrorMessage = "Error")]
    public int Rating { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    [MinLength(1)]
    public string Surname { get; set; }

    // Navigation property
    public ICollection<GroupStudent> groups { get; set; }
}
