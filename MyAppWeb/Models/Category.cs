using System.ComponentModel.DataAnnotations;

namespace MyAppWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }
        public string Field{ get; set; }
        public string Degree { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
