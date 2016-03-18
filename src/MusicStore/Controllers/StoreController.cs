using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using MusicStore.Extensions;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {

        private AppSettings _appSettings;

        public StoreController(MusicStoreContext dbContext, IOptions<AppSettings> appSettings)
        {
            DbContext = dbContext;
            _appSettings = appSettings.Value;
        }

        public MusicStoreContext DbContext { get; }

        //
        // GET: /Store/
        public async Task<IActionResult> Index()
        {
            var genres = await DbContext.Genres.ToListAsync();

            return View(genres);
        }

        //
        // GET: /Store/Browse?genre=Disco
        public async Task<IActionResult> Browse(string genre)
        {
            // Retrieve Genre genre and its Associated associated Albums albums from database
            var genreModel = await DbContext.Genres
                .Include(g => g.Albums)
                .Where(g => g.Name == genre)
                .FirstOrDefaultAsync();

            if (genreModel == null)
            {
                return NotFound();
            }

            return View(genreModel);
        }

        public async Task<IActionResult> Details(
            [FromServices] IMemoryCache cache,
            int id)
        {
            var cacheKey = string.Format("album_{0}", id);
            Album album;
            if (!cache.TryGetValueExt(cacheKey, out album, _appSettings.CacheTimeoutSeconds))
            {
                album = await DbContext.Albums
                                .Where(a => a.AlbumId == id)
                                .Include(a => a.Artist)
                                .Include(a => a.Genre)
                                .FirstOrDefaultAsync();

                if (album != null)
                {
                    //Remove it from cache if not retrieved in last 10 minutes
                    cache.SetExt(
                        cacheKey,
                        album,
                        new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(_appSettings.CacheTimeoutSeconds > 0 ? _appSettings.CacheTimeoutSeconds : 1)),
                     _appSettings.CacheTimeoutSeconds);
                }
            }

            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }
    }
}