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
    
    public partial class RecursoComputacional
    {
        public RecursoComputacional()
        {
            this.RecursoSolicitado = new HashSet<RecursoSolicitado>();
        }
    
        public int IdRecursoComputacional { get; set; }
        public string IdSala { get; set; }
        public string Nome { get; set; }
    
        public virtual ICollection<RecursoSolicitado> RecursoSolicitado { get; set; }
        public virtual Sala Sala { get; set; }
    }
}