using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hyperion_Store.DB.DataProduct
{
    public partial class Electronic_storeContext : DbContext
    {
        public Electronic_storeContext()
        {
        }

        public Electronic_storeContext(DbContextOptions<Electronic_storeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Computer> Computers { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Laptop> Laptops { get; set; } = null!;
        public virtual DbSet<Monitor> Monitors { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Phone> Phones { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-GD593R9\\SQLEXPRESS;Initial Catalog=Electronic_store;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer>(entity =>
            {
                entity.Property(e => e.Computer1)
                    .HasMaxLength(1000)
                    .HasColumnName("Computer");

                entity.Property(e => e.SerialNumber).HasColumnName("Serial Number");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Computers)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Computers_Orders");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adress).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Laptop>(entity =>
            {
                entity.Property(e => e.Laptop1)
                    .HasMaxLength(1000)
                    .HasColumnName("Laptop");

                entity.Property(e => e.SerialNumber).HasColumnName("Serial Number");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Laptops)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Laptops_Orders");
            });

            modelBuilder.Entity<Monitor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Monitor1)
                    .HasMaxLength(1000)
                    .HasColumnName("Monitor");

                entity.Property(e => e.SerialNumber).HasColumnName("Serial Number");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Monitors)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Monitors_Orders");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.OrderedProduct).HasMaxLength(1000);

                entity.Property(e => e.SerialNumber).HasColumnName("Serial Number");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Orders_Customers");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.Property(e => e.Phone1)
                    .HasMaxLength(1000)
                    .HasColumnName("Phone");

                entity.Property(e => e.SerialNumber).HasColumnName("Serial number");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Phones_Orders");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
