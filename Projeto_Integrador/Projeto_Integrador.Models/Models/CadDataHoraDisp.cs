﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Projeto_Integrador.Models.Models;

public partial class CadDataHoraDisp
{
    public int Id { get; set; }

    public int IdLocal { get; set; }

    public DateTime Date { get; set; }

    public int Disp { get; set; }

    public virtual CadLocalDoacao IdLocalNavigation { get; set; }
}