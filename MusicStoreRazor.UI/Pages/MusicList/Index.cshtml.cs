using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicStoreRazor.UI.Models;

namespace MusicStoreRazor.UI.Pages.MusicList
{
    public class IndexModel : PageModel
    {
        private readonly MusicStoreRazor.UI.Models.MusicStoreDbContext _context;

        public IndexModel(MusicStoreRazor.UI.Models.MusicStoreDbContext context)
        {
            _context = context;
        }

        public IList<Music> Music { get;set; }

        public async Task OnGetAsync()
        {
            Music = await _context.Musics.ToListAsync();
        }
    }
}
