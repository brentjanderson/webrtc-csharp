using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace WebRTC_CS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Ask()
        {
            return View();
        }

        public ActionResult ProcessRequest()
        {
            var emailName = Request["name"];
            var emailSubject = Request["subject"];
            var emailMessage = Request["message"];
            var errorMessage = "";
            var debuggingFlag = false;
            try
            {
                // Initialize WebMail helper
                WebMail.SmtpServer = "smtp.mandrillapp.com";
                WebMail.SmtpPort = 587;
                WebMail.UserName = "me@brentjanderson.com";
                WebMail.Password = "DcBtial3NO8JkSKjkDzRTw";
                WebMail.From = "noreply@brentjanderson.com";

                // Send email
                WebMail.Send(to: "me@brentjanderson.com",
                    subject: "MSG: " + emailName + " " + emailSubject + " ",
                    body: emailMessage
                );
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            ViewBag.emailName = emailName;
            ViewBag.errorMessage = errorMessage;
            ViewBag.debuggingFlag = debuggingFlag;
            ViewBag.emailSubject = emailSubject;
            return View();
        }
    }
}
