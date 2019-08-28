using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppProxyWindowsAuth.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DataController : ApiController
    {
        // GET: api/Data
        public IEnumerable<string> Get()
        {
            return new string[] {
                "You have successfully called an API"
                , "And the API sees you as: " + User.Identity.Name
                , "And your authentication is: " + User.Identity.AuthenticationType
            };
        }

   }
}
