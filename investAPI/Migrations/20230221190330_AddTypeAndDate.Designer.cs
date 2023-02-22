﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using investAPI.Data;

#nullable disable

namespace investAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230221190330_AddTypeAndDate")]
    partial class AddTypeAndDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("investAPI.Models.Reit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("AveragePrice")
                        .HasColumnType("REAL");

                    b.Property<float>("CurrentQuote")
                        .HasColumnType("REAL");

                    b.Property<float>("Profit")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Reits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AveragePrice = 10f,
                            CurrentQuote = 15f,
                            Profit = 10f,
                            Quantity = 2,
                            Ticker = "MXRF11",
                            Total = 20f
                        },
                        new
                        {
                            Id = 2,
                            AveragePrice = 10f,
                            CurrentQuote = 15f,
                            Profit = 10f,
                            Quantity = 2,
                            Ticker = "HGLG11",
                            Total = 20f
                        });
                });

            modelBuilder.Entity("investAPI.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("AveragePrice")
                        .HasColumnType("REAL");

                    b.Property<float>("CurrentQuote")
                        .HasColumnType("REAL");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderType")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Profit")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AveragePrice = 10f,
                            CurrentQuote = 15f,
                            Date = new DateOnly(2001, 11, 10),
                            OrderType = 1,
                            Profit = 105f,
                            Quantity = 2,
                            Ticker = "CEMIG3 api",
                            Total = 20f
                        },
                        new
                        {
                            Id = 2,
                            AveragePrice = 10f,
                            CurrentQuote = 15f,
                            Date = new DateOnly(2001, 11, 10),
                            OrderType = 1,
                            Profit = 10f,
                            Quantity = 2,
                            Ticker = "WEG3",
                            Total = 20f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
