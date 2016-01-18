using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Nocturno.Data.Context;

namespace Nocturno.Data.Migrations
{
    [DbContext(typeof(NocturnoContext))]
    partial class NocturnoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("Nocturno.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<int?>("BlogId");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Name");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Name");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CmsContentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CmsContentTypeToFieldType", b =>
                {
                    b.Property<int>("CmsContentTypeId");

                    b.Property<int>("CmsFieldTypeId");

                    b.Property<int>("Order");

                    b.HasKey("CmsContentTypeId", "CmsFieldTypeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CmsFieldType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Name");

                    b.Property<int>("SectionId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CollectionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<int>("CollectionId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Header");

                    b.Property<string>("Hyperlink");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Header");

                    b.Property<string>("Name");

                    b.Property<int>("SectionId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("SectionId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hyperlink");

                    b.Property<int>("MenuId");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("SectionId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.PortfolioItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Hyperlink");

                    b.Property<string>("Name");

                    b.Property<int>("PortfolioId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SectionToPage", b =>
                {
                    b.Property<int>("SectionId");

                    b.Property<int>("PageId");

                    b.HasKey("SectionId", "PageId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.TagToArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<string>("Name");

                    b.Property<int>("TagId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Article", b =>
                {
                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Nocturno.Data.Models.Blog")
                        .WithMany()
                        .HasForeignKey("BlogId");

                    b.HasOne("Nocturno.Data.Models.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Blog", b =>
                {
                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CmsContentTypeToFieldType", b =>
                {
                    b.HasOne("Nocturno.Data.Models.CmsContentType")
                        .WithMany()
                        .HasForeignKey("CmsContentTypeId");

                    b.HasOne("Nocturno.Data.Models.CmsFieldType")
                        .WithMany()
                        .HasForeignKey("CmsFieldTypeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Collection", b =>
                {
                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Nocturno.Data.Models.Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CollectionItem", b =>
                {
                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Nocturno.Data.Models.Collection")
                        .WithMany()
                        .HasForeignKey("CollectionId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Item", b =>
                {
                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Nocturno.Data.Models.Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Menu", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.MenuItem", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Portfolio", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.PortfolioItem", b =>
                {
                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Nocturno.Data.Models.Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SectionToPage", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Page")
                        .WithMany()
                        .HasForeignKey("PageId");

                    b.HasOne("Nocturno.Data.Models.Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.TagToArticle", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Article")
                        .WithMany()
                        .HasForeignKey("ArticleId");

                    b.HasOne("Nocturno.Data.Models.Tag")
                        .WithMany()
                        .HasForeignKey("TagId");
                });
        }
    }
}
