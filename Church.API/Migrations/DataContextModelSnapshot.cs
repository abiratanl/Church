﻿// <auto-generated />
using System;
using Church.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Church.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("backoffice")
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Church.Contexts.AccountContext.Entities.BlackList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("BlackList", "backoffice");
                });

            modelBuilder.Entity("Church.Contexts.AccountContext.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Role", "backoffice");
                });

            modelBuilder.Entity("Church.Contexts.AccountContext.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("BIT");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("User", "backoffice");
                });

            modelBuilder.Entity("Church.Contexts.AccountContext.Entities.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("SMALLDATETIME")
                        .HasColumnName("EndDate");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("UNIQUEIDENTIFIER")
                        .HasColumnName("RoleId");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("SMALLDATETIME")
                        .HasColumnName("StartDate");

                    b.Property<Guid>("UserId")
                        .HasColumnType("UNIQUEIDENTIFIER")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole", "backoffice");
                });

            modelBuilder.Entity("Church.Contexts.SharedContext.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR");

                    b.Property<int>("DocumentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasDefaultValue(2);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("BIT");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Document", "backoffice");
                });

            modelBuilder.Entity("Church.Contexts.SharedContext.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("DATETIME2");

                    b.Property<string>("Citizenship")
                        .HasMaxLength(160)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("INT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Obs")
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Photo")
                        .HasColumnType("NVARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Person", "backoffice");
                });

            modelBuilder.Entity("Church.Contexts.AccountContext.Entities.BlackList", b =>
                {
                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("BlackListId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Address")
                                .IsRequired()
                                .HasMaxLength(120)
                                .HasColumnType("VARCHAR")
                                .HasColumnName("Email");

                            b1.HasKey("BlackListId");

                            b1.ToTable("BlackList", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("BlackListId");
                        });

                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Tracker", "Tracker", b1 =>
                        {
                            b1.Property<Guid>("BlackListId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("SMALLDATETIME")
                                .HasColumnName("CreatedAt");

                            b1.Property<string>("Notes")
                                .HasMaxLength(1024)
                                .HasColumnType("nvarchar(1024)")
                                .HasColumnName("Notes");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("SMALLDATETIME")
                                .HasColumnName("UpdatedAt");

                            b1.HasKey("BlackListId");

                            b1.ToTable("BlackList", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("BlackListId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Tracker")
                        .IsRequired();
                });

            modelBuilder.Entity("Church.Contexts.AccountContext.Entities.User", b =>
                {
                    b.HasOne("Church.Contexts.SharedContext.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Tracker", "Tracker", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("SMALLDATETIME");

                            b1.Property<string>("Notes")
                                .IsRequired()
                                .HasMaxLength(1024)
                                .HasColumnType("NVARCHAR");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("SMALLDATETIME");

                            b1.HasKey("UserId");

                            b1.ToTable("User", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Email", "Username", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Address")
                                .IsRequired()
                                .HasMaxLength(120)
                                .HasColumnType("VARCHAR")
                                .HasColumnName("Email");

                            b1.HasKey("UserId");

                            b1.ToTable("User", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Verification", "Verification", b2 =>
                                {
                                    b2.Property<Guid>("EmailUserId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Code")
                                        .IsRequired()
                                        .HasMaxLength(8)
                                        .HasColumnType("CHAR")
                                        .HasColumnName("EmailVerificationCode");

                                    b2.Property<DateTime>("CodeExpireDate")
                                        .HasColumnType("DATETIME2")
                                        .HasColumnName("EmailVerificationCodeExpireDate");

                                    b2.Property<bool>("IsVerified")
                                        .HasColumnType("BIT")
                                        .HasColumnName("EmailVerified");

                                    b2.HasKey("EmailUserId");

                                    b2.ToTable("User", "backoffice");

                                    b2.WithOwner()
                                        .HasForeignKey("EmailUserId");
                                });

                            b1.Navigation("Verification")
                                .IsRequired();
                        });

                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Password", "Password", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<bool>("Expired")
                                .HasColumnType("BIT");

                            b1.Property<string>("Hash")
                                .IsRequired()
                                .HasMaxLength(120)
                                .HasColumnType("VARCHAR");

                            b1.HasKey("UserId");

                            b1.ToTable("User", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Password")
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Tracker")
                        .IsRequired();

                    b.Navigation("Username")
                        .IsRequired();
                });

            modelBuilder.Entity("Church.Contexts.AccountContext.Entities.UserRole", b =>
                {
                    b.HasOne("Church.Contexts.AccountContext.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Church.Contexts.AccountContext.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Church.Contexts.SharedContext.Entities.Document", b =>
                {
                    b.HasOne("Church.Contexts.SharedContext.Entities.Person", "Person")
                        .WithMany("Documents")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Tracker", "Tracker", b1 =>
                        {
                            b1.Property<Guid>("DocumentId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("SMALLDATETIME");

                            b1.Property<string>("Notes")
                                .IsRequired()
                                .HasMaxLength(160)
                                .HasColumnType("NVARCHAR");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("SMALLDATETIME");

                            b1.HasKey("DocumentId");

                            b1.ToTable("Document", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("DocumentId");
                        });

                    b.Navigation("Person");

                    b.Navigation("Tracker")
                        .IsRequired();
                });

            modelBuilder.Entity("Church.Contexts.SharedContext.Entities.Person", b =>
                {
                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Tracker", "Tracker", b1 =>
                        {
                            b1.Property<Guid>("PersonId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("SMALLDATETIME");

                            b1.Property<string>("Notes")
                                .IsRequired()
                                .HasMaxLength(160)
                                .HasColumnType("NVARCHAR");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("SMALLDATETIME");

                            b1.HasKey("PersonId");

                            b1.ToTable("Person", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("PersonId");
                        });

                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("PersonId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(160)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("Code")
                                .HasMaxLength(160)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("Complement")
                                .HasMaxLength(160)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasMaxLength(160)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("District")
                                .IsRequired()
                                .HasMaxLength(160)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("Notes")
                                .HasMaxLength(160)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasMaxLength(2)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(160)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("NVARCHAR");

                            b1.HasKey("PersonId");

                            b1.ToTable("Person", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("PersonId");
                        });

                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("PersonId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(60)
                                .HasColumnType("NVARCHAR");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(60)
                                .HasColumnType("NVARCHAR");

                            b1.HasKey("PersonId");

                            b1.ToTable("Person", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("PersonId");
                        });

                    b.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Phone", "Phone", b1 =>
                        {
                            b1.Property<Guid>("PersonId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("FullNumber")
                                .IsRequired()
                                .HasMaxLength(16)
                                .HasColumnType("VARCHAR");

                            b1.HasKey("PersonId");

                            b1.ToTable("Person", "backoffice");

                            b1.WithOwner()
                                .HasForeignKey("PersonId");

                            b1.OwnsOne("Church.Contexts.SharedContext.ValueObjects.Verification", "Verification", b2 =>
                                {
                                    b2.Property<Guid>("PhonePersonId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Code")
                                        .IsRequired()
                                        .HasMaxLength(6)
                                        .HasColumnType("CHAR");

                                    b2.Property<DateTime>("CodeExpireDate")
                                        .HasColumnType("DATETIME2");

                                    b2.Property<bool>("IsVerified")
                                        .HasColumnType("BIT");

                                    b2.HasKey("PhonePersonId");

                                    b2.ToTable("Person", "backoffice");

                                    b2.WithOwner()
                                        .HasForeignKey("PhonePersonId");
                                });

                            b1.Navigation("Verification")
                                .IsRequired();
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();

                    b.Navigation("Phone");

                    b.Navigation("Tracker")
                        .IsRequired();
                });

            modelBuilder.Entity("Church.Contexts.SharedContext.Entities.Person", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}