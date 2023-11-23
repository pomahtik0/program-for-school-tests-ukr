﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using program_for_school_tests_ukr.Database;

#nullable disable

namespace program_for_school_tests_ukr.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231123112520_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentMark")
                        .HasColumnType("int");

                    b.Property<int>("MaxMark")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TestId");

                    b.ToTable("Mark");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GetRandomTests")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRandomOrdered")
                        .HasColumnType("bit");

                    b.Property<string>("LeveledQuestionCount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_type")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("User_type").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Student", b =>
                {
                    b.HasBaseType("program_for_school_tests_ukr.Classes.User");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Teacher", b =>
                {
                    b.HasBaseType("program_for_school_tests_ukr.Classes.User");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Mark", b =>
                {
                    b.HasOne("program_for_school_tests_ukr.Classes.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("program_for_school_tests_ukr.Classes.Tests.Test", "Test")
                        .WithMany("Marks")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Question", b =>
                {
                    b.HasOne("program_for_school_tests_ukr.Classes.Tests.Test", null)
                        .WithMany("questions")
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Test", b =>
                {
                    b.HasOne("program_for_school_tests_ukr.Classes.Teacher", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Test", b =>
                {
                    b.Navigation("Marks");

                    b.Navigation("questions");
                });
#pragma warning restore 612, 618
        }
    }
}
