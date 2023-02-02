using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Controllers
{
    public class UserGenerator
    {
        public List<User> Users { get; set; } = new List<User> {
            new User("12345678910", "John", "Doe@mail.com","1234", "customer"),
            new User("12345678911", "Deol", "JonDoel@mail.com","5678", "customer"),
            new User("12345678912", "Johnny", "Johnny@mail.com","0000", "customer"),
        };
    }
}
