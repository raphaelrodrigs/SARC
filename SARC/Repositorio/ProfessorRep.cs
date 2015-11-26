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
        
        public List<Professor> Listar()
        {
            return Contexto.Professor.ToList();
        }

        public List<Professor> Listar()
        {
            return Contexto.Professor.ToList();
        }

        public void Inserir(Professor modelo)
        {
            Contexto.Professor.Add(modelo);
            Contexto.Dispose();
        }
        public void Excluir(int id)
        {
          Contexto.Professor.Remove(new Professor() { IdProfessor = id });
        }
        public void Alterar(Professor modelo)
        {
            Contexto.RecursoComputacional.Remove(modelo);
            
        }
    }
}
