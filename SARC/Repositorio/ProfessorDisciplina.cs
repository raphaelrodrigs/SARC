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
    
    public partial class ProfessorDisciplina
    {
        public int IdProfessorDisciplina { get; set; }
        public string IdProfessor { get; set; }
        public int IdDisciplina { get; set; }
    
        public virtual Disciplina Disciplina { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
