using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Nocturno.Data.Context;

namespace Nocturno.Data.Migrations
{
    [DbContext(typeof(NocturnoContext))]
    [Migration("20160125180401_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("BlogId");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Name");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.ArticleTag", b =>
                {
                    b.Property<int>("ArticleId");

                    b.Property<int>("TagId");

                    b.HasKey("ArticleId", "TagId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Baner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hyperlink");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<string>("Text");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.BanerNode", b =>
                {
                    b.Property<int>("BanerId");

                    b.Property<int>("NodeId");

                    b.HasKey("BanerId", "NodeId");
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

            modelBuilder.Entity("Nocturno.Data.Models.BlogNode", b =>
                {
                    b.Property<int>("BlogId");

                    b.Property<int>("NodeId");

                    b.HasKey("BlogId", "NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.BusinessItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusinessId");

                    b.Property<string>("FacebookLink");

                    b.Property<string>("Header");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LinkedInLink");

                    b.Property<string>("Name");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.Property<string>("TwitterLink");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.BusinessNode", b =>
                {
                    b.Property<int>("BusinessId");

                    b.Property<int>("NodeId");

                    b.HasKey("BusinessId", "NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Icon");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CollectionType");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CollectionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CollectionId");

                    b.Property<string>("Hyperlink");

                    b.Property<string>("Icon");

                    b.Property<string>("Name");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CollectionNode", b =>
                {
                    b.Property<int>("CollectionId");

                    b.Property<int>("NodeId");

                    b.HasKey("CollectionId", "NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CollectionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.FileType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Extension");

                    b.Property<string>("Icon");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Icon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

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

            modelBuilder.Entity("Nocturno.Data.Models.Node", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PageId");

                    b.Property<int>("SectionId");

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

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.PortfolioItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<int>("PortfolioId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.PortfolioNode", b =>
                {
                    b.Property<int>("PortfolioId");

                    b.Property<int>("NodeId");

                    b.HasKey("PortfolioId", "NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsMandatory");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SimplePanel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hyperlink");

                    b.Property<string>("Name");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SimplePanelNode", b =>
                {
                    b.Property<int>("SimplePanelId");

                    b.Property<int>("NodeId");

                    b.HasKey("SimplePanelId", "NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SimpleText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SimpleTextNode", b =>
                {
                    b.Property<int>("SimpleTextId");

                    b.Property<int>("NodeId");

                    b.HasKey("SimpleTextId", "NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SliderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hyperlink");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<int>("SliderId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SliderNode", b =>
                {
                    b.Property<int>("SliderId");

                    b.Property<int>("NodeId");

                    b.HasKey("SliderId", "NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

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

            modelBuilder.Entity("Nocturno.Data.Models.ArticleTag", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Article")
                        .WithMany()
                        .HasForeignKey("ArticleId");

                    b.HasOne("Nocturno.Data.Models.Tag")
                        .WithMany()
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.BanerNode", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Baner")
                        .WithMany()
                        .HasForeignKey("BanerId");

                    b.HasOne("Nocturno.Data.Models.Node")
                        .WithMany()
                        .HasForeignKey("NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.Blog", b =>
                {
                    b.HasOne("Nocturno.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.BlogNode", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Blog")
                        .WithMany()
                        .HasForeignKey("BlogId");

                    b.HasOne("Nocturno.Data.Models.Node")
                        .WithMany()
                        .HasForeignKey("NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.BusinessItem", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Business")
                        .WithMany()
                        .HasForeignKey("BusinessId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.BusinessNode", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Business")
                        .WithMany()
                        .HasForeignKey("BusinessId");

                    b.HasOne("Nocturno.Data.Models.Node")
                        .WithMany()
                        .HasForeignKey("NodeId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CollectionItem", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Collection")
                        .WithMany()
                        .HasForeignKey("CollectionId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.CollectionNode", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Collection")
                        .WithMany()
                        .HasForeignKey("CollectionId");

                    b.HasOne("Nocturno.Data.Models.Node")
                        .WithMany()
                        .HasForeignKey("NodeId");
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

            modelBuilder.Entity("Nocturno.Data.Models.Node", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Page")
                        .WithMany()
                        .HasForeignKey("PageId");

                    b.HasOne("Nocturno.Data.Models.Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.PortfolioItem", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.PortfolioNode", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Node")
                        .WithMany()
                        .HasForeignKey("NodeId");

                    b.HasOne("Nocturno.Data.Models.Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SimplePanelNode", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Node")
                        .WithMany()
                        .HasForeignKey("NodeId");

                    b.HasOne("Nocturno.Data.Models.SimplePanel")
                        .WithMany()
                        .HasForeignKey("SimplePanelId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SimpleTextNode", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Node")
                        .WithMany()
                        .HasForeignKey("NodeId");

                    b.HasOne("Nocturno.Data.Models.SimpleText")
                        .WithMany()
                        .HasForeignKey("SimpleTextId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SliderItem", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Slider")
                        .WithMany()
                        .HasForeignKey("SliderId");
                });

            modelBuilder.Entity("Nocturno.Data.Models.SliderNode", b =>
                {
                    b.HasOne("Nocturno.Data.Models.Node")
                        .WithMany()
                        .HasForeignKey("NodeId");

                    b.HasOne("Nocturno.Data.Models.Slider")
                        .WithMany()
                        .HasForeignKey("SliderId");
                });
        }
    }
}
