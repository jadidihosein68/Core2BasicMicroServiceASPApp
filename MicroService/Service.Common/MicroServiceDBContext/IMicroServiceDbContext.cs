using Microsoft.EntityFrameworkCore;
using Service.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.MicroServiceDBContext
{
    public interface IMicroServiceDbContext
    {
        DbSet<SampleModel> SampleModel { get; set; }
    }
}
