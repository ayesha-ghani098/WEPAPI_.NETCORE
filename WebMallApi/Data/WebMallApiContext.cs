using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMallApi.Models;

namespace WebMallApi.Data
{
    public class WebMallApiContext : DbContext
    {
        public WebMallApiContext (DbContextOptions<WebMallApiContext> options)
            : base(options)
        {
        }

        public DbSet<WebMallApi.Models.Product>? Product { get; set; }
    }
}
