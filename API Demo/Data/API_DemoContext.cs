using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Demo.Model;

namespace API_Demo.Data
{
    public class API_DemoContext : DbContext
    {
        public API_DemoContext (DbContextOptions<API_DemoContext> options)
            : base(options)
        {
        }

        public DbSet<API_Demo.Model.User> User { get; set; } = default!;
    }
}
