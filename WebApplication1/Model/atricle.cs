using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class article
    {
        [Required]

        public string? title;
        [Required]
        public string? description;
        [Required]
        public string? body;
       
        public bool favorited;
        [Required]
        public user author;
        [Required]
        public string? slug;
        public string? tag;
    }
}
