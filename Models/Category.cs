using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Image")]
        [Url]
        public string Image { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}