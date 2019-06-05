using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Example.Service.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Common.MicroServiceDbContext;
using Service.Common.Models;
using Service.Common.Models.DTOs;

namespace MicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IExampleApplication _exampleApplication;
        private readonly IMapper _mapper;

        public SampleController(IExampleApplication ExampleApplication
            ,IMapper mapper)
        {
            _exampleApplication = ExampleApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<SampleModelDto> Get()
        {
            var result = _exampleApplication.getSampleModelWithSomeLogic();
            return _mapper.Map<SampleModelDto>(result);
        }

    }
}