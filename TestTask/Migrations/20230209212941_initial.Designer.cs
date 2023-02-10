﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestTask.Data;

#nullable disable

namespace TestTask.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20230209212941_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestTask.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Key = "button",
                            Price = 10,
                            Value = "#FF0000"
                        },
                        new
                        {
                            Id = 2,
                            Key = "button",
                            Price = 10,
                            Value = "#00FF00"
                        },
                        new
                        {
                            Id = 3,
                            Key = "button",
                            Price = 10,
                            Value = "#FF0000"
                        },
                        new
                        {
                            Id = 4,
                            Key = "button",
                            Price = 10,
                            Value = "#FF0000"
                        },
                        new
                        {
                            Id = 5,
                            Key = "button",
                            Price = 10,
                            Value = "#0000FF"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}