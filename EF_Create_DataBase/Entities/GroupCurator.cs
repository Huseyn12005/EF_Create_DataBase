using EF_Create_DataBase.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DataAnnotation.Entities;

public class GroupCurator : BaseEntity
{


    // Foreign Key
    [Required]
    [ForeignKey(nameof(Curator))]
    public int CuratorId { get; set; }

    [Required]
    [ForeignKey(nameof(Group))]
    public int GroupId { get; set; }




    // Navigation property
    public Curator Curator { get; set; }
    public Group Group { get; set; }
}
