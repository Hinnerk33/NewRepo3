﻿// <auto-generated />
using HochschulsportSchichtplan.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HochschulsportSchichtplan.Migrations
{
    [DbContext(typeof(HochschulsportSchichtplanContext))]
    [Migration("20190907112533_NeuC")]
    partial class NeuC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HochschulsportSchichtplan.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllDay");

                    b.Property<string>("Description");

                    b.Property<string>("End");

                    b.Property<string>("Start");

                    b.Property<string>("Title");

                    b.HasKey("EventId");

                    b.ToTable("Schicht");
                });
#pragma warning restore 612, 618
        }
    }
}
