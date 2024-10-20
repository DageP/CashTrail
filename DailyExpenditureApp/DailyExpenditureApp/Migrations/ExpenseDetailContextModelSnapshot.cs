﻿// <auto-generated />
using System;
using DailyExpenditureApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DailyExpenditureApp.Migrations
{
    [DbContext(typeof(ExpenseDetailContext))]
    partial class ExpenseDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DailyExpenditureApp.Models.ExpenseModel", b =>
                {
                    b.Property<Guid>("ExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateOnly>("DateOfPurchase")
                        .HasColumnType("date");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.Property<short>("UserID")
                        .HasColumnType("smallint");

                    b.HasKey("ExpenseID");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("DailyExpenditureApp.Models.LocationModel", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationID"));

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DailyExpenditureApp.Models.UserModel", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateOnly>("DoB")
                        .HasColumnType("date");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("profilePicture")
                        .IsRequired()
                        .HasColumnType("varbinary(8000)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
