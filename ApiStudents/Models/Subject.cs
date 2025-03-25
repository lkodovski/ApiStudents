using System.ComponentModel.DataAnnotations;

namespace ApiStudents.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Credits { get; set; }
    }
}
