using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MusicStore.Models;
using Xunit;
using MusicStore.Test;

namespace MusicStore.Controllers
{
    public class HomeControllerTest
    {
        private readonly IServiceProvider _serviceProvider;

        public HomeControllerTest()
        {
            var services = new ServiceCollection();

            services.AddDbContext<MusicStoreContext>(options => options.UseInMemoryDatabase());

            services.AddOptions();
            services.Configure<AppSettings>(appSettings =>
            {
                appSettings.SiteTitle = "Site Title";
                appSettings.CacheTimeout = 600;
            });

            _serviceProvider = services.BuildServiceProvider();
        }

        [Fact]
        public void Error_ReturnsErrorView()
        {

           var appSettings = _serviceProvider.GetRequiredService<IOptions<AppSettings>>();

            // Arrange
            var controller = new HomeController(appSettings);
            var errorView = "~/Views/Shared/Error.cshtml";

            // Act
            var result = controller.Error();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.Equal(errorView, viewResult.ViewName);
        }

        [Fact]
        public async Task Index_GetsSixTopAlbums()
        {
            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<MusicStoreContext>();
            var cache = _serviceProvider.GetRequiredService<IMemoryCache>();

            var appSettings = _serviceProvider.GetRequiredService<IOptions<AppSettings>>();

            var controller = new HomeController(appSettings);
            PopulateData(dbContext);

            // Action
            var result = await controller.Index(dbContext, cache);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);

            Assert.NotNull(viewResult.ViewData);
            Assert.NotNull(viewResult.ViewData.Model);

            var albums = Assert.IsType<List<Album>>(viewResult.ViewData.Model);
            Assert.Equal(6, albums.Count);
        }

        [Fact]
        public void StatusCodePage_ReturnsStatusCodePage()
        {
            var appSettings = _serviceProvider.GetRequiredService<IOptions<AppSettings>>();

            // Arrange
            var controller = new HomeController(appSettings);
            var statusCodeView = "~/Views/Shared/StatusCodePage.cshtml";

            // Action
            var result = controller.StatusCodePage();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.Equal(statusCodeView, viewResult.ViewName);
        }

        private void PopulateData(DbContext context)
        {
            var albums = TestAlbumDataProvider.GetAlbums();

            foreach (var album in albums)
            {
                context.Add(album);
            }

            context.SaveChanges();
        }

        private class TestAlbumDataProvider
        {
            public static Album[] GetAlbums()
            {
                var generes = Enumerable.Range(1, 10).Select(n =>
                    new Genre()
                    {
                        GenreId = n,
                        Name = "Genre Name " + n,
                    }).ToArray();

                var artists = Enumerable.Range(1, 10).Select(n =>
                    new Artist()
                    {
                        ArtistId = n + 1,
                        Name = "Artist Name " + n,
                    }).ToArray();

                var albums = Enumerable.Range(1, 10).Select(n =>
                    new Album()
                    {
                        Artist = artists[n - 1],
                        ArtistId = n,
                        Genre = generes[n - 1],
                        GenreId = n,
                    }).ToArray();

                return albums;
            }
        }
    }
}