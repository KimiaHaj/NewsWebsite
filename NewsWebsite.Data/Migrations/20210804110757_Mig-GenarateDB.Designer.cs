﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsWebsite.Data;

namespace NewsWebsite.Data.Migrations
{
    [DbContext(typeof(NewsDBContext))]
    [Migration("20210804110757_Mig-GenarateDB")]
    partial class MigGenarateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("NewsWebsite.Entities.Bookmark", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NewsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "NewsId");

                    b.HasIndex("NewsId");

                    b.ToTable("Bookmarks");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentCategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Comment", b =>
                {
                    b.Property<string>("CommentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommentId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descriotion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirm")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParentCommentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PostageDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("CommentId");

                    b.HasIndex("CommentId1");

                    b.HasIndex("NewsId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
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

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaim");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
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

                    b.Property<DateTime?>("RegisterDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaim");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRole");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Like", b =>
                {
                    b.Property<string>("NewsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsLiked")
                        .HasColumnType("bit");

                    b.HasKey("NewsId", "IpAddress");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("NewsWebsite.Entities.News", b =>
                {
                    b.Property<string>("NewsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInternal")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublish")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PublishDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("CONVERT(datetime,GetDate())");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NewsId");

                    b.HasIndex("UserId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsCategory", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NewsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CategoryId", "NewsId");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsCategories");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsImage", b =>
                {
                    b.Property<string>("NewsImageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NewsImageId");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsImages");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsLetter", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RegisterDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Email");

                    b.ToTable("NewsLetters");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsTag", b =>
                {
                    b.Property<string>("TagId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NewsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TagId", "NewsId");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsTag");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Tag", b =>
                {
                    b.Property<string>("TagId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Visit", b =>
                {
                    b.Property<string>("NewsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("LastVisitDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberofVisit")
                        .HasColumnType("int");

                    b.HasKey("NewsId", "IpAddress");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NewsWebsite.Entities.Bookmark", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("Bookmarks")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewsWebsite.Entities.Identity.User", "User")
                        .WithMany("Bookmarks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Category", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Category", "category")
                        .WithMany("Categories")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("category");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Comment", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Comment", "comment")
                        .WithMany()
                        .HasForeignKey("CommentId1");

                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsId");

                    b.Navigation("comment");

                    b.Navigation("News");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.RoleClaim", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Identity.Role", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.UserClaim", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewsWebsite.Entities.Identity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Like", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("Likes")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");
                });

            modelBuilder.Entity("NewsWebsite.Entities.News", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Identity.User", "User")
                        .WithMany("News")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsCategory", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Category", "Category")
                        .WithMany("NewsCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("NewsCategories")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("News");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsImage", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("NewsImages")
                        .HasForeignKey("NewsId");

                    b.Navigation("News");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsTag", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("NewsTags")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewsWebsite.Entities.Tag", "Tag")
                        .WithMany("NewsTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Visit", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("Visits")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Category", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("NewsCategories");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.Role", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Identity.User", b =>
                {
                    b.Navigation("Bookmarks");

                    b.Navigation("Claims");

                    b.Navigation("News");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("NewsWebsite.Entities.News", b =>
                {
                    b.Navigation("Bookmarks");

                    b.Navigation("Comments");

                    b.Navigation("Likes");

                    b.Navigation("NewsCategories");

                    b.Navigation("NewsImages");

                    b.Navigation("NewsTags");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Tag", b =>
                {
                    b.Navigation("NewsTags");
                });
#pragma warning restore 612, 618
        }
    }
}