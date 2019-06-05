using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Service.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.Persistence.EntityConfigurations
{
    public class SampleModelConfigration : IEntityTypeConfiguration<SampleModel>
    {
        public void Configure(EntityTypeBuilder<SampleModel> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(12);
        }
    }
}
