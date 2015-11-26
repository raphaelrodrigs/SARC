using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SARC.Controllers
{
    public class ProfessorController : Controller
    {
        //
        // GET: /Professor/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inserir()
        {
            return View();
        }

        public ActionResult Editar()
        {
            return View();

        }

        public ActionResult Excluir()
        {
            return View();
        }
	}
}