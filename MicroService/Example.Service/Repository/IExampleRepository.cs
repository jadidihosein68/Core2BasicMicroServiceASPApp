using Service.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Service.Repository
{
    public interface IExampleRepository
    {
        SampleModel getSampleModelFromAdaptor();
    }
}
