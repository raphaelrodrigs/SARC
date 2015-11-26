using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio.Negocio
{
    public static class ProfessorlNeg
    {
        public static List<Professor> Listar()
        {
            ProfessorRep rc = new ProfessorRep();
            return rc.Listar();
        }

        public static List<Professor> Listar(int id)
        {
            ProfessorRep rc = new ProfessorRep();
            return rc.Listar();
        }
    }
}