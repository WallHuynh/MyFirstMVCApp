using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Data
{
    public class MyFirstMVCAppContext : DbContext
    {
        public MyFirstMVCAppContext (DbContextOptions<MyFirstMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstMVCApp.Models.Movie> Movie { get; set; } = default!;
    }
}
