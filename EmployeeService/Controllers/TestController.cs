using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    public class TestController : ApiController
    {
        public String Get()
        {
            return "Hello from Test Controller";
        }
    }
}
