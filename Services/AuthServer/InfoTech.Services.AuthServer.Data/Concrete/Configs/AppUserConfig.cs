using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoTech.Services.AuthServer.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace InfoTech.Services.AuthServer.Data.Concrete.Configs
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x=>x.FName).IsRequired().HasMaxLength(14);
            builder.Property(x=>x.LName).IsRequired().HasMaxLength(14);
            builder.Property(x=>x.City).IsRequired().HasMaxLength(14);
        }
    }
}