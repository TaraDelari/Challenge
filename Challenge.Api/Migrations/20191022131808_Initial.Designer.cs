﻿// <auto-generated />
using Challenge.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Challenge.Api.Migrations
{
    [DbContext(typeof(ChallengeContext))]
    [Migration("20191022131808_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Challenge.Core.Models.Keyword", b =>
                {
                    b.Property<string>("Word");

                    b.Property<string>("WebPageUrl");

                    b.HasKey("Word", "WebPageUrl");

                    b.HasIndex("WebPageUrl");

                    b.ToTable("keywords");
                });

            modelBuilder.Entity("Challenge.Core.Models.Link", b =>
                {
                    b.Property<string>("WebPageUrl");

                    b.Property<string>("UserId");

                    b.HasKey("WebPageUrl", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("links");
                });

            modelBuilder.Entity("Challenge.Core.Models.Role", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(500);

                    b.HasKey("Name");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Name = "Admin",
                            DisplayName = "Admin"
                        },
                        new
                        {
                            Name = "User",
                            DisplayName = "User"
                        });
                });

            modelBuilder.Entity("Challenge.Core.Models.Tag", b =>
                {
                    b.Property<string>("Content");

                    b.Property<string>("Url");

                    b.Property<string>("LinkUserId");

                    b.HasKey("Content", "Url", "LinkUserId");

                    b.HasIndex("Url", "LinkUserId");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("Challenge.Core.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("Challenge.Core.Models.UserRole", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleName");

                    b.HasKey("UserId", "RoleName");

                    b.HasIndex("RoleName");

                    b.ToTable("user_roles");
                });

            modelBuilder.Entity("Challenge.Core.Models.WebPage", b =>
                {
                    b.Property<string>("Url")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Url");

                    b.ToTable("webpages");
                });

            modelBuilder.Entity("Challenge.Core.Models.Keyword", b =>
                {
                    b.HasOne("Challenge.Core.Models.WebPage", "WebPage")
                        .WithMany("Keywords")
                        .HasForeignKey("WebPageUrl")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Challenge.Core.Models.Link", b =>
                {
                    b.HasOne("Challenge.Core.Models.User", "User")
                        .WithMany("Links")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Challenge.Core.Models.WebPage", "WebPage")
                        .WithMany()
                        .HasForeignKey("WebPageUrl")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Challenge.Core.Models.Tag", b =>
                {
                    b.HasOne("Challenge.Core.Models.Link", "Link")
                        .WithMany("Tags")
                        .HasForeignKey("Url", "LinkUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Challenge.Core.Models.UserRole", b =>
                {
                    b.HasOne("Challenge.Core.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Challenge.Core.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
