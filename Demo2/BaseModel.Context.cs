﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DEMO4Entities : DbContext
    {
        private static DEMO4Entities _context;

        public DEMO4Entities()
            : base("name=DEMO4Entities")
        {
        }

        public static DEMO4Entities GetContext()
        {
            if(_context == null ) _context = new DEMO4Entities();

            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Активности> Активности { get; set; }
        public virtual DbSet<Город> Город { get; set; }
        public virtual DbSet<Жюри> Жюри { get; set; }
        public virtual DbSet<Мероприятия> Мероприятия { get; set; }
        public virtual DbSet<Модераторы> Модераторы { get; set; }
        public virtual DbSet<Неодобренные_заявки> Неодобренные_заявки { get; set; }
        public virtual DbSet<Одобренные_заявки> Одобренные_заявки { get; set; }
        public virtual DbSet<Организаторы> Организаторы { get; set; }
        public virtual DbSet<Роли> Роли { get; set; }
        public virtual DbSet<Страны> Страны { get; set; }
        public virtual DbSet<Участники> Участники { get; set; }
    }
}
