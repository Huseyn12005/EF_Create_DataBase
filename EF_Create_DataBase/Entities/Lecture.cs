using EF_Create_DataBase.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DataAnnotation.Entities;

public class Lecture : BaseEntity
{

    [Column(TypeName = "date")]
    [Required]
    public DateTime DateOfLecture { get; set; }

    // Foreign Key
    [Required]
    [ForeignKey(nameof(Subject))]
    public int SubjectId { get; set; }

    [Required]
    [ForeignKey(nameof(Teacher))]
    public int TeacherId { get; set; }

    // Navigation property
    public Subject Subject { get; set; }
    public Teacher Teacher { get; set; }
    public ICollection<GroupLecture> groups { get; set; }
}
