//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SemanaAcademica.Models.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evento
    {
        public Evento()
        {
            this.Horario = new HashSet<Horario>();
            this.Matricula = new HashSet<Matricula>();
            this.Minicurso = new HashSet<Minicurso>();
            this.Oficina = new HashSet<Oficina>();
            this.Palestra = new HashSet<Palestra>();
            this.Participacao = new HashSet<Participacao>();
            this.Visita = new HashSet<Visita>();
        }
    
        public int id_evento { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<Horario> Horario { get; set; }
        public virtual ICollection<Matricula> Matricula { get; set; }
        public virtual ICollection<Minicurso> Minicurso { get; set; }
        public virtual ICollection<Oficina> Oficina { get; set; }
        public virtual ICollection<Palestra> Palestra { get; set; }
        public virtual ICollection<Participacao> Participacao { get; set; }
        public virtual ICollection<Visita> Visita { get; set; }
    }
}
