﻿// <auto-generated />
using DbRelationMockPractice.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DbRelationMockPractice.Migrations
{
    [DbContext(typeof(PracticeContext))]
    partial class PracticeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("DbRelationMockPractice.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Street");

                    b.Property<int>("StudentId");

                    b.Property<int>("Zipcode");

                    b.HasKey("AddressId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DbRelationMockPractice.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GradeAnimal");

                    b.Property<string>("GrandeName");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("DbRelationMockPractice.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GradeId");

                    b.Property<string>("StudentName");

                    b.HasKey("StudentId");

                    b.HasIndex("GradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DbRelationMockPractice.Models.Address", b =>
                {
                    b.HasOne("DbRelationMockPractice.Models.Student", "Student")
                        .WithOne("Address")
                        .HasForeignKey("DbRelationMockPractice.Models.Address", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DbRelationMockPractice.Models.Student", b =>
                {
                    b.HasOne("DbRelationMockPractice.Models.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId");
                });
#pragma warning restore 612, 618
        }
    }
}
