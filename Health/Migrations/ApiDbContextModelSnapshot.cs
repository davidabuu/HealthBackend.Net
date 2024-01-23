﻿// <auto-generated />
using System;
using Health.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Health.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("Health.Dto.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JwtId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Health.Model.AttendanceEntry", b =>
                {
                    b.Property<int?>("AttendanceEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EntryTime")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsPresent")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StaffId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StaffManagementStaffId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AttendanceEntryId");

                    b.HasIndex("StaffManagementStaffId");

                    b.ToTable("AttendanceEntries");
                });

            modelBuilder.Entity("Health.Model.AvailabilitySlot", b =>
                {
                    b.Property<int?>("AvailabilitySlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Approved")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DoctorRegistrationDoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("AvailabilitySlotId");

                    b.HasIndex("DoctorRegistrationDoctorId");

                    b.ToTable("AvailabilitySlots");
                });

            modelBuilder.Entity("Health.Model.BillItem", b =>
                {
                    b.Property<int?>("BillItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PatientBillBillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BillItemId");

                    b.HasIndex("PatientBillBillId");

                    b.ToTable("BillItems");
                });

            modelBuilder.Entity("Health.Model.DoctorRegistration", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialization")
                        .HasColumnType("TEXT");

                    b.HasKey("DoctorId");

                    b.ToTable("DoctorRegistrations");
                });

            modelBuilder.Entity("Health.Model.InventoryItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CurrentStock")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReorderLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ItemId");

                    b.HasIndex("SupplierId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("Health.Model.LabRadiologyOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrderingDoctorDoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId");

                    b.HasIndex("OrderingDoctorDoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("LabRadiologyOrders");
                });

            modelBuilder.Entity("Health.Model.LabTest", b =>
                {
                    b.Property<int?>("LabTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LabRadiologyOrderOrderId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ResultDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResultDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("TestName")
                        .HasColumnType("TEXT");

                    b.HasKey("LabTestId");

                    b.HasIndex("LabRadiologyOrderOrderId");

                    b.ToTable("LabTests");
                });

            modelBuilder.Entity("Health.Model.MedicalHistoryEntry", b =>
                {
                    b.Property<int?>("MedicalHistoryEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateTimeNow")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PatientRegistrationPatientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeOfIllness")
                        .HasColumnType("TEXT");

                    b.HasKey("MedicalHistoryEntryId");

                    b.HasIndex("PatientRegistrationPatientId");

                    b.ToTable("MedicalHistoryEntries");
                });

            modelBuilder.Entity("Health.Model.OrderHistory", b =>
                {
                    b.Property<int?>("OrderHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InventoryItemItemId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuantityOrdered")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderHistoryId");

                    b.HasIndex("InventoryItemItemId");

                    b.ToTable("OrderHistories");
                });

            modelBuilder.Entity("Health.Model.PatientBill", b =>
                {
                    b.Property<int?>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("TEXT");

                    b.HasKey("BillId");

                    b.ToTable("PatientBills");
                });

            modelBuilder.Entity("Health.Model.PatientRegistration", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.Property<string>("InsuranceDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("PatientId");

                    b.ToTable("PatientRegistrations");
                });

            modelBuilder.Entity("Health.Model.StaffManagement", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("StaffId");

                    b.ToTable("StaffManagements");
                });

            modelBuilder.Entity("Health.Model.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Health.Model.AdminRegistration", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("AdminRegistration");
                });

            modelBuilder.Entity("Health.Model.AttendanceEntry", b =>
                {
                    b.HasOne("Health.Model.StaffManagement", null)
                        .WithMany("Attendance")
                        .HasForeignKey("StaffManagementStaffId");
                });

            modelBuilder.Entity("Health.Model.AvailabilitySlot", b =>
                {
                    b.HasOne("Health.Model.DoctorRegistration", null)
                        .WithMany("Availability")
                        .HasForeignKey("DoctorRegistrationDoctorId");
                });

            modelBuilder.Entity("Health.Model.BillItem", b =>
                {
                    b.HasOne("Health.Model.PatientBill", null)
                        .WithMany("BillItems")
                        .HasForeignKey("PatientBillBillId");
                });

            modelBuilder.Entity("Health.Model.InventoryItem", b =>
                {
                    b.HasOne("Health.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Health.Model.LabRadiologyOrder", b =>
                {
                    b.HasOne("Health.Model.DoctorRegistration", "OrderingDoctor")
                        .WithMany()
                        .HasForeignKey("OrderingDoctorDoctorId");

                    b.HasOne("Health.Model.PatientRegistration", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("OrderingDoctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Health.Model.LabTest", b =>
                {
                    b.HasOne("Health.Model.LabRadiologyOrder", null)
                        .WithMany("OrderedTests")
                        .HasForeignKey("LabRadiologyOrderOrderId");
                });

            modelBuilder.Entity("Health.Model.MedicalHistoryEntry", b =>
                {
                    b.HasOne("Health.Model.PatientRegistration", null)
                        .WithMany("MedicalHistory")
                        .HasForeignKey("PatientRegistrationPatientId");
                });

            modelBuilder.Entity("Health.Model.OrderHistory", b =>
                {
                    b.HasOne("Health.Model.InventoryItem", null)
                        .WithMany("OrderHistory")
                        .HasForeignKey("InventoryItemItemId");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Health.Model.DoctorRegistration", b =>
                {
                    b.Navigation("Availability");
                });

            modelBuilder.Entity("Health.Model.InventoryItem", b =>
                {
                    b.Navigation("OrderHistory");
                });

            modelBuilder.Entity("Health.Model.LabRadiologyOrder", b =>
                {
                    b.Navigation("OrderedTests");
                });

            modelBuilder.Entity("Health.Model.PatientBill", b =>
                {
                    b.Navigation("BillItems");
                });

            modelBuilder.Entity("Health.Model.PatientRegistration", b =>
                {
                    b.Navigation("MedicalHistory");
                });

            modelBuilder.Entity("Health.Model.StaffManagement", b =>
                {
                    b.Navigation("Attendance");
                });
#pragma warning restore 612, 618
        }
    }
}