using Example.Service.Adapter;
using Service.Common.MicroServiceDBContext;
using Service.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Service.Repository
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly IExampleAdapter _exampleAdapter;
        private readonly IMicroServiceDbContext _microServiceDbContext;

        public ExampleRepository(IExampleAdapter exampleAdapter,
                                 IMicroServiceDbContext microServiceDbContext)
        {
            _exampleAdapter = exampleAdapter;
            microServiceDbContext = _microServiceDbContext;
        }

        public SampleModel getSampleModelFromAdaptor()
        {
            return _exampleAdapter.getSampleModel();
        }
    }
}
