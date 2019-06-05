using Example.Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Service.Application
{
    public class ExampleApplication : IExampleApplication
    {

        private readonly IExampleRepository _exampleRepository;
        public ExampleApplication(IExampleRepository exampleRepository
            
            )
        {
            _exampleRepository = exampleRepository;
        }
    }
}
