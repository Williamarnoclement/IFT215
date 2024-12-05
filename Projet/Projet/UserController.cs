using System;
using System.Collections.Generic;

namespace Projet
{
    public class UserController
    {
        private readonly UserRepository UserRepository;

        public UserController(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public List<User> GetUsers() => UserRepository.GetAllUsers();

        public User? GetUser(int id) => UserRepository.GetUserById(id);

        public List<User> GetAllUsers()
        {
            return UserRepository.GetAllUsers(); // Suppose que GetAllUsers() existe dans UserRepository
        }

        public void AddUser(User user)
        {
            if (user != null)
                UserRepository.AddUser(user);
        }

        public void RemoveUser(User user)
        {
            if (user != null)
                UserRepository.RemoveUser(user);
        }
    }
}
