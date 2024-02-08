using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EF_Create_DataBase.Entities;

namespace EF_DataAnnotation.Entities;

public class GroupLecture : BaseEntity
{

    // Foreign Key
    [Required]
    [ForeignKey(nameof(Lecture))]
    public int LectureId { get; set; }

    [Required]
    [ForeignKey(nameof(Group))]
    public int GroupId { get; set; }


    // Navigation property
    public Lecture Lecture { get; set; }
    public Group Group { get; set; }
}
