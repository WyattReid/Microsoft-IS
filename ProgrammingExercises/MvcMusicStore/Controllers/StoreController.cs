using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            // Create a list of genres
            var genres = new List<string> {"Rock", "Jazz", "Country", "Pop", "Disco"};
            
            // Create our view model
            var viewModel = new StoreIndexViewModel()
            {
                NumberOfGenres = genres.Count(),
                Genres = genres
            };

            return this.View(viewModel);

        }

        // GET: Store/Browse
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        // GET: Store/Details
        public string Details(int id)
        {
            string message =  "Store.Details, ID = " + id;
            return message;
        }

        // GET: Store/Artists
        public ActionResult Artists(string id)
        {
            string genre = id;
            var viewModel = new StoreIndexViewModel()
            {
                Artists = new List<string>()
            };

            var artists = new List<string>();

            if (genre == "Country")
            {
                // Create a list of Country artists
                artists = new List<string> { "George Strait", "Garth Brooks", "Toby Keith", "Brad Paisley", "Brantley Gilbert" };
            }
            else if (genre == "Rock")
            {
                // Create a list of Rock artists
                artists = new List<string> { "Aerosmith", "AC/DC", "Nickelback", "Nirvana", "Rob Thomas" };
            }
            else if (genre == "Jazz")
            {
                // Create a list of Jazz artists
                artists = new List<string> { "Miles Davis", "Buddy Guy", "Louis Armstrong", "John Coltrane", "Sonny Rollins" };
            }
            else if (genre == "Pop")
            {
                // Create a list of Pop artists
                artists = new List<string> { "Lady Gaga", "Ariana Grande", "Flo-Rida", "NSync", "Taylor Swift" };
            }
            else if (genre == "Disco")
            {
                // Create a list of Disco artists
                artists = new List<string> { "Marvin Gaye", "Michael Jackson", "Donna Summer", "Barry White", "Diana Ross" };
            }


            return this.View(artists);
        }
    }
}