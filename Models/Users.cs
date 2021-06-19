using System;
using System.Collections.Generic;

namespace PaulMojicaTech.Security.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime LastLoggedIn { get; set; }
        public Application Application { get; set; }
    }

    public class Application
    {
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public List<User> Users { get; set; }
    }

}
