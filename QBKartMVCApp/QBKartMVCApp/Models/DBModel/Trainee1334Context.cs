using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using QBKartMVCApp.Models.DBModel;

namespace QBKartMVCApp.Models
{
    public partial class Trainee1334Context : DbContext
    {
        public Trainee1334Context()
        {
        }

        public Trainee1334Context(DbContextOptions<Trainee1334Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-AB2DAJO\\SQL2016;Initial Catalog=Trainee1334;Persist Security Info=True;User ID=shijo;Password=qburst@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProdcuctName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(6, 2)");
            });
        }
    }
}
