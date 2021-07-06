using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.JsonWebTokens;
using PaulMojicaTech.Security.Models;
using PaulMojicaTech.Security.Models.RequestModels;
using PaulMojicaTech.Security.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaulMojicaTech.Security.Controllers
{
    public class SecurityController : Controller
    {
        private readonly IConfiguration _configuration;

        public SecurityController(IConfiguration configuarition)
        {
            _configuration = configuarition;
        }

        [Route("api/[controller]/authenticate")]
        [Consumes(MediaTypeNames.Application.Json)]
        [HttpPost]
        public IActionResult Authenticate([FromBody]AuthenticateRequest authReq)
        {
            try
            {
                string authSecret = _configuration["AuthSecret"];
                AuthUtilService authSvc = new AuthUtilService(authSecret);
                User addedUser = authSvc.CreateUserModel(authReq);
                return Ok(authReq);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
