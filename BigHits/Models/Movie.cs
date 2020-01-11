using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebGrease.Activities;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigHits.Models
{
    public class Movie
    {
        [ScaffoldColumn(false)]
        public int MovieID { get; set; }

        [Required, StringLength(100), Display(Name = "Title")]
        public string MoviesName { get; set; }

        [Required, Display(Name = "Released Year")]
        public int ReYear { get; set; }

        [Required, StringLength(500), Display(Name = "About Movie"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public string Rating { get; set; }

        public string FileName { get; set; }

        public string ImgPath { get; set; }

        [Display(Name ="Poster")]
        public string AltText { get; set; }

        public int? GenreID { get; set; }

        public virtual Genre Genre { get; set; }

        

        


    }

    
}

