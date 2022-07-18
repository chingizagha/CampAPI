﻿// <auto-generated />
using System;
using CoreCodeCamp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCodeCamp.Migrations
{
    [DbContext(typeof(CampContext))]
    [Migration("20220619103308_CampModelUpdated")]
    partial class CampModelUpdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCodeCamp.Data.Camp", b =>
                {
                    b.Property<int>("CampId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Moniker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CampId");

                    b.HasIndex("LocationId");

                    b.ToTable("Camps");

                    b.HasData(
                        new
                        {
                            CampId = 1,
                            EventDate = new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Length = 1,
                            LocationId = 1,
                            Moniker = "ATL2018",
                            Name = "Atlanta Code Camp"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Address1 = "123 Main Street",
                            CityTown = "Atlanta",
                            Country = "USA",
                            PostalCode = "12345",
                            StateProvince = "GA",
                            VenueName = "Atlanta Convention Center"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GitHub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpeakerId");

                    b.ToTable("Speakers");

                    b.HasData(
                        new
                        {
                            SpeakerId = 1,
                            BlogUrl = "http://wildermuth.com",
                            Company = "Wilder Minds LLC",
                            CompanyUrl = "http://wilderminds.com",
                            FirstName = "Shawn",
                            GitHub = "shawnwildermuth",
                            LastName = "Wildermuth",
                            Twitter = "shawnwildermuth"
                        },
                        new
                        {
                            SpeakerId = 2,
                            BlogUrl = "http://shawnandresa.com",
                            Company = "Wilder Minds LLC",
                            CompanyUrl = "http://wilderminds.com",
                            FirstName = "Resa",
                            GitHub = "resawildermuth",
                            LastName = "Wildermuth",
                            Twitter = "resawildermuth"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Talk", b =>
                {
                    b.Property<int>("TalkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abstract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CampId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("SpeakerId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TalkId");

                    b.HasIndex("CampId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("Talks");

                    b.HasData(
                        new
                        {
                            TalkId = 1,
                            Abstract = "Entity Framework from scratch in an hour. Probably cover it all",
                            CampId = 1,
                            Level = 100,
                            SpeakerId = 1,
                            Title = "Entity Framework From Scratch"
                        },
                        new
                        {
                            TalkId = 2,
                            Abstract = "Thinking of good sample data examples is tiring.",
                            CampId = 1,
                            Level = 200,
                            SpeakerId = 2,
                            Title = "Writing Sample Data Made Easy"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Camp", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Talk", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Camp", "Camp")
                        .WithMany("Talks")
                        .HasForeignKey("CampId");

                    b.HasOne("CoreCodeCamp.Data.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerId");

                    b.Navigation("Camp");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Camp", b =>
                {
                    b.Navigation("Talks");
                });
#pragma warning restore 612, 618
        }
    }
}
