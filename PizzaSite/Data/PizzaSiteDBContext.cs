using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaSite.Model;

namespace PizzaSite.Data
{
    public class PizzaSiteDBContext : DbContext
    {
        public PizzaSiteDBContext (DbContextOptions<PizzaSiteDBContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaSite.Model.PizzaSpecial> PizzaSpecial { get; set; } = default!;
    }
}
