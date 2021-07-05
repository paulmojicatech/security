using System;
namespace PaulMojicaTech.Security.Models.RequestModels
{
    public class AuthenticateRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
