using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigHits.Models
{
    public class Cart
    {
        //[Key]
        //public int ItemId { get; set; }

        //public int CartId { get; set; }

        public Movie Movie { get; set; }

        public int Quantity { get; set; }

        //public DateTime DateCreated { get; set; }

        public Cart(Movie movie, int quantity)
        {
            Movie = movie;
            Quantity = quantity;
        }



    }
}