using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BigHits.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace BigHits.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Big Hits is an online store for movie rentals.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Big Hits.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(EmailFormModel obj)
        {

            try
            {
                //Configuring webMail class to send emails  
                //gmail smtp server  
                WebMail.SmtpServer = "smtp.gmail.com";
                //gmail port to send emails  
                WebMail.SmtpPort = 587;
                WebMail.SmtpUseDefaultCredentials = true;
                //sending emails with secure protocol  
                WebMail.EnableSsl = true;
                //EmailId used to send emails from application  
                WebMail.UserName = "mjpk247.pk@gmail.com";
                WebMail.Password = "YourGmailPassword";

                //Sender email address.  
                WebMail.From = "mjpk247@gmail.com";

                //Send email  
                WebMail.Send(to: obj.ToEmail, subject: obj.EmailSubject, body: obj.EMailBody, isBodyHtml: true);
                ViewBag.Status = "Email Sent Successfully.";
            }
            catch (Exception)
            {
                ViewBag.Status = "Problem while sending email, Please check details.";

            }
            return View();
        }
    }
}
