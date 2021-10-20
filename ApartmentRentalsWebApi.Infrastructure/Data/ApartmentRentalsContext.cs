using System;
using ApartmentRentalsWebApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApartmentRentalsWebApi.Infrastructure.Data
{
    public partial class ApartmentRentalsContext : DbContext
    {
        public ApartmentRentalsContext()
        {
        }

        public ApartmentRentalsContext(DbContextOptions<ApartmentRentalsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApartmentModel> ApartmentModels { get; set; }
        public virtual DbSet<ClientModel> ClientModels { get; set; }
        public virtual DbSet<RentalContractModel> RentalContractModels { get; set; }
        public virtual DbSet<UserModel> UserModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-9LJ95CE; Database=ApartmentRentals; Trusted_Connection=True; User=sa; Password=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ApartmentModel>(entity =>
            {
                entity.ToTable("ApartmentModel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApartmentNumber)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MontlyRent).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ClientModel>(entity =>
            {
                entity.ToTable("ClientModel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Cellphone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RentalContractModel>(entity =>
            {
                entity.ToTable("RentalContractModel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdApartment).HasColumnName("Id_Apartment");

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.HasOne(d => d.IdApartmentNavigation)
                    .WithMany(p => p.RentalContractModels)
                    .HasForeignKey(d => d.IdApartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalContract_ApartmentModel");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.RentalContractModels)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalContract_ClientModel");
            });

            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.ToTable("UserModel");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
