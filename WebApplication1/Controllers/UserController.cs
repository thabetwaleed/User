using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using WebApplication1.Model;
namespace WebApplication1.Controllers
{
    [ApiController]
    public class UserController
    {
        private List<user> userlist = new List<user>();
        private List<article> articles = new List<article>();
        private List<comment> Comments = new List<comment>();
        private List<string> taglist = new List<string>();
        int id = 1;
        //get user
        [Route("/user")]
        [HttpGet]
        public ActionResult Get()
        {


            return new JsonResult(new { User = userlist });

        }
        //create user
        [HttpPost]
        [Route("/user")]
        public IActionResult Post([FromBody] user u)
        {
            string e = u.email;
            string n = u.username;
            string p = u.password;
            user? currentuser = null;
            foreach (user user in userlist)
            {
                if (user.email == e) currentuser = user;
            }

            if (currentuser != null) return new JsonResult(new { message = "user already exist" });
            else
            {
                user newuser = new user(p, e, n, "", "", "");
                userlist.Add(newuser);
                return new JsonResult(new { email = u.email, username = u.username, password = u.password });
            }
        }

        //update user
        [HttpPut]
        [Route("/user")]
        public IActionResult Put([FromBody] user u)
        {
            user? current = null;
            string msg = "";
            foreach (user user in userlist)
            {
                if (u.email == user.email)
                {
                   
                    user.bio =u. bio;
                    user.image = u.image;
                    msg = "information updated";
                    current = user;
                }
                else { msg = "Error"; }
            }
            return new JsonResult(new { message = msg, user = current });
        }
        //get profile
        [HttpGet]
        [Route("/profiles/{username}")]
        public IActionResult GetProfile(string username)
        {
            user? u = null;
           
            foreach (user user in userlist)
            {
                if (username == user.username)
                {
                    u = user;
                }
            }
            if (u != null) return new JsonResult(new { user = u });
            else return new JsonResult(new { message = "user not found" });

        }
    }
}
