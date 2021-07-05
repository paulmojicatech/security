using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using PaulMojicaTech.Security.Models;
using PaulMojicaTech.Security.Models.RequestModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaulMojicaTech.Security.Controllers
{
    public class SecurityController : Controller
    {
        [Route("api/[controller]/authenticate")]
        [Consumes(MediaTypeNames.Application.Json)]
        [HttpPost]
        public IActionResult Authenticate([FromBody]AuthenticateRequest authReq)
        {
            try
            {
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
