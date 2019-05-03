﻿// <auto-generated />
using System;
using Clinic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clinic.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190503152123_ModelsUpdate")]
    partial class ModelsUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clinic.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasMaxLength(50);

                    b.Property<DateTime>("exp_pass");

                    b.Property<string>("fname")
                        .HasMaxLength(50);

                    b.Property<string>("lname")
                        .HasMaxLength(50);

                    b.Property<string>("mname")
                        .HasMaxLength(50);

                    b.Property<string>("mobile")
                        .HasMaxLength(15);

                    b.Property<string>("pass")
                        .HasMaxLength(300);

                    b.Property<string>("phone")
                        .HasMaxLength(15);

                    b.Property<string>("rand_pass")
                        .HasMaxLength(100);

                    b.Property<string>("username")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("Clinic.Models.Assistant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("display_name")
                        .HasMaxLength(100);

                    b.Property<string>("email")
                        .HasMaxLength(50);

                    b.Property<string>("fname")
                        .HasMaxLength(50);

                    b.Property<string>("lname")
                        .HasMaxLength(50);

                    b.Property<string>("mname")
                        .HasMaxLength(50);

                    b.Property<string>("pass")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("phone")
                        .HasMaxLength(15);

                    b.Property<int>("ref_doctor");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ref_doctor");

                    b.ToTable("assistants");
                });

            modelBuilder.Entity("Clinic.Models.Consultation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("blood_presure")
                        .HasMaxLength(5);

                    b.Property<string>("cost")
                        .HasMaxLength(10);

                    b.Property<DateTime>("date");

                    b.Property<string>("diagnostics");

                    b.Property<int>("doctor_id");

                    b.Property<string>("insurance_conf")
                        .HasMaxLength(10);

                    b.Property<int>("patient_id");

                    b.Property<string>("symptoms");

                    b.Property<string>("temp")
                        .HasMaxLength(5);

                    b.Property<string>("title")
                        .HasMaxLength(100);

                    b.Property<string>("treatment");

                    b.Property<string>("type")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("doctor_id");

                    b.HasIndex("patient_id");

                    b.ToTable("consultations");
                });

            modelBuilder.Entity("Clinic.Models.Dates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("alpha")
                        .HasMaxLength(20);

                    b.Property<DateTime>("date");

                    b.Property<int?>("doctorId");

                    b.Property<string>("name")
                        .HasMaxLength(100);

                    b.Property<int>("patient_id");

                    b.Property<DateTime>("time");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patient_id");

                    b.ToTable("dates");
                });

            modelBuilder.Entity("Clinic.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("about");

                    b.Property<string>("address");

                    b.Property<string>("display_name")
                        .HasMaxLength(100);

                    b.Property<string>("email")
                        .HasMaxLength(100);

                    b.Property<string>("fname")
                        .HasMaxLength(50);

                    b.Property<string>("gender")
                        .HasMaxLength(10);

                    b.Property<string>("lname")
                        .HasMaxLength(50);

                    b.Property<string>("mname")
                        .HasMaxLength(50);

                    b.Property<string>("mobile")
                        .HasMaxLength(15);

                    b.Property<string>("pass")
                        .HasMaxLength(300);

                    b.Property<string>("phone")
                        .HasMaxLength(15);

                    b.Property<string>("speciality")
                        .HasMaxLength(100);

                    b.Property<string>("time")
                        .HasMaxLength(100);

                    b.Property<string>("username")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("Clinic.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(100);

                    b.Property<string>("email")
                        .HasMaxLength(50);

                    b.Property<string>("fax")
                        .HasMaxLength(100);

                    b.Property<string>("name")
                        .HasMaxLength(100);

                    b.Property<string>("pass")
                        .HasMaxLength(300);

                    b.Property<string>("phone")
                        .HasMaxLength(15);

                    b.Property<string>("username")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("insurances");
                });

            modelBuilder.Entity("Clinic.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("doctorId");

                    b.Property<int?>("patientId");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("lists");
                });

            modelBuilder.Entity("Clinic.Models.Messages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("message")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("Clinic.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(200);

                    b.Property<DateTime>("birthday");

                    b.Property<string>("blood_type")
                        .HasMaxLength(4);

                    b.Property<string>("display_name")
                        .HasMaxLength(100);

                    b.Property<string>("email")
                        .HasMaxLength(100);

                    b.Property<string>("fname")
                        .HasMaxLength(50);

                    b.Property<string>("gender")
                        .HasMaxLength(10);

                    b.Property<int>("insurance_id");

                    b.Property<string>("lname")
                        .HasMaxLength(50);

                    b.Property<string>("mname")
                        .HasMaxLength(50);

                    b.Property<string>("mobile")
                        .HasMaxLength(15);

                    b.Property<string>("pass")
                        .HasMaxLength(300);

                    b.Property<string>("phone")
                        .HasMaxLength(15);

                    b.Property<string>("token");

                    b.Property<string>("username")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("insurance_id");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("Clinic.Models.Reminder_admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("adminId");

                    b.Property<string>("content")
                        .HasMaxLength(300);

                    b.Property<DateTime>("date");

                    b.Property<string>("priority")
                        .HasMaxLength(10);

                    b.Property<DateTime>("time");

                    b.Property<string>("title")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("adminId");

                    b.ToTable("reminder_Admins");
                });

            modelBuilder.Entity("Clinic.Models.Reminder_assistant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("assistantId");

                    b.Property<string>("content")
                        .HasMaxLength(300);

                    b.Property<DateTime>("date");

                    b.Property<string>("priority")
                        .HasMaxLength(10);

                    b.Property<DateTime>("time");

                    b.Property<string>("title")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("assistantId");

                    b.ToTable("reminder_Assistants");
                });

            modelBuilder.Entity("Clinic.Models.Reminder_doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .HasMaxLength(300);

                    b.Property<DateTime>("date");

                    b.Property<int?>("doctorId");

                    b.Property<string>("priority")
                        .HasMaxLength(10);

                    b.Property<DateTime>("time");

                    b.Property<string>("title")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.ToTable("reminder_Doctors");
                });

            modelBuilder.Entity("Clinic.Models.Reminder_insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .HasMaxLength(300);

                    b.Property<DateTime>("date");

                    b.Property<int?>("insuranceId");

                    b.Property<string>("priority")
                        .HasMaxLength(10);

                    b.Property<DateTime>("time");

                    b.Property<string>("title")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("insuranceId");

                    b.ToTable("reminder_Insurances");
                });

            modelBuilder.Entity("Clinic.Models.Reminder_patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .HasMaxLength(300);

                    b.Property<DateTime>("date");

                    b.Property<int?>("patientId");

                    b.Property<string>("priority")
                        .HasMaxLength(10);

                    b.Property<DateTime>("time");

                    b.Property<string>("title")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("patientId");

                    b.ToTable("reminder_Patients");
                });

            modelBuilder.Entity("Clinic.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cost")
                        .HasMaxLength(10);

                    b.Property<DateTime>("date");

                    b.Property<int?>("doctorId");

                    b.Property<int?>("insuranceId");

                    b.Property<int?>("patientId");

                    b.Property<string>("title")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("insuranceId");

                    b.HasIndex("patientId");

                    b.ToTable("reports");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Clinic.Models.Assistant", b =>
                {
                    b.HasOne("Clinic.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("ref_doctor")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Clinic.Models.Consultation", b =>
                {
                    b.HasOne("Clinic.Models.Doctor", "doctor")
                        .WithMany("consultations")
                        .HasForeignKey("doctor_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinic.Models.Patient", "patient")
                        .WithMany("consultations")
                        .HasForeignKey("patient_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Clinic.Models.Dates", b =>
                {
                    b.HasOne("Clinic.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorId");

                    b.HasOne("Clinic.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("patient_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Clinic.Models.List", b =>
                {
                    b.HasOne("Clinic.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorId");

                    b.HasOne("Clinic.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("patientId");
                });

            modelBuilder.Entity("Clinic.Models.Patient", b =>
                {
                    b.HasOne("Clinic.Models.Insurance", "insurance")
                        .WithMany()
                        .HasForeignKey("insurance_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Clinic.Models.Reminder_admin", b =>
                {
                    b.HasOne("Clinic.Models.Admin", "admin")
                        .WithMany()
                        .HasForeignKey("adminId");
                });

            modelBuilder.Entity("Clinic.Models.Reminder_assistant", b =>
                {
                    b.HasOne("Clinic.Models.Assistant", "assistant")
                        .WithMany()
                        .HasForeignKey("assistantId");
                });

            modelBuilder.Entity("Clinic.Models.Reminder_doctor", b =>
                {
                    b.HasOne("Clinic.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorId");
                });

            modelBuilder.Entity("Clinic.Models.Reminder_insurance", b =>
                {
                    b.HasOne("Clinic.Models.Insurance", "insurance")
                        .WithMany()
                        .HasForeignKey("insuranceId");
                });

            modelBuilder.Entity("Clinic.Models.Reminder_patient", b =>
                {
                    b.HasOne("Clinic.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("patientId");
                });

            modelBuilder.Entity("Clinic.Models.Report", b =>
                {
                    b.HasOne("Clinic.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorId");

                    b.HasOne("Clinic.Models.Insurance", "insurance")
                        .WithMany("reports")
                        .HasForeignKey("insuranceId");

                    b.HasOne("Clinic.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("patientId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
