namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopModel : DbContext
    {
        public ShopModel()
            : base("name=ShopModel")
        {
        }

        public virtual DbSet<Clockface> Clockface { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Glass> Glass { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Style> Style { get; set; }
        public virtual DbSet<Watch> Watch { get; set; }
        public virtual DbSet<Wtype> Wtype { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(e => e.Watch)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.country_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Glass>()
                .HasMany(e => e.Watch)
                .WithOptional(e => e.Glass)
                .HasForeignKey(e => e.glass_id);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Watch)
                .WithRequired(e => e.Manufacturer)
                .HasForeignKey(e => e.manuf_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Material>()
                .HasMany(e => e.Watch)
                .WithOptional(e => e.Material)
                .HasForeignKey(e => e.material_id);

            modelBuilder.Entity<Style>()
                .HasMany(e => e.Watch)
                .WithOptional(e => e.Style)
                .HasForeignKey(e => e.style_id);

            modelBuilder.Entity<Wtype>()
                .HasMany(e => e.Watch)
                .WithOptional(e => e.Wtype)
                .HasForeignKey(e => e.wtype_id);
        }
    }
}
