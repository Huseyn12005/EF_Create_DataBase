using EF_Create_DataBase.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DataAnnotation.Entities;

public class Curator : BaseEntity
{

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    [MinLength(1)]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    [MinLength(1)]
    public string Surname { get; set; }




    // Navigation property
    public ICollection<GroupCurator> groups { get; set; }
}
