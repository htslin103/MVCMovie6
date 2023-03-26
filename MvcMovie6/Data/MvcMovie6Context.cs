using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie6.Models;

namespace MvcMovie6.Data
{
    public class MvcMovie6Context : DbContext
    {
        public MvcMovie6Context (DbContextOptions<MvcMovie6Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie6.Models.Movie> Movie { get; set; } = default!;
    }
}
