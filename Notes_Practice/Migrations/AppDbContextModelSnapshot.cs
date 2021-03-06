﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Notes_Practice.Models;

namespace Notes_Practice.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Notes_Practice.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Work Stuff a lot todo's",
                            DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Stuff To do"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Chill Mode is On.",
                            DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Vacation in Bahamas"
                        });
                });

            modelBuilder.Entity("Notes_Practice.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TagName = "Personal"
                        },
                        new
                        {
                            Id = 2,
                            TagName = "Work"
                        },
                        new
                        {
                            Id = 3,
                            TagName = "Vacation"
                        });
                });

            modelBuilder.Entity("Notes_Practice.Models.TaggedNote", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("NoteId")
                        .HasColumnType("int");

                    b.HasKey("TagId", "NoteId");

                    b.HasIndex("NoteId");

                    b.ToTable("TaggedNotes");

                    b.HasData(
                        new
                        {
                            TagId = 2,
                            NoteId = 1
                        },
                        new
                        {
                            TagId = 1,
                            NoteId = 2
                        },
                        new
                        {
                            TagId = 3,
                            NoteId = 2
                        });
                });

            modelBuilder.Entity("Notes_Practice.Models.TaggedNote", b =>
                {
                    b.HasOne("Notes_Practice.Models.Note", "Note")
                        .WithMany("TaggedNotes")
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Notes_Practice.Models.Tag", "Tag")
                        .WithMany("TaggedNotes")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
