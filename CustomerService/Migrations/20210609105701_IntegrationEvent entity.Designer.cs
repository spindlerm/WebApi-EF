﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Models;

namespace WebApi.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20210609105701_IntegrationEvent entity")]
    partial class IntegrationEvententity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("webapi.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 24,
                            FirstName = "Uncle",
                            LastName = "Bob"
                        },
                        new
                        {
                            Id = 2,
                            Age = 55,
                            FirstName = "John",
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("webapi.Models.IntegrationEvent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .HasColumnType("longtext");

                    b.Property<string>("Event")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("IntegrationEventOutbox");
                });
#pragma warning restore 612, 618
        }
    }
}
