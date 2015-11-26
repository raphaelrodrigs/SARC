using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Repositorio
{
    public class RecursoComputacionalRep
    {
        private DesenvolvimentoLocalEntities Contexto;
        public RecursoComputacionalRep()
        {
            Contexto = new DesenvolvimentoLocalEntities();
        }
        //lista os recurso computacionais alocados
        //TODO:
        public List<RecursoComputacional> Listar(int idProfessor)
        {
            return Contexto.RecursoComputacional.ToList();
        }

        public List<RecursoComputacional> Listar()
        {
            return Contexto.RecursoComputacional.ToList();
        }

        public void Inserir(RecursoComputacional modelo)
        {
            Contexto.RecursoComputacional.Add(modelo);
            Contexto.Dispose();
        }
        public void Excluir(int id)
        {
          Contexto.RecursoComputacional.Remove(new RecursoComputacional() { IdRecursoComputacional = id });
        }
        public void Alterar(RecursoComputacional modelo)
        {
            Contexto.RecursoComputacional.Remove(modelo);
            
        }
    }
}
