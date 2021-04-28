﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TShop.Infrascture.DataBase.EF;

namespace TShop.Infrascture.DataBase.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("13980120040705_addproduct")]
    partial class addproduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TShop.Domain.Entities.Category", b =>
                {
                    b.Property<byte>("ID");

                    b.Property<DateTime>("InsertDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TShop.Domain.Entities.ImageFile", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("InsertDate");

                    b.Property<long>("Product_ID");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("TShop.Domain.Entities.Product", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Available");

                    b.Property<byte>("Category_ID");

                    b.Property<DateTime>("InsertDate");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<decimal>("NewPrice");

                    b.Property<decimal>("OldPrice");

                    b.Property<byte>("Rank");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("Category_ID");

                    b.HasIndex("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TShop.Domain.Entities.ProductColor", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InsertDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long>("Product_ID");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("TShop.Domain.Entities.ProductSize", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InsertDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long>("Product_ID");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("TShop.Domain.Entities.ImageFile", b =>
                {
                    b.HasOne("TShop.Domain.Entities.Product")
                        .WithMany("Images")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TShop.Domain.Entities.Product", b =>
                {
                    b.HasOne("TShop.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TShop.Domain.Entities.ProductColor", b =>
                {
                    b.HasOne("TShop.Domain.Entities.Product")
                        .WithMany("Colors")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TShop.Domain.Entities.ProductSize", b =>
                {
                    b.HasOne("TShop.Domain.Entities.Product")
                        .WithMany("Sizes")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}