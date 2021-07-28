using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicStoreRazor.UI.Models;

namespace MusicStoreRazor.UI.Pages.MusicList
{
    public class CreateModel : PageModel
    {
        private readonly MusicStoreRazor.UI.Models.MusicStoreDbContext _context;

        public CreateModel(MusicStoreRazor.UI.Models.MusicStoreDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Music Music { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Musics.Add(Music);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
