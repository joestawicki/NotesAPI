using System.ComponentModel.DataAnnotations;

namespace Notes.Model
{
    public class Note
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string body { get; set; }
    }
}
