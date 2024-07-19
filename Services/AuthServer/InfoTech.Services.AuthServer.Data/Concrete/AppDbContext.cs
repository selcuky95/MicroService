using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoTech.Services.AuthServer.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.Services.AuthServer.Data.Concrete
{
    public class AppDbContext: IdentityDbContext < AppUser, IdentityRole, String >
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
            
        }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}