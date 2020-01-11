using BigHits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;

namespace BigHits.Controllers
{
    public class ShoppingCartController : Controller
    {

        private MovieContext db = new MovieContext();
        private string strcart = "Cart";

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderNow(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (Session[strcart] == null)
            {
                List<Cart> IsCart = new List<Cart>
                {
                    new Cart(db.Movies.Find(id),1)
                };
                Session[strcart] = IsCart;
            }
            else
            {
                List<Cart> IsCart = (List<Cart>)Session[strcart];
                int check = isExistingCheck(id);
                if (check == -1)
                    IsCart.Add(new Cart(db.Movies.Find(id), 1));
                else
                    IsCart[check].Quantity++;
                Session[strcart] = IsCart;
            }

            return View("Index");
        }

        private int isExistingCheck(int? id)
        {
            List<Cart> IsCart = (List<Cart>)Session[strcart];
            for(int i=0; i<IsCart.Count; i++)
            {
                if (IsCart[i].Movie.MovieID == id) return i;
            }
            return -1;
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int check = isExistingCheck(id);
            List<Cart> IsCart = (List<Cart>)Session[strcart];
            IsCart.RemoveAt(check);
            return View("Index");
        }

        public ActionResult UpdateCart(FormCollection frc)
        {
            string[] quantities = frc.GetValues("quantity");
            List<Cart> IsCart = (List<Cart>)Session[strcart];
            for (int i= 0; i<IsCart.Count;i++)
            {
                IsCart[i].Quantity = Convert.ToInt32(quantities[i]);
            }
            Session[strcart] = IsCart;
            return View("Index");
        }

        public ActionResult CheckOut()
        {
            return View("CheckOut");
        }

        public ActionResult ProcessOrder()
        {
            return View("OrderSuccess");
        }
    }
}