﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Projeto_Integrador.Models.Models
{
    public partial class CadLocalDoacao
    {
        public CadLocalDoacao()
        {
            CadDataHoraDisp = new HashSet<CadDataHoraDisp>();
            CadDoacao = new HashSet<CadDoacao>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public bool Ativo { get; set; }

        public virtual ICollection<CadDataHoraDisp> CadDataHoraDisp { get; set; }
        public virtual ICollection<CadDoacao> CadDoacao { get; set; }
    }
}