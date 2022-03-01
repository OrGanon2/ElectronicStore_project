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
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-GD593R9\\SQLEXPRESS;Initial Catalog=Electronic_store2;Integrated Security=True");
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
            #region Computer
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 1, SerialNumber = 500,Computer1 = "Hp Desktop  Omen GT13-1112nj,Nvidia GeForce RTX 3090,1TB SSD + 1TB SSD HyperX,i9-11900K,64GB(Win10)", OrderId = null, Price = 11989 });
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 2, SerialNumber = 501,Computer1 = " Pavilion Desktop TP01-2200nj, Nvidia GeForce GTX 1650,512GB SSD ,i5-11400F, 16GB,(Win10)", OrderId = null, Price = 3799 });
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 3, SerialNumber = 502,Computer1= "Desktop Inspiron N3891-5380,  NVIDIA GeForce GTX 1650 SUPER,  256GB SSD + 1TB, i5-10400, 8GB(Win10)", OrderId = null, Price = 3999 });
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 4, SerialNumber = 503,Computer1 = "Desktop Inspiron 3670 ,NVIDIA GeForce GT710, 128GB SSD + 1TB ,i3-8100, 4GB(Win10)", OrderId = null, Price = 2299 });
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 5, SerialNumber = 504,Computer1 = "Legion T5 26AMR5 90RC017GYS ,NVIDIA GeForce RTX 3060.1TB + 512GB SSD,AMD Ryzen 7 3700X,16GB(win10)" ,OrderId = null, Price = 7699 });
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 6, SerialNumber = 505,Computer1 = "IdeaCentre 510-15ICB 90HU004UYS,Intel UHD Graphics 630,256GB SSD,i3-8100,4GB,(win10)", OrderId = null, Price = 2399 });
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 7, SerialNumber = 506,Computer1= "Ultra Mini Cubi N,Intel UHD Graphics,64GB SSD, 4GB , (win10)", OrderId = null, Price = 1239 });
            #endregion

            #region Laptop
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 1, SerialNumber = 600, Laptop1 = "Omen 17-ck0000nj, RTX 3080, 1TB SSD,Intel® Core™I-911900,32GB,(win10)", OrderId = null, Price = 11939 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 2, SerialNumber = 601, Laptop1 = "Pavilion x360 14-dy0006nj, intel Iris Xᵉ Graphics ,256G SSD,,Intel® Core™i5-1135G7 Processor,8GB,(win10)", OrderId = null, Price = 3729 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 3, SerialNumber = 602, Laptop1 = " Pavilion x360 14-dy0010nj,intel Iris Xᵉ Graphics ,512 SSD,,Intel® Core™i7-1135G7 Processor,8GB,(win10) ", OrderId = null, Price = 3969 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 4, SerialNumber = 603, Laptop1 = " Pavilion 13-bb0008nj,Iris Xᵉ Graphics,256G SSD,intel® Core™ i7-1135G7 Processor,16GB,(win10) ", OrderId = null, Price = 3919 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 5, SerialNumber = 604, Laptop1 = "Pavilion Gaming 15-dk2002nj,  Nvidia GeForceRTX 3050,512G SSD,, intel® Core™ i7-11370G7,16GB,(win10) ", OrderId = null, Price = 9679 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 6, SerialNumber = 605, Laptop1 = " HP Laptop 15-dw3308nj,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,16GB,(win10) ", OrderId = null, Price = 3249 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 7, SerialNumber = 606, Laptop1 = "Dell Inspiron 14-5410 N5410-7748 360 ,Iris Xᵉ Graphics,512G SSD,intel® Core™ i7-1135G7 Processor,8GB,(win10) ", OrderId = null, Price = 3999 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 8, SerialNumber = 607, Laptop1 = "Dell Inspiron 14-5410 N5410-5514 360, Nvidia GeForce MX350,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", OrderId = null, Price = 3499 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 9, SerialNumber = 608, Laptop1 = "Inspiron 14-5410 N5410-5423 360, ,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", OrderId = null, Price = 3699 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 10, SerialNumber = 609, Laptop1 = "Vostro 15-3500 VM-RD09-12481, Intel UHD Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", OrderId = null, Price = 3439 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 11, SerialNumber = 610, Laptop1 = "Vostro 14-5402 VM-RD09-13057,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", OrderId = null, Price = 3649 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 12, SerialNumber = 611, Laptop1 = " Asus Laptop X515EA-BQ1206W , Intel UHD Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", OrderId = null, Price = 3499 });
            modelBuilder.Entity<Laptop>().HasData(new Laptop { Id = 13, SerialNumber = 612, Laptop1 = "Zenbook Flip 13 UX363EA-HP555W,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", OrderId = null, Price = 4199 });
            #endregion

            #region Monitor
            modelBuilder.Entity<Monitor>().HasData(new Monitor { Id = 1, SerialNumber = 300, Monitor1 = "SamSung,24 U2422HE 23.8 FHD 1920x1080, m8, USB-C, InternetConnection ", OrderId = null, Price = 1759 });
            modelBuilder.Entity<Monitor>().HasData(new Monitor { Id = 2, SerialNumber = 301, Monitor1 = "Samsung, 31.5 S32A604NWM ,2560x1440 2K VA, DP,HDMI,USB ", OrderId = null, Price = 2299 });
            modelBuilder.Entity<Monitor>().HasData(new Monitor { Id = 3, SerialNumber = 302, Monitor1 = "Samsung, 27 S27A804UJM,UDK 4k 3840x2160 ,165Hz ,HDMIx2, DP ", OrderId = null, Price = 1119 });
            modelBuilder.Entity<Monitor>().HasData(new Monitor { Id = 4, SerialNumber = 303, Monitor1 = "Dell 24 E2422H ,1920x1080FHD,60Hz,VGA,DP", OrderId = null, Price = 899 });
            modelBuilder.Entity<Monitor>().HasData(new Monitor { Id = 5, SerialNumber = 304, Monitor1 = "Dell S2421HS 23.8,FHD 1920x1080,DP,HDMI ", OrderId = null, Price = 979 });
            modelBuilder.Entity<Monitor>().HasData(new Monitor { Id = 6, SerialNumber = 305, Monitor1 = "MSI 23.6 OPTIX G24C4 ,144Hz 1920x1080 FHD, AMDfreeSync, HDMIx2,DP", OrderId = null, Price = 999 });
            modelBuilder.Entity<Monitor>().HasData(new Monitor { Id = 7, SerialNumber = 306, Monitor1 = "MSI  Optix MAG301CR2 , 200Hz, 2560x1080,HDMIx2,DP,USB-C ", OrderId = null, Price = 1999 });
            modelBuilder.Entity<Monitor>().HasData(new Monitor { Id = 8, SerialNumber = 307, Monitor1 = "LG 27 LED 27GP750-B, 240Hz,1920x1080FHD-ULTRA CompGsync ,HDMIx2 DP ,mini jack 3.5", OrderId = null, Price = 1790 });

            #endregion

            #region Phone
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 1, SerialNumber = 400, Phone1 = "IPhone 13 128G Silver", OrderId = null, Price = 3599 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 2, SerialNumber = 401, Phone1 = "IPhone 13 128 Black", OrderId = null, Price = 3599 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 3, SerialNumber = 402, Phone1 = "IPhone 13 256G Black", OrderId = null, Price = 3999 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 4, SerialNumber = 403, Phone1 = "Iphone 13 256G Green", OrderId = null, Price = 3999 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 5, SerialNumber = 404, Phone1 = "Galaxy S21 128G Black", OrderId = null, Price = 2959 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 6, SerialNumber = 405, Phone1 = "Galaxy S21 128G Blue", OrderId = null, Price = 2959 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 7, SerialNumber = 406, Phone1 = "Galaxy 21 Plus 128G black", OrderId = null, Price = 3719 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 8, SerialNumber = 407, Phone1 = "Galaxy 21 Plus 128G Blue", OrderId = null, Price = 3719 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 9, SerialNumber = 408, Phone1 = "Galaxy 21 Ultra 256G Black", OrderId = null, Price = 4719 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 10, SerialNumber = 409, Phone1 = "Galaxy 21 Ultra 256G Blue", OrderId = null, Price = 4719 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 11, SerialNumber = 410, Phone1 = "Realme 7 128G 4G Purple", OrderId = null, Price = 1299 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 12, SerialNumber = 411, Phone1 = "Realme 7 128G 4G Blue", OrderId = null, Price = 1299 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 13, SerialNumber = 412, Phone1 = "Realme 7 Pro 128G 5G Black", OrderId = null, Price = 1599 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 14, SerialNumber = 413, Phone1 = "Realme 7 Pro 128G 5G Green", OrderId = null, Price = 1599 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 15, SerialNumber = 414, Phone1 = "Realme X50 256G 5G Silver", OrderId = null, Price = 2299 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 16, SerialNumber = 415, Phone1 = "RogPhone 5 256G  8GB(ram)White", OrderId = null, Price = 3999 });
            modelBuilder.Entity<Phone>().HasData(new Phone { Id = 17, SerialNumber = 416, Phone1 = "RogPhone 5s 256G 16GB(ram) Black", OrderId = null, Price = 4499 });




            #endregion





            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
