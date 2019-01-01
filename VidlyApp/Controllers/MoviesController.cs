using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing.Printing;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class MoviesController : Controller
    {
        private MovieDbContext db = new MovieDbContext();

        
        private ApplicationDbContext _context;
        
        public MoviesController()
        {
            _context = new ApplicationDbContext();
            db.Database.Log = l => Debug.Write(l);

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            //return View(db.Movies.ToList());
            return View(movies);
        }

        
        public ActionResult Create()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new CustomerMovieViewModel
            {
                Movies = new Movies(),
                Genres = genres
            };
            return View("MoviesForm", viewModel);
           
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            var viewModel = new CustomerMovieViewModel
            {
                Genres = _context.Genres.ToList(),
                Movies = movie

            };
            return View("MoviesForm", viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movies movies)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerMovieViewModel
                {
                    Genres = _context.Genres.ToList(),
                    Movies = movies

                };
                return View("MoviesForm", viewModel);
            }

            if (movies.Id == 0)
                _context.Movies.Add(movies);
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movies.Id);
                if (movieInDb == null)
                    return HttpNotFound();

                movieInDb.Name = movies.Name;
                movieInDb.GenreId = movies.GenreId;
                movieInDb.ReleaseDate = movies.ReleaseDate;
                movieInDb.NumberInStock = movies.NumberInStock;

            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}