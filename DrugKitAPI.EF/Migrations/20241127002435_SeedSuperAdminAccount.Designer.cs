﻿// <auto-generated />
using System;
using DrugKitAPI.EF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrugKitAPI.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241127002435_SeedSuperAdminAccount")]
    partial class SeedSuperAdminAccount
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DrugKitAPI.Core.Models.ApplicationUser", b =>
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

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<DateTime?>("ResetCodeExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResetPasswordCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("VerificationCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.BannedUser", b =>
                {
                    b.Property<int>("MobileUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("SystemAdminId")
                        .HasColumnType("int");

                    b.HasKey("MobileUserId");

                    b.HasIndex("SystemAdminId");

                    b.ToTable("BannedUsers");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AdminActionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrugName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentityPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("MobileUserId")
                        .HasColumnType("int");

                    b.Property<int>("SystemAdminId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MobileUserId");

                    b.HasIndex("SystemAdminId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.DonationImg", b =>
                {
                    b.Property<int>("DonationId")
                        .HasColumnType("int");

                    b.Property<string>("ImagPath")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DonationId", "ImagPath");

                    b.ToTable("DonationImg");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Drug", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("arabic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dosage_form")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imported")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("oldprice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("units")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.DrugCategory", b =>
                {
                    b.Property<int>("DrugId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("DrugId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("DrugCategories");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.DrugImg", b =>
                {
                    b.Property<int>("DrugId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DrugId", "ImagePath");

                    b.ToTable("DrugImgs");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.MobileUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.ToTable("MobileUsers");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("MobileUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MobileUserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("MobileUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MobileUserId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.SideEffect", b =>
                {
                    b.Property<int>("DrugId")
                        .HasColumnType("int");

                    b.Property<string>("Effect")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EffectId")
                        .HasColumnType("int");

                    b.HasKey("DrugId", "Effect");

                    b.ToTable("SideEffects");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.SystemAdmin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.ToTable("SystemAdmins");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.UserRequestedDonation", b =>
                {
                    b.Property<int>("MobileUserId")
                        .HasColumnType("int");

                    b.Property<int>("DonationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentityPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalReportPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MobileUserId", "DonationId");

                    b.HasIndex("DonationId");

                    b.ToTable("UserRequestedDonations");
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.BannedUser", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.MobileUser", "MobileUser")
                        .WithOne("BannedUser")
                        .HasForeignKey("DrugKitAPI.Core.Models.BannedUser", "MobileUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrugKitAPI.Core.Models.SystemAdmin", "SystemAdmin")
                        .WithMany("BannedUsers")
                        .HasForeignKey("SystemAdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MobileUser");

                    b.Navigation("SystemAdmin");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Donation", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.MobileUser", "MobileUser")
                        .WithMany("Donations")
                        .HasForeignKey("MobileUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrugKitAPI.Core.Models.SystemAdmin", "SystemAdmin")
                        .WithMany("Donations")
                        .HasForeignKey("SystemAdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MobileUser");

                    b.Navigation("SystemAdmin");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.DonationImg", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.Donation", "Donation")
                        .WithMany("DonationImgs")
                        .HasForeignKey("DonationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donation");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.DrugCategory", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.Category", "Category")
                        .WithMany("DrugCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrugKitAPI.Core.Models.Drug", "Drug")
                        .WithMany("DrugCategories")
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.DrugImg", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.Drug", "Drug")
                        .WithMany("DrugImgs")
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.MobileUser", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("MobileUser")
                        .HasForeignKey("DrugKitAPI.Core.Models.MobileUser", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Notification", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.MobileUser", "MobileUser")
                        .WithMany("Notifications")
                        .HasForeignKey("MobileUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MobileUser");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Report", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.MobileUser", "MobileUser")
                        .WithMany("Reports")
                        .HasForeignKey("MobileUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MobileUser");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.SideEffect", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.Drug", "Drug")
                        .WithMany("SideEffects")
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.SystemAdmin", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("SystemAdmin")
                        .HasForeignKey("DrugKitAPI.Core.Models.SystemAdmin", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.UserRequestedDonation", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.Donation", "Donation")
                        .WithMany("UserRequestedDonations")
                        .HasForeignKey("DonationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrugKitAPI.Core.Models.MobileUser", "MobileUser")
                        .WithMany("UserRequestedDonations")
                        .HasForeignKey("MobileUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donation");

                    b.Navigation("MobileUser");
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
                    b.HasOne("DrugKitAPI.Core.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.ApplicationUser", null)
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

                    b.HasOne("DrugKitAPI.Core.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DrugKitAPI.Core.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.ApplicationUser", b =>
                {
                    b.Navigation("MobileUser")
                        .IsRequired();

                    b.Navigation("SystemAdmin")
                        .IsRequired();
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Category", b =>
                {
                    b.Navigation("DrugCategories");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Donation", b =>
                {
                    b.Navigation("DonationImgs");

                    b.Navigation("UserRequestedDonations");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.Drug", b =>
                {
                    b.Navigation("DrugCategories");

                    b.Navigation("DrugImgs");

                    b.Navigation("SideEffects");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.MobileUser", b =>
                {
                    b.Navigation("BannedUser")
                        .IsRequired();

                    b.Navigation("Donations");

                    b.Navigation("Notifications");

                    b.Navigation("Reports");

                    b.Navigation("UserRequestedDonations");
                });

            modelBuilder.Entity("DrugKitAPI.Core.Models.SystemAdmin", b =>
                {
                    b.Navigation("BannedUsers");

                    b.Navigation("Donations");
                });
#pragma warning restore 612, 618
        }
    }
}
