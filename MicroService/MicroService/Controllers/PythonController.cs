using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Service.Common.Adapters;
using Service.Common.Models;
using Service.Common.Models.Configurations;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PythonController : ControllerBase
    {

        public PythonController(
            IOptions<AppSettings> _appSettings,
            IPythonAdapter _PythonAdapter
            )
        {
            AppSettings = _appSettings.Value;
            PythonAdapter = _PythonAdapter;
        }

        private readonly AppSettings AppSettings;
        private readonly IPythonAdapter PythonAdapter;

        [HttpGet]
        public ActionResult Get()
        {

            var result = PythonAdapter.get();
            return Ok(result);               
        }


    }
}