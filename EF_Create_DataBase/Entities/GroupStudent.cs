using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EF_Create_DataBase.Entities;

namespace EF_DataAnnotation.Entities;

public class GroupStudent : BaseEntity
{


    // Foreign Key
    [Required]
    [ForeignKey(nameof(Student))]
    public int StudentId { get; set; }

    [Required]
    [ForeignKey(nameof(Group))]
    public int GroupId { get; set; }



    // Navigation property
    public Student Student { get; set; }
    public Group Group { get; set; }
}
