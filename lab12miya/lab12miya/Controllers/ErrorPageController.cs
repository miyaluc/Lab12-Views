using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab12miya.Controllers
{
    [Route("Error")]
    public class ErrorPageController
    {
        public string Error()
        {
            return "Oops. Something's not right....";
        }
    }
}
