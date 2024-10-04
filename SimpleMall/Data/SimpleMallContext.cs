using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleMall.Models;

namespace SimpleMall.Data
{
    public class SimpleMallContext : DbContext
    {
        public SimpleMallContext (DbContextOptions<SimpleMallContext> options)
            : base(options)
        {
        }

        public DbSet<SimpleMall.Models.User> User { get; set; } = default!;

        public DbSet<SimpleMall.Models.Product> Product { get; set; } = default!;

        public DbSet<SimpleMall.Models.Order> Order { get; set; } = default!;
    }
}
