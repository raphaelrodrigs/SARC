//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio
{
    using System;
    using System.Collections.Generic;
    
    public partial class RecursoSolicitado
    {
        public RecursoSolicitado()
        {
            this.HorarioRecursoSolicitado = new HashSet<HorarioRecursoSolicitado>();
        }
    
        public int IdRecursoSolicitado { get; set; }
        public int IdRecursoComputacional { get; set; }
        public int IdTurmaProfessorDisciplina { get; set; }
    
        public virtual ICollection<HorarioRecursoSolicitado> HorarioRecursoSolicitado { get; set; }
        public virtual RecursoComputacional RecursoComputacional { get; set; }
        public virtual TurmaProfessorDisciplina TurmaProfessorDisciplina { get; set; }
    }
}
