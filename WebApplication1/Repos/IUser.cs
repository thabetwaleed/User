using WebApplication1.Model;

namespace WebApplication1.Repos
{
    public interface IUser
    {
        List<user> GetUsersList();
        user GetProfileByName(string usernamne);
        Response Add(user UserModel);
        Response Update(user UserModel);
        Response FollowUser(string usernamne);
        Response UnFollowUser(string usernamne);

    }
}
