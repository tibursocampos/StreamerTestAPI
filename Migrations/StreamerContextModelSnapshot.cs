﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SS_API.Data;

namespace SS_API.Migrations
{
    [DbContext(typeof(StreamerContext))]
    partial class StreamerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("SS_API.Model.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Angular"
                        },
                        new
                        {
                            Id = 2,
                            Name = "React"
                        },
                        new
                        {
                            Id = 3,
                            Name = "DotNet"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Java"
                        });
                });

            modelBuilder.Entity("SS_API.Model.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("ProjectStatus");

                    b.Property<string>("What");

                    b.Property<string>("WhatWillWeDo");

                    b.Property<string>("Why");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("SS_API.Model.Project", b =>
                {
                    b.HasOne("SS_API.Model.Course", "Course")
                        .WithMany("Projects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
