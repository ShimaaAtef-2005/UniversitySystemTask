using System.ComponentModel.DataAnnotations;

namespace UniversitySystem.Models
{
    public class University
    {
        [Key]
        public int UniversityId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Address { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
            = new List<Teacher>();

        public ICollection<Student> Students { get; set; }
            = new List<Student>();

       
    }
}