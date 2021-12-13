﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectAPI;

#nullable disable

namespace ProjectAPI.Migrations
{
    [DbContext(typeof(APIprojectDBcontext))]
    [Migration("20211213134303_rawDataCode")]
    partial class rawDataCode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectAPI.Models.Code", b =>
                {
                    b.Property<int>("CodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeId"), 1L, 1);

                    b.Property<string>("CodeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeString")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CodeId");

                    b.ToTable("Codes");
                });

            modelBuilder.Entity("ProjectAPI.Models.Door", b =>
                {
                    b.Property<int>("DoorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoorId"), 1L, 1);

                    b.Property<string>("DoorName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("DoorId");

                    b.ToTable("Doors");
                });

            modelBuilder.Entity("ProjectAPI.Models.DoorTag", b =>
                {
                    b.Property<int>("DoorId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("DoorId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("DoorTags");
                });

            modelBuilder.Entity("ProjectAPI.Models.LogEntry", b =>
                {
                    b.Property<int>("LogEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogEntryId"), 1L, 1);

                    b.Property<int>("CodeId")
                        .HasColumnType("int");

                    b.Property<string>("CodeString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoorId")
                        .HasColumnType("int");

                    b.Property<string>("DoorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<string>("TagNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WalkedThroughDoor")
                        .HasColumnType("datetime2");

                    b.HasKey("LogEntryId");

                    b.HasIndex("CodeId");

                    b.HasIndex("DoorId");

                    b.HasIndex("TagId");

                    b.ToTable("LogEntries");
                });

            modelBuilder.Entity("ProjectAPI.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"), 1L, 1);

                    b.Property<string>("ApertmentNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("ProjectAPI.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"), 1L, 1);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("TagNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TagId");

                    b.HasIndex("PersonId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ProjectAPI.Models.DoorTag", b =>
                {
                    b.HasOne("ProjectAPI.Models.Door", "Door")
                        .WithMany("Tags")
                        .HasForeignKey("DoorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAPI.Models.Tag", "Tag")
                        .WithMany("Doors")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Door");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("ProjectAPI.Models.LogEntry", b =>
                {
                    b.HasOne("ProjectAPI.Models.Code", "Code")
                        .WithMany()
                        .HasForeignKey("CodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAPI.Models.Door", "Door")
                        .WithMany()
                        .HasForeignKey("DoorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAPI.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Code");

                    b.Navigation("Door");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("ProjectAPI.Models.Tag", b =>
                {
                    b.HasOne("ProjectAPI.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ProjectAPI.Models.Door", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("ProjectAPI.Models.Tag", b =>
                {
                    b.Navigation("Doors");
                });
#pragma warning restore 612, 618
        }
    }
}
