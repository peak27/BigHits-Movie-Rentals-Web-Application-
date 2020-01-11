using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigHits.Models
{
    public class Genre
    {
        public Genre()
        {
            this.Movies = new HashSet<Movie>();
        }

        [ScaffoldColumn(false)]
        public int GenreID { get; set; }

        [Required, StringLength(100), Display(Name ="Genre")]
        public string GenreType { get; set; }

        [Display (Name = "Movie Description")]
        public string Description { get; set; }

       public virtual ICollection<Movie> Movies { get; set; }
    }
}