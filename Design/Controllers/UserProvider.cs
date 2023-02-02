using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Store.Controllers
{
    public class UserProvider
    {
        private UserGenerator _userGenerator { get; set; }
        private User _currentUser { get; set; }

        public UserProvider(UserGenerator userGenerator)
        {
            _userGenerator = userGenerator;
        }

        public List<User> GetAllUsers() { return _userGenerator.Users; }
        public User GetCurrentUser()
        {
            return _currentUser;
        }
        public void SetCurrentUser(User user)
        {
            _currentUser = user;
        }

        public bool ValidateAndSetUser(string email, string password)
        {
           var currentUser = _userGenerator.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (currentUser == null) { return false; }
            SetCurrentUser(currentUser);
            return true;
        }

    }
}
