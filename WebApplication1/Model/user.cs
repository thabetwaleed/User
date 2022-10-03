using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class user
    {
        [Required]
        public string? password { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? username { get; set; }
        public string? bio { get; set; }
        public string? token { get; set; }
        public string? image { get; set; }
        public bool following { get; set; }

        public user(string? password, string email, string username, string bio, string token, string image)
        {
            this.image = image;
            this.username = username;
            this.password=password;
            this.token = token;
            this.email = email;
            this.bio = bio;


        }
    }
}
