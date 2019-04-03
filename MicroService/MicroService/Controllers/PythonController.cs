using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Adapters;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PythonController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {

            var _pythonAdapter = new PythonAdapter();
            var result = _pythonAdapter.get();
            return Ok(result);
        }


    }
}