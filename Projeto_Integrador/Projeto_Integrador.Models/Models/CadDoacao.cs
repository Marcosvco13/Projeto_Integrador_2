﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Projeto_Integrador.Models.Models
{
    public partial class CadDoacao
    {
        public int Id { get; set; }
        public int IdFichaUsuario { get; set; }
        public int IdLocal { get; set; }
        public DateTime DataHora { get; set; }
        public int Status { get; set; }

        public virtual FichaDoacao IdFichaUsuarioNavigation { get; set; }
        public virtual CadLocalDoacao IdLocalNavigation { get; set; }
    }
}