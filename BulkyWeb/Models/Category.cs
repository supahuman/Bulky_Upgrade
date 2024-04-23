using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        //properties

        [Key]//primary key
        public int Id { get; set; }
        [Required]//No null values allowed
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
