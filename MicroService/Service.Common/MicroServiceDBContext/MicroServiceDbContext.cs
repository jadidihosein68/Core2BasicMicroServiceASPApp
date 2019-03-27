using Microsoft.EntityFrameworkCore;
using Service.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.MicroServiceDbContext
{
    public class MicroServiceDbContext : DbContext
    {
        public MicroServiceDbContext(DbContextOptions<MicroServiceDbContext> options) : base(options)
        {
        }

        public DbSet<SampleModel> SampleModel { get; set; }
    }

}

