﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnionExample.Persistence.Context;

#nullable disable

namespace OnionExample.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnionExample.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("54f769e8-9e35-44b3-af1a-7378c2715e3d"),
                            Description = "d1",
                            Name = "p1",
                            Price = 10m,
                            Stock = 100
                        },
                        new
                        {
                            Id = new Guid("cd4a6f82-6530-47a9-b269-f9edc28fcbbc"),
                            Description = "d2",
                            Name = "p2",
                            Price = 20m,
                            Stock = 200
                        },
                        new
                        {
                            Id = new Guid("70584e0d-8788-44c3-9032-2af7002ef898"),
                            Description = "d3",
                            Name = "p3",
                            Price = 30m,
                            Stock = 300
                        },
                        new
                        {
                            Id = new Guid("1dddaca5-89ee-4a21-b023-1392cb5eceb5"),
                            Description = "d4",
                            Name = "p4",
                            Price = 40m,
                            Stock = 400
                        });
                });
#pragma warning restore 612, 618
        }
    }
}