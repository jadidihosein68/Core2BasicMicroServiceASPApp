using Example.Service.Repository;
using Microsoft.Extensions.Options;
using Service.Common.Models;
using Service.Common.Models.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Service.Application
{
    public class ExampleApplication : IExampleApplication
    {
        private readonly IExampleRepository _exampleRepository;
        private readonly AppSettings _appSettings;

        public ExampleApplication(IExampleRepository exampleRepository ,
            IOptionsSnapshot<AppSettings> appSettings )
        {
            _appSettings = appSettings.Value; 
            _exampleRepository = exampleRepository;
        }

        public SampleModel getSampleModelWithSomeLogic()
        {
            var result =  _exampleRepository.getSampleModelFromAdaptor();
            // do some logic 
            return result;
        }
    }
}
