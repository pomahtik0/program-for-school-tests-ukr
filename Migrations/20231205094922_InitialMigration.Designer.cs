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
    [Migration("20231205094922_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AnswerToQuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnswerToQuestionId")
                        .IsUnique();

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentMark")
                        .HasColumnType("int");

                    b.Property<int>("MarkOfStudentId")
                        .HasColumnType("int");

                    b.Property<int>("MaxMark")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarkOfStudentId");

                    b.HasIndex("TestId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionText")
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

                    b.Property<DateOnly>("DateOfLastRedaction")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRandomOrdered")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTrainingTest")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("TestSubject")
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

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Answer", b =>
                {
                    b.HasOne("program_for_school_tests_ukr.Classes.Tests.Question", "AnswerToQuestion")
                        .WithOne("ActualAnswer")
                        .HasForeignKey("program_for_school_tests_ukr.Classes.Tests.Answer", "AnswerToQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("program_for_school_tests_ukr.Classes.Tests.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");

                    b.Navigation("AnswerToQuestion");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Mark", b =>
                {
                    b.HasOne("program_for_school_tests_ukr.Classes.Student", "MarkOfStudent")
                        .WithMany("Marks")
                        .HasForeignKey("MarkOfStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("program_for_school_tests_ukr.Classes.Tests.Test", "Test")
                        .WithMany("Marks")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MarkOfStudent");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Question", b =>
                {
                    b.HasOne("program_for_school_tests_ukr.Classes.Tests.Test", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Test", b =>
                {
                    b.HasOne("program_for_school_tests_ukr.Classes.Teacher", "Owner")
                        .WithMany("OwnedTests")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Question", b =>
                {
                    b.Navigation("ActualAnswer");

                    b.Navigation("Answers");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Tests.Test", b =>
                {
                    b.Navigation("Marks");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Student", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("program_for_school_tests_ukr.Classes.Teacher", b =>
                {
                    b.Navigation("OwnedTests");
                });
#pragma warning restore 612, 618
        }
    }
}