﻿// <auto-generated />
using System;
using GHSTShipping.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GHSTShipping.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241009140313_AddShopSequenceTable")]
    partial class AddShopSequenceTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GHSTShipping.Domain.DTOs.SP_OrderCodeResult", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OrderCodeSequence")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("OrderCodeResults");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.CodeSequence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LastOrderCode")
                        .HasColumnType("int");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShopUniqueCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CodeSequence");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientOrderCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodAmount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coupon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("DeliverStationId")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryFee")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryPartner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromDistrictName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromProvinceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromWardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("InsuranceValue")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("PickShift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PickStationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequiredNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnDistrictId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnWardCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceTypeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ToAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToDistrictId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToWardCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.Property<DateTime>("private_expected_delivery_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("private_operation_partner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("private_order_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("private_sort_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("private_total_fee")
                        .HasColumnType("int");

                    b.Property<string>("private_trans_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.PartnerConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApiKey")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DeliveryPartner")
                        .HasColumnType("int");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProdEnv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SanboxEnv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("PartnerConfig");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.Shop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AllowPublishOrder")
                        .HasColumnType("bit");

                    b.Property<decimal>("AvgMonthlyYield")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BankAccountHolder")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("BankAccountNumber")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("BankAddress")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("BankName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniqueCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.ShopOrderCodeSequence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SequenceName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ShopOrderCodeSequence");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.ShopPricePlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Capacity")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("OfficialPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrivatePrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Supplier")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopPricePlan");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.Order", b =>
                {
                    b.HasOne("GHSTShipping.Domain.Entities.Shop", "Shop")
                        .WithMany("Orders")
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("GHSTShipping.Domain.Entities.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.ShopPricePlan", b =>
                {
                    b.HasOne("GHSTShipping.Domain.Entities.Shop", "Shop")
                        .WithMany("ShopPricePlanes")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("GHSTShipping.Domain.Entities.Shop", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ShopPricePlanes");
                });
#pragma warning restore 612, 618
        }
    }
}
