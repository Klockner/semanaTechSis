﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SemanaAcademicaEntities : DbContext
    {
        public SemanaAcademicaEntities()
            : base("name=SemanaAcademicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Convidado> Convidado { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Local> Local { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Minicurso> Minicurso { get; set; }
        public DbSet<Palestra> Palestra { get; set; }
        public DbSet<Participacao> Participacao { get; set; }
        public DbSet<Participante> Participante { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Visita> Visita { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<TrabalhoVoluntario> TrabalhoVoluntario { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Oficina> Oficina { get; set; }
    }
}
