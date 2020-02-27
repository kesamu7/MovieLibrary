﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieLibrary.ViewModels
{
    public class MovieFormViewModel
    {

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateAdded { get; set; }

        
        [Range(1, 20)]
        [Display(Name = "Number In Stock")]
        [Required]
        public byte? NumberInStock { get; set; }


        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
    }
}