using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Nocturno.Repository.Migrations
{
    public partial class changedKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_Article_Category_CategoryId", table: "Article");
            migrationBuilder.DropForeignKey(name: "FK_Collection_Section_SectionId", table: "Collection");
            migrationBuilder.DropForeignKey(name: "FK_CollectionItem_Collection_CollectionId", table: "CollectionItem");
            migrationBuilder.DropForeignKey(name: "FK_Item_Section_SectionId", table: "Item");
            migrationBuilder.DropForeignKey(name: "FK_Menu_Section_SectionId", table: "Menu");
            migrationBuilder.DropForeignKey(name: "FK_MenuItem_Menu_MenuId", table: "MenuItem");
            migrationBuilder.DropForeignKey(name: "FK_Portfolio_Section_SectionId", table: "Portfolio");
            migrationBuilder.DropForeignKey(name: "FK_PortfolioItem_Portfolio_PortfolioId", table: "PortfolioItem");
            migrationBuilder.DropForeignKey(name: "FK_SectionPage_Page_PageId", table: "SectionPage");
            migrationBuilder.DropForeignKey(name: "FK_SectionPage_Section_SectionId", table: "SectionPage");
            migrationBuilder.DropForeignKey(name: "FK_TagToArticle_Article_ArticleId", table: "TagToArticle");
            migrationBuilder.DropForeignKey(name: "FK_TagToArticle_Tag_TagId", table: "TagToArticle");
            migrationBuilder.DropPrimaryKey(name: "PK_SectionPage", table: "SectionPage");
            migrationBuilder.DropColumn(name: "Id", table: "SectionPage");
            migrationBuilder.DropColumn(name: "Name", table: "SectionPage");
            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionPage",
                table: "SectionPage",
                columns: new[] { "SectionId", "PageId" });
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Article_Category_CategoryId",
                table: "Article",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Collection_Section_SectionId",
                table: "Collection",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_CollectionItem_Collection_CollectionId",
                table: "CollectionItem",
                column: "CollectionId",
                principalTable: "Collection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Item_Section_SectionId",
                table: "Item",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Section_SectionId",
                table: "Menu",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Menu_MenuId",
                table: "MenuItem",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Portfolio_Section_SectionId",
                table: "Portfolio",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioItem_Portfolio_PortfolioId",
                table: "PortfolioItem",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_SectionPage_Page_PageId",
                table: "SectionPage",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_SectionPage_Section_SectionId",
                table: "SectionPage",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_TagToArticle_Article_ArticleId",
                table: "TagToArticle",
                column: "ArticleId",
                principalTable: "Article",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_TagToArticle_Tag_TagId",
                table: "TagToArticle",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_Article_Category_CategoryId", table: "Article");
            migrationBuilder.DropForeignKey(name: "FK_Collection_Section_SectionId", table: "Collection");
            migrationBuilder.DropForeignKey(name: "FK_CollectionItem_Collection_CollectionId", table: "CollectionItem");
            migrationBuilder.DropForeignKey(name: "FK_Item_Section_SectionId", table: "Item");
            migrationBuilder.DropForeignKey(name: "FK_Menu_Section_SectionId", table: "Menu");
            migrationBuilder.DropForeignKey(name: "FK_MenuItem_Menu_MenuId", table: "MenuItem");
            migrationBuilder.DropForeignKey(name: "FK_Portfolio_Section_SectionId", table: "Portfolio");
            migrationBuilder.DropForeignKey(name: "FK_PortfolioItem_Portfolio_PortfolioId", table: "PortfolioItem");
            migrationBuilder.DropForeignKey(name: "FK_SectionPage_Page_PageId", table: "SectionPage");
            migrationBuilder.DropForeignKey(name: "FK_SectionPage_Section_SectionId", table: "SectionPage");
            migrationBuilder.DropForeignKey(name: "FK_TagToArticle_Article_ArticleId", table: "TagToArticle");
            migrationBuilder.DropForeignKey(name: "FK_TagToArticle_Tag_TagId", table: "TagToArticle");
            migrationBuilder.DropPrimaryKey(name: "PK_SectionPage", table: "SectionPage");
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SectionPage",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SectionPage",
                nullable: true);
            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionPage",
                table: "SectionPage",
                column: "Id");
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Article_Category_CategoryId",
                table: "Article",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Collection_Section_SectionId",
                table: "Collection",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_CollectionItem_Collection_CollectionId",
                table: "CollectionItem",
                column: "CollectionId",
                principalTable: "Collection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Item_Section_SectionId",
                table: "Item",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Section_SectionId",
                table: "Menu",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Menu_MenuId",
                table: "MenuItem",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Portfolio_Section_SectionId",
                table: "Portfolio",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioItem_Portfolio_PortfolioId",
                table: "PortfolioItem",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_SectionPage_Page_PageId",
                table: "SectionPage",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_SectionPage_Section_SectionId",
                table: "SectionPage",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_TagToArticle_Article_ArticleId",
                table: "TagToArticle",
                column: "ArticleId",
                principalTable: "Article",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_TagToArticle_Tag_TagId",
                table: "TagToArticle",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
