﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Integrador.Models.Models;

public partial class FichaDoacao
{
    [Display(Name = "Cod. Usuário")]
    public string IdUser { get; set; }
    [Display(Name = "Tipo Sanguíneo")]
    public string TipoSangue { get; set; }
    [Display(Name = "Última Doação")]
    public DateTime? UltimaDoacao { get; set; }
    [Display(Name = "Peso")]
    public decimal? Peso { get; set; }
    [Display(Name = "Fumante?")]
    public int? Fumante { get; set; }
    [Display(Name = "Gênero")]
    public int? Sexo { get; set; }
    [Display(Name = "CPF")]
    public string Cpf { get; set; }
    [Display(Name = "RG")]
    public string Rg { get; set; }
    [Display(Name = "Orgão Expeditor")]
    public string OrgExp { get; set; }
    [Display(Name = "Profissão")]
    public string Profissao { get; set; }
    [Display(Name = "Religião")]
    public string Religiao { get; set; }
    [Display(Name = "Quanto tempo?")]
    public int? TempFumante { get; set; }
    [Display(Name = "Data de Nascimento")]
    public DateTime? DataNasc { get; set; }
    [Display(Name = "Nome da Mãe")]
    public string NomeMae { get; set; }
    [Display(Name = "Nome do Pai")]
    public string NomePai { get; set; }
    [Display(Name = "Logradouro")]
    public string Logradouro { get; set; }
    [Display(Name = "Número")]
    public string Numero { get; set; }
    [Display(Name = "Complemento")]
    public string Complemento { get; set; }
    [Display(Name = "CEP")]
    public string Cep { get; set; }
    [Display(Name = "Bairro")]
    public string Bairro { get; set; }
    [Display(Name = "Cidade")]
    public string Cidade { get; set; }
    [Display(Name = "Estado")]
    public int? IdEstado { get; set; }
    [Display(Name = "Nome")]
    public string Nome { get; set; }
    [Display(Name = "Telefone")]
    public string Telefone { get; set; }
}