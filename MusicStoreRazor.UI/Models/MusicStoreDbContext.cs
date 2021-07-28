using Microsoft.EntityFrameworkCore;

namespace MusicStoreRazor.UI.Models
{
    public class MusicStoreDbContext : DbContext
    {
        public MusicStoreDbContext(DbContextOptions<MusicStoreDbContext> dbContextOptions) : base(dbContextOptions)
        {

            
        }

        public DbSet<Music> Musics { get; set; }

    }
}
