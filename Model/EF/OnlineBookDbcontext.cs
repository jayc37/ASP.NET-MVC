namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineBookDbcontext : DbContext
    {
        public OnlineBookDbcontext()
            : base("name=OnlineBookDbcontext")
        {
        }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuType> MenuTypes { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<SystemCfig> SystemCfigs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.PromotionPrice)
                .HasPrecision(18, 0);


            modelBuilder.Entity<SanPham>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);
            modelBuilder.Entity<Slide>()
                .Property(e => e.Image)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SystemCfig>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PassWord)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);
        }
    }
}
