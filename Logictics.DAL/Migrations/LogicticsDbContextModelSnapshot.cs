﻿// <auto-generated />
using System;
using Logictics.DAL.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Logictics.DAL.Migrations
{
    [DbContext(typeof(LogicticsDbContext))]
    partial class LogicticsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Logictics.Entity.Models.CategoryProduct", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<double?>("CreateDate")
                        .HasColumnType("double");

                    b.Property<double?>("ModifyDate")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("Logictics.Entity.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<double?>("CreateDate")
                        .HasColumnType("double");

                    b.Property<string>("CustomerConfirmId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("ModifyDate")
                        .HasColumnType("double");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("PickupDate")
                        .HasColumnType("double");

                    b.Property<string>("RecipientAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RecipientFullName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RecipientId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RecipientPhone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SenderAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SenderFullName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SenderId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SenderPhone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Shipment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("StoreId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("StoreName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TotalWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Logictics.Entity.Models.OrderDetail", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<double?>("createDate")
                        .HasColumnType("double");

                    b.Property<string>("description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("modifyDate")
                        .HasColumnType("double");

                    b.Property<string>("orderId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("price")
                        .HasColumnType("int");

                    b.Property<string>("productCategoryId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("productCategoryName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("productCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("quality")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("weight")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Logictics.Entity.Models.Store", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<double?>("CreateDate")
                        .HasColumnType("double");

                    b.Property<double?>("ModifyDate")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("Logictics.Entity.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("CreateDate")
                        .HasColumnType("double");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double?>("ModifyDate")
                        .HasColumnType("double");

                    b.Property<string>("PassWord")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Role")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Status")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = "69bd714f-9576-45ba-b5b7-f00649be00de",
                            PassWord = "7c4a8d9ca3762af61e59520943dc26494f8941b",
                            Role = "ADMIN",
                            Status = "ACTIVE",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "69bd714f-9576-45ba-b5b7-f00649be00df",
                            CreateDate = 1.0,
                            PassWord = "7c4a8d9ca3762af61e59520943dc26494f8941b",
                            Role = "CLIENT",
                            Status = "ACTIVE",
                            UserName = "ChienClient"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
