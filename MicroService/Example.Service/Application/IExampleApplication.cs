using Service.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Service.Application
{
    public interface IExampleApplication
    {
        SampleModel getSampleModelWithSomeLogic();
    }
}
