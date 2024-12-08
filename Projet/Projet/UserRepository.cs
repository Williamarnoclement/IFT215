using System;
using System.Collections.Generic;
using System.Linq;

namespace Projet
{
    public class UserRepository
    {
        private List<User> Users = new List<User>()
        {
            new User("Grégory","Greg@gmail.com","1-234-654-7678",43),
            new User("Jacques","Jack@hotmail.com","1-234-756-5438",25),
            new User("André","andy@live.ca","1-124-214-7467",32),
            new User("Jane","jaja@gmail.com","1-224-654-7678",48),
            new User("Georgette","ge.gette@gmail.com","1-267-564-7528",28),
            new User("Léo","Léo&Léa@outlook.com","1-654-632-5682",27),
            new User("Léa","Léo&Léa@outlook.com","1-654-632-5682",75),
            new User("Laura","kestrel@hotmail.com","3-127-234-6778",30),
        };
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
