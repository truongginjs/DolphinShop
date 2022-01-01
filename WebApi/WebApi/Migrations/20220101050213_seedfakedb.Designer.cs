﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Infrastructure;

namespace WebApi.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220101050213_seedfakedb")]
    partial class seedfakedb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<int>("PostsId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("PostsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("WebApi.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<int>("CommentatorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Postid")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserCreateId")
                        .HasColumnType("int");

                    b.Property<int>("UserUpdateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("CommentatorId");

                    b.HasIndex("Postid");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("WebApi.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("MediaType")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserCreateId")
                        .HasColumnType("int");

                    b.Property<int>("UserUpdateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("WebApi.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Counter")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("EvaluateValue")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserCreateId")
                        .HasColumnType("int");

                    b.Property<int>("UserUpdateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("WebApi.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserCreateId")
                        .HasColumnType("int");

                    b.Property<int>("UserUpdateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765),
                            Description = "user",
                            IsDeleted = false,
                            Name = "user",
                            UpdatedDate = new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765),
                            UserCreateId = 0,
                            UserUpdateId = 0
                        },
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765),
                            Description = "admin",
                            IsDeleted = false,
                            Name = "admin",
                            UpdatedDate = new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765),
                            UserCreateId = 0,
                            UserUpdateId = 0
                        });
                });

            modelBuilder.Entity("WebApi.Models.Sharer", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId1");

                    b.ToTable("Sharer");
                });

            modelBuilder.Entity("WebApi.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descriptions")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserCreateId")
                        .HasColumnType("int");

                    b.Property<int>("UserUpdateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("WebApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Fullname")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserCreateId")
                        .HasColumnType("int");

                    b.Property<int>("UserUpdateId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("RoleId");

                    b.HasIndex("TagId");

                    b.HasIndex("Email", "Username", "PhoneNumber");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765),
                            Description = "user",
                            Email = "admin@domain",
                            Fullname = "admin",
                            Gender = "Male",
                            IsDeleted = false,
                            Password = "$2a$12$MGa6ScF63rYWdXAnnyY6QetDfkefN6in0g0OfHdf8idMOTr85HtkS",
                            PhoneNumber = "190000000",
                            RoleId = 1,
                            UpdatedDate = new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765),
                            UserCreateId = 0,
                            UserUpdateId = 0,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Voter", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId1");

                    b.ToTable("Voter");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("WebApi.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Models.Comment", b =>
                {
                    b.HasOne("WebApi.Models.Comment", null)
                        .WithMany("Replyments")
                        .HasForeignKey("CommentId");

                    b.HasOne("WebApi.Models.User", "Commentator")
                        .WithMany()
                        .HasForeignKey("CommentatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("Postid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commentator");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("WebApi.Models.Media", b =>
                {
                    b.HasOne("WebApi.Models.Post", "Post")
                        .WithMany("Media")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("WebApi.Models.Post", b =>
                {
                    b.HasOne("WebApi.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("WebApi.Models.Sharer", b =>
                {
                    b.HasOne("WebApi.Models.Post", "Post")
                        .WithMany("Sharers")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Models.User", b =>
                {
                    b.HasOne("WebApi.Models.Comment", null)
                        .WithMany("Voters")
                        .HasForeignKey("CommentId");

                    b.HasOne("WebApi.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Tag", null)
                        .WithMany("InterestingMember")
                        .HasForeignKey("TagId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebApi.Models.Voter", b =>
                {
                    b.HasOne("WebApi.Models.Post", "Post")
                        .WithMany("Voters")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Models.Comment", b =>
                {
                    b.Navigation("Replyments");

                    b.Navigation("Voters");
                });

            modelBuilder.Entity("WebApi.Models.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Media");

                    b.Navigation("Sharers");

                    b.Navigation("Voters");
                });

            modelBuilder.Entity("WebApi.Models.Tag", b =>
                {
                    b.Navigation("InterestingMember");
                });
#pragma warning restore 612, 618
        }
    }
}
