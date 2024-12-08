using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public User(string name, string email, string phoneNumber, int age) 
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Age = age;
        }
    }
}
