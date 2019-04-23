﻿// <auto-generated />
using System;
using CIDM3312_lAB11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIDM3312_lAB11.Migrations
{
    [DbContext(typeof(ProfessorDbContext))]
    partial class ProfessorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("CIDM3312_lAB11.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<string>("Description");

                    b.Property<int?>("ProfessorID");

                    b.HasKey("ID");

                    b.HasIndex("ProfessorID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("CIDM3312_lAB11.Models.Professor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("CIDM3312_lAB11.Models.Course", b =>
                {
                    b.HasOne("CIDM3312_lAB11.Models.Professor", "Professor")
                        .WithMany("Courses")
                        .HasForeignKey("ProfessorID");
                });
#pragma warning restore 612, 618
        }
    }
}
