﻿// <auto-generated />
using System;
using HPV_ADOLEPAC_6._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HPV_ADOLEPAC_6._0.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241014032127_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.PostTestAnswer", b =>
                {
                    b.Property<int>("PostTestAnswerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostTestAnswerID"), 1L, 1);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAttempt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PostTestQuestionID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostTestAnswerID");

                    b.HasIndex("PostTestQuestionID");

                    b.ToTable("PostTestAnswer");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.PostTestQuestions", b =>
                {
                    b.Property<int>("PostTestQuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostTestQuestionID"), 1L, 1);

                    b.Property<string>("PostTestQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTestQuestionOption1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTestQuestionOption2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTestQuestionOption3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTestQuestionOption4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTestQuestionOption5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostTestQuestionID");

                    b.ToTable("PostTestQuestions");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.PreTestAnswers", b =>
                {
                    b.Property<int>("PreTestAnswerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PreTestAnswerID"), 1L, 1);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAttempt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PreTestQuestionID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PreTestAnswerID");

                    b.HasIndex("PreTestQuestionID");

                    b.ToTable("PreTestAnswer");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.PreTestQuestions", b =>
                {
                    b.Property<int>("PreTestQuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PreTestQuestionID"), 1L, 1);

                    b.Property<string>("PreTestQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreTestQuestionOption1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreTestQuestionOption2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreTestQuestionOption3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreTestQuestionOption4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreTestQuestionOption5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PreTestQuestionID");

                    b.ToTable("PreTestQuestions");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<string>("AnnualIncome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceOwnership")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EthinicGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherEdulevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FinalGrade")
                        .HasColumnType("int");

                    b.Property<string>("FrequencySub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Grade")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("KnowledgeTestCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LearningModulesCompleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModulePercentage")
                        .HasColumnType("int");

                    b.Property<string>("MonthlyIncome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherEdulevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MyProfileCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("ParentalMaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PostTestCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("PreTestCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentAge")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("StudentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentParentPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("student");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.TestAnswers", b =>
                {
                    b.Property<int>("TestAnswerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestAnswerID"), 1L, 1);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAttempt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FinalGradeStudentID")
                        .HasColumnType("int");

                    b.Property<int?>("TestQuestionID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestAnswerID");

                    b.HasIndex("FinalGradeStudentID");

                    b.HasIndex("TestQuestionID");

                    b.ToTable("TestAnswers");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.TestQuestions", b =>
                {
                    b.Property<int>("TestQuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestQuestionID"), 1L, 1);

                    b.Property<string>("CorrectOption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestQuestionOption1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestQuestionOption2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestQuestionOption3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestQuestionOption4")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestQuestionID");

                    b.ToTable("TestQuestions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.PostTestAnswer", b =>
                {
                    b.HasOne("HPV_ADOLEPAC_6._0.Models.PostTestQuestions", "PostTestQuestions")
                        .WithMany()
                        .HasForeignKey("PostTestQuestionID");

                    b.Navigation("PostTestQuestions");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.PreTestAnswers", b =>
                {
                    b.HasOne("HPV_ADOLEPAC_6._0.Models.PreTestQuestions", "PreTestQuestions")
                        .WithMany("PreTestAnswers")
                        .HasForeignKey("PreTestQuestionID");

                    b.Navigation("PreTestQuestions");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.TestAnswers", b =>
                {
                    b.HasOne("HPV_ADOLEPAC_6._0.Models.student", "FinalGrade")
                        .WithMany("TestAnswers")
                        .HasForeignKey("FinalGradeStudentID");

                    b.HasOne("HPV_ADOLEPAC_6._0.Models.TestQuestions", "TestQuestions")
                        .WithMany("TestAnswers")
                        .HasForeignKey("TestQuestionID");

                    b.Navigation("FinalGrade");

                    b.Navigation("TestQuestions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.PreTestQuestions", b =>
                {
                    b.Navigation("PreTestAnswers");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.student", b =>
                {
                    b.Navigation("TestAnswers");
                });

            modelBuilder.Entity("HPV_ADOLEPAC_6._0.Models.TestQuestions", b =>
                {
                    b.Navigation("TestAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
