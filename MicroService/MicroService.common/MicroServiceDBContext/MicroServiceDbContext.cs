using MicroService.common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.common.MicroServiceDbContext
{
    public class MicroServiceDbContext : DbContext
    {
        public MicroServiceDbContext(DbContextOptions<MicroServiceDbContext> options) : base(options)
        {
        }

        public DbSet<SampleModel> SampleModel { get; set; }
    }

}

