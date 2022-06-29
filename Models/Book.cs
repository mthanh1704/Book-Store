using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Image")]
        [Url]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}