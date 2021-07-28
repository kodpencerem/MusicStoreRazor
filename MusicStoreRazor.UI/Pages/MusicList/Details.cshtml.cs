using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicStoreRazor.UI.Models;

namespace MusicStoreRazor.UI.Pages.MusicList
{
    public class DetailsModel : PageModel
    {
        private readonly MusicStoreRazor.UI.Models.MusicStoreDbContext _context;

        public DetailsModel(MusicStoreRazor.UI.Models.MusicStoreDbContext context)
        {
            _context = context;
        }

        public Music Music { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Music = await _context.Musics.FirstOrDefaultAsync(m => m.Id == id);

            if (Music == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
