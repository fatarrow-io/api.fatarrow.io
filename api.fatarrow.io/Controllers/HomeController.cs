using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace api.fatarrow.io.Controllers
{
    [EnableCors("http://local.fatarrow.io:8181", "*", "*")]
    public class HomeController : ApiController
    {
        public object Get()
        {
            return new Dictionary<string, string>
            {
                { "=>", "fatarrow.io" }
            };
        }

    }
}
