﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Projeto_Integrador.Models.Models;

public partial class DOACAO_SANGUEContext : DbContext
{
    public DOACAO_SANGUEContext(DbContextOptions<DOACAO_SANGUEContext> options)
        : base(options)
    {
    }
    public DOACAO_SANGUEContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

=> optionsBuilder.UseSqlServer("data source=NOTEBOOK-MARCOS\\SQLEXPRESS;Initial Catalog=DOACAO_SANGUE;User Id=sa;Password=2000@edu.sau;TrustserverCertificate=True");
    public virtual DbSet<CadDataHoraDisp> CadDataHoraDisp { get; set; }

    public virtual DbSet<CadDoacao> CadDoacao { get; set; }

    public virtual DbSet<CadLocalDoacao> CadLocalDoacao { get; set; }

    public virtual DbSet<FichaDoacao> FichaDoacao { get; set; }

    public virtual DbSet<StatusDoacao> StatusDoacao { get; set; }

    public virtual DbSet<TbEstados> TbEstados { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CadDataHoraDisp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAD_DATA__3214EC270A3F9E18");

            entity.ToTable("CAD_DATA_HORA_DISP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataDisp)
                .HasColumnType("datetime")
                .HasColumnName("DATA_DISP");
            entity.Property(e => e.Disp).HasColumnName("DISP");
            entity.Property(e => e.IdLocal).HasColumnName("ID_LOCAL");
        });

        modelBuilder.Entity<CadDoacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAD_DOAC__3214EC27087CD3B9");

            entity.ToTable("CAD_DOACAO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdData).HasColumnName("ID_DATA");
            entity.Property(e => e.IdFichaUsuario)
                .IsRequired()
                .HasMaxLength(450)
                .HasColumnName("ID_FICHA_USUARIO");
            entity.Property(e => e.IdLocal).HasColumnName("ID_LOCAL");
            entity.Property(e => e.IdStatus).HasColumnName("ID_STATUS");
        });

        modelBuilder.Entity<CadLocalDoacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAD_LOCA__3214EC27E27A522C");

            entity.ToTable("CAD_LOCAL_DOACAO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ativo).HasColumnName("ATIVO");
            entity.Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BAIRRO");
            entity.Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CEP");
            entity.Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CIDADE");
            entity.Property(e => e.Complemento)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMPLEMENTO");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LOGRADOURO");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOME");
            entity.Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NUMERO");
            entity.Property(e => e.Telefone)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TELEFONE");
        });

        modelBuilder.Entity<FichaDoacao>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__FICHA_DO__3214EC277B4D4718");

            entity.ToTable("FICHA_DOACAO");

            entity.HasIndex(e => e.IdUser, "IX_FICHA_DOACAO").IsUnique();

            entity.Property(e => e.IdUser).HasColumnName("ID_User");
            entity.Property(e => e.Bairro)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BAIRRO");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CEP");
            entity.Property(e => e.Cidade)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CIDADE");
            entity.Property(e => e.Complemento)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMPLEMENTO");
            entity.Property(e => e.Cpf)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CPF");
            entity.Property(e => e.DataNasc)
                .HasColumnType("datetime")
                .HasColumnName("DATA_NASC");
            entity.Property(e => e.Fumante).HasColumnName("FUMANTE");
            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.Logradouro)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LOGRADOURO");
            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOME");
            entity.Property(e => e.NomeMae)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOME_MAE");
            entity.Property(e => e.NomePai)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOME_PAI");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NUMERO");
            entity.Property(e => e.OrgExp)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORG_EXP");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PESO");
            entity.Property(e => e.Profissao)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PROFISSAO");
            entity.Property(e => e.Religiao)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RELIGIAO");
            entity.Property(e => e.Rg)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RG");
            entity.Property(e => e.Sexo).HasColumnName("SEXO");
            entity.Property(e => e.Telefone)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEFONE");
            entity.Property(e => e.TempFumante).HasColumnName("TEMP_FUMANTE");
            entity.Property(e => e.TipoSangue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TIPO_SANGUE");
            entity.Property(e => e.UltimaDoacao)
                .HasColumnType("datetime")
                .HasColumnName("ULTIMA_DOACAO");
        });

        modelBuilder.Entity<StatusDoacao>(entity =>
        {
            entity.ToTable("STATUS_DOACAO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRICAO");
        });

        modelBuilder.Entity<TbEstados>(entity =>
        {
            entity.ToTable("tb_estados");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NmEstado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_ESTADO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}