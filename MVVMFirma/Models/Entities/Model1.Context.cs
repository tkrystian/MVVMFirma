﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMFirma.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestauracjeEntities : DbContext
    {
        public RestauracjeEntities()
            : base("name=RestauracjeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dostawy> Dostawy { get; set; }
        public virtual DbSet<HistoriaZamowien> HistoriaZamowien { get; set; }
        public virtual DbSet<KategorieMenu> KategorieMenu { get; set; }
        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Opinie> Opinie { get; set; }
        public virtual DbSet<PozycjeZamowienia> PozycjeZamowienia { get; set; }
        public virtual DbSet<Pracownicy> Pracownicy { get; set; }
        public virtual DbSet<Promocje> Promocje { get; set; }
        public virtual DbSet<Restauracje> Restauracje { get; set; }
        public virtual DbSet<Rezerwacje> Rezerwacje { get; set; }
        public virtual DbSet<RolePracownikow> RolePracownikow { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zamowienia> Zamowienia { get; set; }
    }
}
