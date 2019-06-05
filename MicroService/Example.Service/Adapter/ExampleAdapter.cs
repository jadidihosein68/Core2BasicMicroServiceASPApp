using System;
using System.Collections.Generic;
using System.Text;
using Service.Common.Models;

namespace Example.Service.Adapter
{
    public class ExampleAdapter : IExampleAdapter
    {
        public ExampleAdapter()
        {
        }

        public SampleModel getSampleModel()
        {
            return new SampleModel
            {
                Id = 1,
                Name = "Sample Object"
            };
        }
    }
}
