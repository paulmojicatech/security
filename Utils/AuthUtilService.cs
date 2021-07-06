using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PaulMojicaTech.Security.Models;
using PaulMojicaTech.Security.Models.RequestModels;

namespace PaulMojicaTech.Security.Utils
{
    public class AuthUtilService
    {
        private string _sercretKey { get; }

        public AuthUtilService(string secret)
        {
            _sercretKey = secret;
        }

        public User CreateUserModel(AuthenticateRequest req)
        {

            return null;
        }

        private string EncryptPassword(string password)
        {
            return string.Empty;
        }
    }
}
