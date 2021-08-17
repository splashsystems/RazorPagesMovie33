using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie33.Models;

namespace RazorPagesMovie33.Data
{
    public class RazorPagesMovie33Context : DbContext
    {
        public RazorPagesMovie33Context (DbContextOptions<RazorPagesMovie33Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie33.Models.Movie> Movie { get; set; }
    }
}
