using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class comment
    {
        [Key]
        public int? id;
        public DateTime? createdAt;
        public DateTime? updatedAt;
        public string? body;
        public user author;
    }
}
