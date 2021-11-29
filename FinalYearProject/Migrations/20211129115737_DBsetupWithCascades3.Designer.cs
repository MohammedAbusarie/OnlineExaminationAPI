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
    [DbContext(typeof(testdbContext))]
    [Migration("20211129115737_DBsetupWithCascades3")]
    partial class DBsetupWithCascades3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalYearProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreditHrs")
                        .HasColumnType("int")
                        .HasColumnName("credit_hrs");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("name");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int")
                        .HasColumnName("professor_id");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int")
                        .HasColumnName("schedule_id");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("FinalYearProject.Models.Enrollment", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_id");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("student_id");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("grade");

                    b.Property<int>("TotalMarks")
                        .HasColumnType("int")
                        .HasColumnName("totalMarks");

                    b.HasKey("CourseId", "StudentId");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("FinalYearProject.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("course_id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("Duration")
                        .HasColumnType("int")
                        .HasColumnName("duration");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("FinalYearProject.Models.ExamQuestion", b =>
                {
                    b.Property<int?>("ExamId")
                        .HasColumnType("int")
                        .HasColumnName("exam_id");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("question_id");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ExamId", "QuestionId")
                        .HasName("PK_ExamQuestions_1");

                    b.HasIndex("QuestionId");

                    b.HasIndex(new[] { "Id" }, "unique_eqa_id")
                        .IsUnique();

                    b.ToTable("ExamQuestions");
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

                    b.Property<string>("Answer")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer");

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_id");

                    b.Property<string>("Goal")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("goal");

                    b.Property<string>("Hint")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("hint");

                    b.Property<string>("Question1")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("question");

                    b.Property<bool>("Type")
                        .HasColumnType("bit")
                        .HasColumnName("type");

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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("name");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime")
                        .HasColumnName("time");

                    b.HasKey("Id");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("FinalYearProject.Models.StudentAnswer", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("student_id");

                    b.Property<int>("ExamQuestionsId")
                        .HasColumnType("int")
                        .HasColumnName("exam_questions_id");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("answer");

                    b.HasKey("StudentId", "ExamQuestionsId");

                    b.HasIndex("ExamQuestionsId");

                    b.ToTable("StudentAnswer");
                });

            modelBuilder.Entity("FinalYearProject.Models.Course", b =>
                {
                    b.HasOne("FinalYearProject.Models.Schedule", "Schedule")
                        .WithMany("Courses")
                        .HasForeignKey("ScheduleId")
                        .HasConstraintName("FK_Course_Schedule")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("FinalYearProject.Models.Enrollment", b =>
                {
                    b.HasOne("FinalYearProject.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Enrollment_Course")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("FinalYearProject.Models.Exam", b =>
                {
                    b.HasOne("FinalYearProject.Models.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Exam_Course")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("FinalYearProject.Models.ExamQuestion", b =>
                {
                    b.HasOne("FinalYearProject.Models.Exam", "Exam")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamId")
                        .HasConstraintName("FK_ExamQuestions_Exam")
                        .IsRequired();

                    b.HasOne("FinalYearProject.Models.Question", "Question")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FK_ExamQuestions_Question")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Question");
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

            modelBuilder.Entity("FinalYearProject.Models.StudentAnswer", b =>
                {
                    b.HasOne("FinalYearProject.Models.ExamQuestion", "ExamQuestions")
                        .WithMany("StudentAnswers")
                        .HasForeignKey("ExamQuestionsId")
                        .HasConstraintName("FK_StudentAnswer_ExamQuestions")
                        .HasPrincipalKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExamQuestions");
                });

            modelBuilder.Entity("FinalYearProject.Models.Course", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("Exams");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("FinalYearProject.Models.Exam", b =>
                {
                    b.Navigation("ExamQuestions");
                });

            modelBuilder.Entity("FinalYearProject.Models.ExamQuestion", b =>
                {
                    b.Navigation("StudentAnswers");
                });

            modelBuilder.Entity("FinalYearProject.Models.Question", b =>
                {
                    b.Navigation("ExamQuestions");
                });

            modelBuilder.Entity("FinalYearProject.Models.Schedule", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
