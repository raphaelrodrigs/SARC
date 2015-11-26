using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio.Negocio
{
    public static class RecursoComputacionalNeg
    {

        //lista os recurso computacionais alocados
        public static List<RecursoComputacional> ListarPorProfessor(int idProfessor)
        {
            RecursoComputacionalRep rc = new RecursoComputacionalRep();
            return rc.Listar(idProfessor);
        }

        //LISTA TODOS OS RECURSOS PARA FAZER A ALOCAÇÃO
        public static List<RecursoComputacional> Listar()
        {
            RecursoComputacionalRep rc = new RecursoComputacionalRep();
            return rc.Listar();
        }
    }
}