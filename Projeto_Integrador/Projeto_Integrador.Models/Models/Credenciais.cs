﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Projeto_Integrador.Models.Models
{
    public partial class Credenciais
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public virtual CadDoador IdUsuarioNavigation { get; set; }
    }
}