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
    
    public partial class Pessoa
    {
        public Pessoa()
        {
            this.Administrador = new HashSet<Administrador>();
            this.Colaborador = new HashSet<Colaborador>();
            this.Convidado = new HashSet<Convidado>();
            this.Participante = new HashSet<Participante>();
        }
    
        public int id_pessoa { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string senha { get; set; }
        public System.Guid chave { get; set; }
        public bool confirmado { get; set; }
    
        public virtual ICollection<Administrador> Administrador { get; set; }
        public virtual ICollection<Colaborador> Colaborador { get; set; }
        public virtual ICollection<Convidado> Convidado { get; set; }
        public virtual ICollection<Participante> Participante { get; set; }
    }
}
