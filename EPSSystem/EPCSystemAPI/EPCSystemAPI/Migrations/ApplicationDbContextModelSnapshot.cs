﻿// <auto-generated />
using System;
using EPCSystemAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EPCSystemAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EPCSystemAPI.models.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<int>("ProductionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.Property<int>("UserId2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("ProductionId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("_Certificates", (string)null);
                });

            modelBuilder.Entity("EPCSystemAPI.models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("_Devices", (string)null);
                });

            modelBuilder.Entity("EPCSystemAPI.models.ElectricityProduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmountWh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("_ElectricityProduction", (string)null);
                });

            modelBuilder.Entity("EPCSystemAPI.models.Ledger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CertificateId")
                        .HasColumnType("int");

                    b.Property<int>("CertificateId1")
                        .HasColumnType("int");

                    b.Property<int>("CertificateId2")
                        .HasColumnType("int");

                    b.Property<int>("ElectricityProductionId")
                        .HasColumnType("int");

                    b.Property<int>("ElectricityProductionId1")
                        .HasColumnType("int");

                    b.Property<int>("ElectricityProductionId2")
                        .HasColumnType("int");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.HasIndex("CertificateId1");

                    b.HasIndex("ElectricityProductionId");

                    b.HasIndex("ElectricityProductionId1");

                    b.ToTable("_Ledger", (string)null);
                });

            modelBuilder.Entity("EPCSystemAPI.models.ProduceEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmountWh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int>("ElectricityProductionId")
                        .HasColumnType("int");

                    b.Property<int>("LedgerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("ElectricityProductionId");

                    b.HasIndex("LedgerId");

                    b.ToTable("_ProduceEvents", (string)null);
                });

            modelBuilder.Entity("EPCSystemAPI.models.TransferEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CertificateId")
                        .HasColumnType("int");

                    b.Property<int>("FromUserId")
                        .HasColumnType("int");

                    b.Property<int>("LedgerId")
                        .HasColumnType("int");

                    b.Property<int>("ToUserId")
                        .HasColumnType("int");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("LedgerId");

                    b.HasIndex("ToUserId");

                    b.ToTable("_TransferEvents", (string)null);
                });

            modelBuilder.Entity("EPCSystemAPI.models.TransformEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmountWh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int>("ElectricityProductionId")
                        .HasColumnType("int");

                    b.Property<int>("LedgerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("ElectricityProductionId");

                    b.HasIndex("LedgerId");

                    b.ToTable("_TransformEvents", (string)null);
                });

            modelBuilder.Entity("EPCSystemAPI.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("_Users", (string)null);
                });

            modelBuilder.Entity("EPCSystemAPI.models.Certificate", b =>
                {
                    b.HasOne("EPCSystemAPI.models.ElectricityProduction", null)
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EPCSystemAPI.models.ElectricityProduction", "ElectricityProduction")
                        .WithMany()
                        .HasForeignKey("ProductionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.User", null)
                        .WithMany("Certificates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricityProduction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EPCSystemAPI.models.Device", b =>
                {
                    b.HasOne("EPCSystemAPI.models.User", "User")
                        .WithMany("Devices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EPCSystemAPI.models.ElectricityProduction", b =>
                {
                    b.HasOne("EPCSystemAPI.models.Device", "Device")
                        .WithMany("ElectricityProductions")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("EPCSystemAPI.models.Ledger", b =>
                {
                    b.HasOne("EPCSystemAPI.models.Certificate", null)
                        .WithMany("Ledgers")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.ElectricityProduction", null)
                        .WithMany("Ledgers")
                        .HasForeignKey("ElectricityProductionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.ElectricityProduction", "ElectricityProduction")
                        .WithMany()
                        .HasForeignKey("ElectricityProductionId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certificate");

                    b.Navigation("ElectricityProduction");
                });

            modelBuilder.Entity("EPCSystemAPI.models.ProduceEvent", b =>
                {
                    b.HasOne("EPCSystemAPI.models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.ElectricityProduction", "ElectricityProduction")
                        .WithMany("ProduceEvents")
                        .HasForeignKey("ElectricityProductionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.Ledger", "Ledger")
                        .WithMany("ProduceEvents")
                        .HasForeignKey("LedgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("ElectricityProduction");

                    b.Navigation("Ledger");
                });

            modelBuilder.Entity("EPCSystemAPI.models.TransferEvent", b =>
                {
                    b.HasOne("EPCSystemAPI.models.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.Ledger", "Ledger")
                        .WithMany("TransferEvents")
                        .HasForeignKey("LedgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.User", "ToUser")
                        .WithMany()
                        .HasForeignKey("ToUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FromUser");

                    b.Navigation("Ledger");

                    b.Navigation("ToUser");
                });

            modelBuilder.Entity("EPCSystemAPI.models.TransformEvent", b =>
                {
                    b.HasOne("EPCSystemAPI.models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.ElectricityProduction", "ElectricityProduction")
                        .WithMany("TransformEvents")
                        .HasForeignKey("ElectricityProductionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EPCSystemAPI.models.Ledger", "Ledger")
                        .WithMany("TransformEvents")
                        .HasForeignKey("LedgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("ElectricityProduction");

                    b.Navigation("Ledger");
                });

            modelBuilder.Entity("EPCSystemAPI.models.Certificate", b =>
                {
                    b.Navigation("Ledgers");
                });

            modelBuilder.Entity("EPCSystemAPI.models.Device", b =>
                {
                    b.Navigation("ElectricityProductions");
                });

            modelBuilder.Entity("EPCSystemAPI.models.ElectricityProduction", b =>
                {
                    b.Navigation("Ledgers");

                    b.Navigation("ProduceEvents");

                    b.Navigation("TransformEvents");
                });

            modelBuilder.Entity("EPCSystemAPI.models.Ledger", b =>
                {
                    b.Navigation("ProduceEvents");

                    b.Navigation("TransferEvents");

                    b.Navigation("TransformEvents");
                });

            modelBuilder.Entity("EPCSystemAPI.models.User", b =>
                {
                    b.Navigation("Certificates");

                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
