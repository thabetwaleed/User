using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
using Microsoft.AspNetCore.Identity;
public class userContext : DbContext
    {
        public userContext(DbContextOptions options): base(options) {}
    DbSet < user > user{ get; set;}
    DbSet<comment> comment { get; set; }
    DbSet<article> article { get; set; }


}

