﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using contact_app.Models;

namespace contactapp.Migrations
{
    [DbContext(typeof(ContactAppContext))]
    [Migration("20180715074423_AddApplication")]
    partial class AddApplication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("contact_app.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientID");

                    b.Property<string>("ClientName");

                    b.Property<string>("ClientUri");

                    b.Property<string>("PostLogoutRedirectUri");

                    b.Property<string>("RedirectUri");

                    b.Property<string>("Secret");

                    b.HasKey("Id");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("contact_app.Models.Contact", b =>
                {
                    b.Property<long?>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("birth");

                    b.Property<string>("email");

                    b.Property<byte>("gender");

                    b.Property<string>("message");

                    b.Property<string>("name");

                    b.Property<string>("techno");

                    b.HasKey("id");

                    b.ToTable("Contact");
                });
#pragma warning restore 612, 618
        }
    }
}
