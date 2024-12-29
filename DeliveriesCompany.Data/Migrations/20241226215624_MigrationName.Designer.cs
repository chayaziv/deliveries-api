﻿// <auto-generated />
using System;
using DeliveriesCompany.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeliveriesCompany.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241226215624_MigrationName")]
    partial class MigrationName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DeliveriesCompany.Core.Entity.Agreement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Distribution")
                        .HasColumnType("int");

                    b.Property<int>("MinCountPackage")
                        .HasColumnType("int");

                    b.Property<double>("PricePerPackage")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Agreement");
                });

            modelBuilder.Entity("DeliveriesCompany.Core.Entity.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressOfWarehouse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AgreementId")
                        .HasColumnType("int");

                    b.Property<string>("ContactPersonMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersonPhon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartAgreementDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("DeliveriesCompany.Core.Entity.DeliveryMan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Bonus")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreferedArea")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("Vehicle")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMan");
                });

            modelBuilder.Entity("DeliveriesCompany.Core.Entity.Sending", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Breakable")
                        .HasColumnType("bit");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<bool>("CraneNeed")
                        .HasColumnType("bit");

                    b.Property<int>("DeliveryManId")
                        .HasColumnType("int");

                    b.Property<string>("DestinationAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DestinationFloor")
                        .HasColumnType("int");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("Refrigeration")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Urgency")
                        .HasColumnType("int");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Sending");
                });
#pragma warning restore 612, 618
        }
    }
}
