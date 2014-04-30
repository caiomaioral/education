using Sistema.Infantil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema.Infantil.Controllers
{
    public class LoginController : Controller
    {
        //
        // Instancia o banco de dados
        InfantilContext db = new InfantilContext();
        
        //
        // Tela principal do Login
        public ActionResult Index()
        {
            if(Request.IsAuthenticated)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            else
            {
                return View();
            }
        }

        //
        // POST da tela de login
        [HttpPost]
        public ActionResult Index(Usuario model)
        {
            if(ModelState.IsValid)
            {


            }
            
            return View(model);
        }
	}
}