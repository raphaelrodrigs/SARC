using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.Negocio;

namespace SARC.Controllers
{
    public class RecursoComputacionalController : Controller, IDisposable
    {
        // GET: /RecursoComputacional/
        public ActionResult Grid()
        {
            try
            {
                return View(RecursoComputacionalNeg.Listar());
            }
            catch (Exception exc)
            {
                throw exc;
            }
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