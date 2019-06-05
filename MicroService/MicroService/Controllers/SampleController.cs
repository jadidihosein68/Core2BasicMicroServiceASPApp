using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Service.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Common.MicroServiceDbContext;
using Service.Common.Models;

namespace MicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IExampleApplication _exampleApplication;
        public SampleController(IExampleApplication ExampleApplication)
        {
            _exampleApplication = ExampleApplication;
        }

        [HttpGet]
        public ActionResult<SampleModel> Get()
        {
            return _exampleApplication.getSampleModelWithSomeLogic();
        }

    }
}