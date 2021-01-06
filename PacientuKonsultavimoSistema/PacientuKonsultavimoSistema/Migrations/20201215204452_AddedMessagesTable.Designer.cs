﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PacientuKonsultavimoSistema.Models;

namespace PacientuKonsultavimoSistema.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201215204452_AddedMessagesTable")]
    partial class AddedMessagesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GydytojasPacientas", b =>
                {
                    b.Property<string>("GydytojaiasmKodas")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PacientaiasmKodas")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GydytojaiasmKodas", "PacientaiasmKodas");

                    b.HasIndex("PacientaiasmKodas");

                    b.ToTable("GydytojasPacientas");
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
                        .UseIdentityColumn();

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
                        .UseIdentityColumn();

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

            modelBuilder.Entity("PacientuKonsultavimoSistema.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LivingPlace")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PacientuKonsultavimoSistema.Models.Gydytojas", b =>
                {
                    b.Property<string>("asmKodas")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ePastas")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("istaiga")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("lytis")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("metai")
                        .HasColumnType("datetime2");

                    b.Property<string>("pavarde")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("salis")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("specialybe")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("telNr")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("vardas")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("asmKodas");

                    b.ToTable("Gydytojai");
                });

            modelBuilder.Entity("PacientuKonsultavimoSistema.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("PacientuKonsultavimoSistema.Models.Pacientas", b =>
                {
                    b.Property<string>("asmKodas")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ePastas")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("gyvenviete")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("lytis")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("metai")
                        .HasColumnType("datetime2");

                    b.Property<string>("pavarde")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("salis")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("telNr")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("vardas")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("asmKodas");

                    b.ToTable("Pacientai");
                });

            modelBuilder.Entity("GydytojasPacientas", b =>
                {
                    b.HasOne("PacientuKonsultavimoSistema.Models.Gydytojas", null)
                        .WithMany()
                        .HasForeignKey("GydytojaiasmKodas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PacientuKonsultavimoSistema.Models.Pacientas", null)
                        .WithMany()
                        .HasForeignKey("PacientaiasmKodas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("PacientuKonsultavimoSistema.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PacientuKonsultavimoSistema.Models.ApplicationUser", null)
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

                    b.HasOne("PacientuKonsultavimoSistema.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PacientuKonsultavimoSistema.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PacientuKonsultavimoSistema.Models.Message", b =>
                {
                    b.HasOne("PacientuKonsultavimoSistema.Models.ApplicationUser", "Sender")
                        .WithMany("Messages")
                        .HasForeignKey("UserID");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("PacientuKonsultavimoSistema.Models.ApplicationUser", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
