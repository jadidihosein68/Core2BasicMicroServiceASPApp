using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroService.common.MicroServiceDbContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly MicroServiceDbContext _catalogContext;
       // private readonly AppSettings _settings;
       // private readonly ICatalogIntegrationEventService _catalogIntegrationEventService;

    }
}