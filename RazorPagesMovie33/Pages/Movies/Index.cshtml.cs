using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie33.Data;
using RazorPagesMovie33.Models;

namespace RazorPagesMovie33.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie33.Data.RazorPagesMovie33Context _context;

        public IndexModel(RazorPagesMovie33.Data.RazorPagesMovie33Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
