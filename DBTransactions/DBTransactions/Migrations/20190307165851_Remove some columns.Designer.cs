﻿// <auto-generated />
using System;
using DBTransactions.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBTransactions.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190307165851_Remove some columns")]
    partial class Removesomecolumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DBTransactions.Models.Courses", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName");

                    b.Property<int>("Hours");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DBTransactions.Models.StudentCourse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID");

                    b.Property<int?>("CoursesID");

                    b.Property<int>("StrudentID");

                    b.Property<int?>("StudentsID");

                    b.HasKey("ID");

                    b.HasIndex("CoursesID");

                    b.HasIndex("StudentsID");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("DBTransactions.Models.Students", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("MobNumber");

                    b.Property<string>("StudentName");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DBTransactions.Models.StudentCourse", b =>
                {
                    b.HasOne("DBTransactions.Models.Courses")
                        .WithMany("Students")
                        .HasForeignKey("CoursesID");

                    b.HasOne("DBTransactions.Models.Students")
                        .WithMany("Courses")
                        .HasForeignKey("StudentsID");
                });
#pragma warning restore 612, 618
        }
    }
}
