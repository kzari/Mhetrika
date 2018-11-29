﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mhetrika.Infrastructure.Data;

namespace mhetrika.Infrastructure.Migrations
{
    [DbContext(typeof(MhetrikaContext))]
    [Migration("20181129172607_PhoneNumber")]
    partial class PhoneNumber
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mhetrika.core.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep");

                    b.Property<string>("City");

                    b.Property<string>("Neighbourhood");

                    b.Property<byte>("Number");

                    b.Property<string>("Street");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("DoctorId");

                    b.Property<int>("LaboratoryId");

                    b.Property<string>("Name");

                    b.Property<int>("PatientId");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("LaboratoryId");

                    b.HasIndex("PatientId");

                    b.ToTable("Exams");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Exam");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Laboratory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddresId");

                    b.Property<int?>("AddressId");

                    b.Property<string>("Cnpj");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Laboratories");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Medicament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("Id");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardioExamId");

                    b.Property<int>("QuizId");

                    b.HasKey("Id");

                    b.HasIndex("CardioExamId");

                    b.HasIndex("QuizId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExamId");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("mhetrika.core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Cardio", b =>
                {
                    b.HasBaseType("mhetrika.core.Entities.Exam");

                    b.Property<int>("Ct");

                    b.Property<int>("Hdl_c");

                    b.Property<int>("Ldl_c");

                    b.Property<int>("Pas");

                    b.Property<bool>("Smokes");

                    b.Property<bool>("Statin");

                    b.Property<bool>("Status");

                    b.ToTable("Cardio");

                    b.HasDiscriminator().HasValue("Cardio");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Doctor", b =>
                {
                    b.HasBaseType("mhetrika.core.Entities.User");

                    b.Property<string>("Crm");

                    b.Property<string>("Phone");

                    b.Property<string>("Specialty");

                    b.Property<string>("Uf");

                    b.ToTable("Doctor");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Exam", b =>
                {
                    b.HasOne("mhetrika.core.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mhetrika.core.Entities.Laboratory", "Laboratory")
                        .WithMany()
                        .HasForeignKey("LaboratoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mhetrika.core.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mhetrika.core.Entities.Laboratory", b =>
                {
                    b.HasOne("mhetrika.core.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("mhetrika.core.Entities.Patient", b =>
                {
                    b.HasOne("mhetrika.core.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mhetrika.core.Entities.Response", b =>
                {
                    b.HasOne("mhetrika.core.Entities.Cardio", "CardioExam")
                        .WithMany()
                        .HasForeignKey("CardioExamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mhetrika.core.Entities.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mhetrika.core.Entities.Result", b =>
                {
                    b.HasOne("mhetrika.core.Entities.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
