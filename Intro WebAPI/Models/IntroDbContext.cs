using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_WebAPI.Models
{
    public class IntroDbContext : DbContext
    {
        public IntroDbContext(DbContextOptions<IntroDbContext> options) : base(options)
        {
        }
        public DbSet<Cake> Cakes{ get; set; }
    }
}
