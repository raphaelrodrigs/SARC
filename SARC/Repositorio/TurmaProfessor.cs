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
    
    public partial class TurmaProfessor
    {
        public TurmaProfessor()
        {
            this.TurmaProfessorDisciplina = new HashSet<TurmaProfessorDisciplina>();
        }
    
        public int IdTurmaProfessor { get; set; }
        public int IdTurma { get; set; }
        public string IdProfessor { get; set; }
    
        public virtual Professor Professor { get; set; }
        public virtual Turma Turma { get; set; }
        public virtual ICollection<TurmaProfessorDisciplina> TurmaProfessorDisciplina { get; set; }
    }
}
