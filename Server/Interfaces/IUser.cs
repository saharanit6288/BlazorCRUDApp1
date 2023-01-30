using BlazorCRUDApp2.Shared.Models;

namespace BlazorCRUDApp2.Server.Interfaces
{
    public interface IUser
    {
        public List<User> GetUsers();

        public User GetUserById(int id);

        public void AddUser(User user);

        public void UpdateUser(User user);

        public void DeleteUser(int id); 
    }
}
