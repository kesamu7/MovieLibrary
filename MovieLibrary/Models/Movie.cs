using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieLibrary.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateAdded { get; set; }

        //Add data annotation that requires a number between 1-20 be input on this input box.
        [Range(1,20)]
        [Display(Name = "Number In Stock")]
        public byte? NumberInStock { get; set; }


        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
    }
}