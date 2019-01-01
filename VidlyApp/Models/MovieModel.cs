using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyApp.Models
{
    public class MovieModel
    {
        public String Name { get; set; }

        public int Id { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }


        public MovieModel()
        {
            DateAdded = DateTime.Now;
        }
    }
}