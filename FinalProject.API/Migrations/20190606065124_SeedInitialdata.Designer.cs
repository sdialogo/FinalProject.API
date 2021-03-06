﻿// <auto-generated />
using System;
using FinalProject.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FinalProject.API.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    [Migration("20190606065124_SeedInitialdata")]
    partial class SeedInitialdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FinalProject.API.Entities.DevPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("DueDate");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("StatusCode")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("DevPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "react-auth0-authentication-security",
                            DueDate = new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1,
                            StatusCode = "Completed",
                            Title = "Securing React Apps with Auth0"
                        },
                        new
                        {
                            Id = 2,
                            Description = "react-big-picture",
                            DueDate = new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 2,
                            StatusCode = "In Progress",
                            Title = "React: The Big Picture"
                        },
                        new
                        {
                            Id = 3,
                            Description = "react-creating-reusable-components",
                            DueDate = new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 3,
                            StatusCode = "Not Started",
                            Title = "Creating Reusable React Components"
                        },
                        new
                        {
                            Id = 4,
                            Description = "javascript-development-environment",
                            DueDate = new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 4,
                            StatusCode = "Not Started",
                            Title = "Building a JavaScript Development Environment"
                        },
                        new
                        {
                            Id = 5,
                            Description = "react-redux-react-router-es6",
                            DueDate = new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 3,
                            StatusCode = "Not Started",
                            Title = "Building Applications with React and Redux"
                        },
                        new
                        {
                            Id = 6,
                            Description = "react-flux-building-applications",
                            DueDate = new DateTime(2019, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 4,
                            StatusCode = "Not Started",
                            Title = "Building Applications in React and Flux"
                        });
                });

            modelBuilder.Entity("FinalProject.API.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Archived");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MiddleName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Archived = false,
                            FirstName = "Sandra",
                            FullName = "Sandra Surita Dialogo",
                            HireDate = new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Dialogo",
                            MiddleName = "Surita"
                        },
                        new
                        {
                            Id = 2,
                            Archived = false,
                            FirstName = "Patrixia",
                            FullName = "Patrixia Bearis Tingson",
                            HireDate = new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Tingson",
                            MiddleName = "Bearis"
                        },
                        new
                        {
                            Id = 3,
                            Archived = false,
                            FirstName = "Isaiah",
                            FullName = "Isaiah Valentin Leonardo",
                            HireDate = new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Leonardo",
                            MiddleName = "Valentin"
                        },
                        new
                        {
                            Id = 4,
                            Archived = false,
                            FirstName = "Danica",
                            FullName = "Danica Surita Dialogo",
                            HireDate = new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Dialogo",
                            MiddleName = "Surita"
                        });
                });

            modelBuilder.Entity("FinalProject.API.Entities.DevPlan", b =>
                {
                    b.HasOne("FinalProject.API.Entities.Employee", "Employee")
                        .WithMany("DevPlans")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
