using estudos.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudosController
    {
        [HttpGet]
        public void Get()
        {
            var delegateEstudos = new DelegateEstudo();

            delegateEstudos.MultiCastDelegate("JOAO");
        }
    }
}
