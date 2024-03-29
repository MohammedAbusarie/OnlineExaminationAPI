﻿// <auto-generated />
using System;
using FinalYearProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalYearProject.Migrations
{
    [DbContext(typeof(mydbcon))]
    [Migration("20220517185414_AddedIsBan")]
    partial class AddedIsBan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalYearProject.Models.ApplicationUser", b =>
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

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<bool>("Isbanned")
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

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FinalYearProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreditHrs")
                        .HasColumnType("int")
                        .HasColumnName("credit_hrs");

                    b.Property<int>("FLevel_Id")
                        .HasColumnType("int");

                    b.Property<int>("Faculty_id")
                        .HasColumnType("int");

                    b.Property<bool>("Is_open")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("FLevel_Id");

                    b.HasIndex("Faculty_id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("FinalYearProject.Models.EnrollementProfessor", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_id");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("application_user_id");

                    b.HasKey("CourseId", "ApplicationUserId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("EnrolementProfessor");
                });

            modelBuilder.Entity("FinalYearProject.Models.Enrollment", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_id");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("application_user_id");

                    b.Property<int?>("CurrentMarks")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("grade");

                    b.Property<int?>("TotalMarks")
                        .HasColumnType("int")
                        .HasColumnName("totalMarks");

                    b.Property<bool>("isExaminated")
                        .HasColumnType("bit");

                    b.HasKey("CourseId", "ApplicationUserId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("FinalYearProject.Models.ExamDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Course_id")
                        .HasColumnType("int");

                    b.Property<int>("ExamDurationInMinutes")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfEasyQuestions")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfHardQuestions")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfModQuestions")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfQuestions")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfQuestions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isQuestionBankConfigured")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Course_id")
                        .IsUnique();

                    b.ToTable("ExamDetails");
                });

            modelBuilder.Entity("FinalYearProject.Models.FLevels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Level_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FLevels");
                });

            modelBuilder.Entity("FinalYearProject.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("FinalYearProject.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer");

                    b.Property<string>("B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_id");

                    b.Property<string>("D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Diffculty");

                    b.Property<string>("Goal")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("goal");

                    b.Property<string>("Qtype")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Questionx")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("question");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("FinalYearProject.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("description");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<bool>("Is_set")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("FinalYearProject.Models.ScheduleWithCourse", b =>
                {
                    b.Property<int>("schedule_id")
                        .HasColumnType("int");

                    b.Property<int>("course_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("schedule_id", "course_id");

                    b.HasIndex("course_id");

                    b.ToTable("ScheduleWithCourse");
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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FinalYearProject.Models.ApplicationUser", b =>
                {
                    b.HasOne("FinalYearProject.Models.Faculty", "Faculties")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculties");
                });

            modelBuilder.Entity("FinalYearProject.Models.Course", b =>
                {
                    b.HasOne("FinalYearProject.Models.FLevels", "FLevels")
                        .WithMany("Courses")
                        .HasForeignKey("FLevel_Id")
                        .HasConstraintName("FK_FLevels")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalYearProject.Models.Faculty", "Faculty")
                        .WithMany("Courses")
                        .HasForeignKey("Faculty_id")
                        .HasConstraintName("FK_Faculty_iD")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("FLevels");
                });

            modelBuilder.Entity("FinalYearProject.Models.EnrollementProfessor", b =>
                {
                    b.HasOne("FinalYearProject.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("EnrollmentProfessors")
                        .HasForeignKey("ApplicationUserId")
                        .HasConstraintName("FK_Enrollment_Professor")
                        .IsRequired();

                    b.HasOne("FinalYearProject.Models.Course", "Course")
                        .WithMany("EnrolementProfessors")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Enrollment_CourseProf")
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("FinalYearProject.Models.Enrollment", b =>
                {
                    b.HasOne("FinalYearProject.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Enrollments")
                        .HasForeignKey("ApplicationUserId")
                        .HasConstraintName("FK_Enrollment_Student")
                        .IsRequired();

                    b.HasOne("FinalYearProject.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Enrollment_Course")
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("FinalYearProject.Models.ExamDetails", b =>
                {
                    b.HasOne("FinalYearProject.Models.Course", "Course")
                        .WithOne("ExamDetails")
                        .HasForeignKey("FinalYearProject.Models.ExamDetails", "Course_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("FinalYearProject.Models.Question", b =>
                {
                    b.HasOne("FinalYearProject.Models.Course", "Course")
                        .WithMany("Questions")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Question_Course")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("FinalYearProject.Models.Schedule", b =>
                {
                    b.HasOne("FinalYearProject.Models.Faculty", "Faculty")
                        .WithMany("Schedules")
                        .HasForeignKey("FacultyId")
                        .HasConstraintName("FK_Schedule_Faculty")
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("FinalYearProject.Models.ScheduleWithCourse", b =>
                {
                    b.HasOne("FinalYearProject.Models.Course", "Course")
                        .WithMany("ScheduleWithCourses")
                        .HasForeignKey("course_id")
                        .HasConstraintName("FK_SWC_Course")
                        .IsRequired();

                    b.HasOne("FinalYearProject.Models.Schedule", "Schedule")
                        .WithMany("ScheduleWithCourses")
                        .HasForeignKey("schedule_id")
                        .HasConstraintName("FK_SWC_Schedule")
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Schedule");
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
                    b.HasOne("FinalYearProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FinalYearProject.Models.ApplicationUser", null)
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

                    b.HasOne("FinalYearProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FinalYearProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalYearProject.Models.ApplicationUser", b =>
                {
                    b.Navigation("EnrollmentProfessors");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("FinalYearProject.Models.Course", b =>
                {
                    b.Navigation("EnrolementProfessors");

                    b.Navigation("Enrollments");

                    b.Navigation("ExamDetails");

                    b.Navigation("Questions");

                    b.Navigation("ScheduleWithCourses");
                });

            modelBuilder.Entity("FinalYearProject.Models.FLevels", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("FinalYearProject.Models.Faculty", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("Courses");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("FinalYearProject.Models.Schedule", b =>
                {
                    b.Navigation("ScheduleWithCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
