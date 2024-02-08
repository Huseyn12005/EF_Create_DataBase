using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using EF_Create_DataBase.Entities;

namespace EF_DataAnnotation.Entities;


[Index(nameof(Name), IsUnique = true)]
public class Group : BaseEntity
{

    [Required]
    [Column(TypeName = "nvarchar(10)")]
    [MinLength(1)]
    public string Name { get; set; }

    [Required]
    [Range(1, 5, ErrorMessage = "Error")]
    public int Year { get; set; }




    // Foreign Key
    [Required]
    [ForeignKey(nameof(Department))]
    public int DepartmentId { get; set; }




    // Navigation property
    public Department Department { get; set; }
    public ICollection<GroupCurator> groups { get; set; }
}
