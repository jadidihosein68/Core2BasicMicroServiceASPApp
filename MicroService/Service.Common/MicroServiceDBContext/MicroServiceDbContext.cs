using Microsoft.EntityFrameworkCore;
using Service.Common.MicroServiceDBContext;
using Service.Common.Models;
using Service.Common.Persistence.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.MicroServiceDbContext
{
    public class MicroServiceDbContext : DbContext , IMicroServiceDbContext
    {
        public MicroServiceDbContext(DbContextOptions<MicroServiceDbContext> options) : base(options)
        {
        }

        public DbSet<SampleModel> SampleModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SampleModelConfigration());
        }
    }

}

