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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie33.Data.RazorPagesMovie33Context _context;

        public DetailsModel(RazorPagesMovie33.Data.RazorPagesMovie33Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
