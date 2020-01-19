using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wisidentityapi.Models
{
    public class AuthenticationContext: IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options) : base(options)
        {

        }

       // public DbSet<ApplicationUser> ApplicationUsers { get; set; }
       public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
