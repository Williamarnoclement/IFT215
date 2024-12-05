using System;
using System.Collections.Generic;
using System.Linq;

namespace Projet
{
    public class UserRepository
    {
        private List<User> Users = new List<User>();
        public event Action? UsersChanged;

        public List<User> GetAllUsers() => Users;

        public User? GetUserById(int id) => Users.FirstOrDefault(u => u.Id == id);

        public void AddUser(User user)
        {
            if (!Users.Any(u => u.Id == user.Id)) // Eviter les doublons
            {
                Users.Add(user);
                UsersChanged?.Invoke();
            }
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
            UsersChanged?.Invoke();
        }
    }
}
