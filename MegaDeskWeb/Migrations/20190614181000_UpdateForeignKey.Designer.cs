﻿// <auto-generated />
using System;
using MegaDeskWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskWeb.Migrations
{
    [DbContext(typeof(MegaDeskWebContext))]
    [Migration("20190614181000_UpdateForeignKey")]
    partial class UpdateForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDeskWeb.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeliveryName");

                    b.Property<decimal>("From1000To2000");

                    b.Property<decimal>("GreaterThan2000");

                    b.Property<decimal>("LessThan1000");

                    b.HasKey("DeliveryId");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.Desk", b =>
                {
                    b.Property<int>("DeskId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Depth");

                    b.Property<int>("NumDrawers");

                    b.Property<int>("SurfaceMaterialId");

                    b.Property<int>("Width");

                    b.HasKey("DeskId");

                    b.HasIndex("SurfaceMaterialId");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName");

                    b.Property<int>("DeliveryId");

                    b.Property<int>("DeskId");

                    b.Property<decimal>("DeskPrice");

                    b.Property<DateTime>("QuoteDate");

                    b.HasKey("QuoteId");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("DeskId");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.SurfaceMaterial", b =>
                {
                    b.Property<int>("SurfaceMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SurfaceMaterialName");

                    b.Property<decimal>("SurfaceMaterialPrice");

                    b.HasKey("SurfaceMaterialId");

                    b.ToTable("SurfaceMaterial");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.Desk", b =>
                {
                    b.HasOne("MegaDeskWeb.Models.SurfaceMaterial", "SurfaceMaterial")
                        .WithMany("Desk")
                        .HasForeignKey("SurfaceMaterialId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MegaDeskWeb.Models.Quote", b =>
                {
                    b.HasOne("MegaDeskWeb.Models.Delivery", "Delivery")
                        .WithMany("Quote")
                        .HasForeignKey("DeliveryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MegaDeskWeb.Models.Desk", "Desk")
                        .WithMany("Quote")
                        .HasForeignKey("DeskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
