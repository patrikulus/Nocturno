using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Nocturno.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_Article_Category_CategoryId", table: "Article");
            migrationBuilder.DropForeignKey(name: "FK_CmsContentTypeToFieldType_CmsContentType_CmsContentTypeId", table: "CmsContentTypeToFieldType");
            migrationBuilder.DropForeignKey(name: "FK_CmsContentTypeToFieldType_CmsFieldType_CmsFieldTypeId", table: "CmsContentTypeToFieldType");
            migrationBuilder.DropForeignKey(name: "FK_Collection_Section_SectionId", table: "Collection");
            migrationBuilder.DropForeignKey(name: "FK_CollectionItem_Collection_CollectionId", table: "CollectionItem");
            migrationBuilder.DropForeignKey(name: "FK_Item_Section_SectionId", table: "Item");
            migrationBuilder.DropForeignKey(name: "FK_Menu_Section_SectionId", table: "Menu");
            migrationBuilder.DropForeignKey(name: "FK_MenuItem_Menu_MenuId", table: "MenuItem");
            migrationBuilder.DropForeignKey(name: "FK_Portfolio_Section_SectionId", table: "Portfolio");
            migrationBuilder.DropForeignKey(name: "FK_PortfolioItem_Portfolio_PortfolioId", table: "PortfolioItem");
            migrationBuilder.DropForeignKey(name: "FK_Section_Content_ContentId", table: "Section");
            migrationBuilder.DropForeignKey(name: "FK_SectionToPage_Page_PageId", table: "SectionToPage");
            migrationBuilder.DropForeignKey(name: "FK_SectionToPage_Section_SectionId", table: "SectionToPage");
            migrationBuilder.DropForeignKey(name: "FK_TagToArticle_Article_ArticleId", table: "TagToArticle");
            migrationBuilder.DropForeignKey(name: "FK_TagToArticle_Tag_TagId", table: "TagToArticle");
            migrationBuilder.DropColumn(name: "ContentId", table: "Section");
            migrationBuilder.DropTable("Content");
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
                name: "FK_CmsContentTypeToFieldType_CmsContentType_CmsContentTypeId",
                table: "CmsContentTypeToFieldType",
                column: "CmsContentTypeId",
                principalTable: "CmsContentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_CmsContentTypeToFieldType_CmsFieldType_CmsFieldTypeId",
                table: "CmsContentTypeToFieldType",
                column: "CmsFieldTypeId",
                principalTable: "CmsFieldType",
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
                name: "FK_SectionToPage_Page_PageId",
                table: "SectionToPage",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_SectionToPage_Section_SectionId",
                table: "SectionToPage",
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
            migrationBuilder.DropForeignKey(name: "FK_CmsContentTypeToFieldType_CmsContentType_CmsContentTypeId", table: "CmsContentTypeToFieldType");
            migrationBuilder.DropForeignKey(name: "FK_CmsContentTypeToFieldType_CmsFieldType_CmsFieldTypeId", table: "CmsContentTypeToFieldType");
            migrationBuilder.DropForeignKey(name: "FK_Collection_Section_SectionId", table: "Collection");
            migrationBuilder.DropForeignKey(name: "FK_CollectionItem_Collection_CollectionId", table: "CollectionItem");
            migrationBuilder.DropForeignKey(name: "FK_Item_Section_SectionId", table: "Item");
            migrationBuilder.DropForeignKey(name: "FK_Menu_Section_SectionId", table: "Menu");
            migrationBuilder.DropForeignKey(name: "FK_MenuItem_Menu_MenuId", table: "MenuItem");
            migrationBuilder.DropForeignKey(name: "FK_Portfolio_Section_SectionId", table: "Portfolio");
            migrationBuilder.DropForeignKey(name: "FK_PortfolioItem_Portfolio_PortfolioId", table: "PortfolioItem");
            migrationBuilder.DropForeignKey(name: "FK_SectionToPage_Page_PageId", table: "SectionToPage");
            migrationBuilder.DropForeignKey(name: "FK_SectionToPage_Section_SectionId", table: "SectionToPage");
            migrationBuilder.DropForeignKey(name: "FK_TagToArticle_Article_ArticleId", table: "TagToArticle");
            migrationBuilder.DropForeignKey(name: "FK_TagToArticle_Tag_TagId", table: "TagToArticle");
            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                });
            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "Section",
                nullable: false,
                defaultValue: 0);
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
                name: "FK_CmsContentTypeToFieldType_CmsContentType_CmsContentTypeId",
                table: "CmsContentTypeToFieldType",
                column: "CmsContentTypeId",
                principalTable: "CmsContentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_CmsContentTypeToFieldType_CmsFieldType_CmsFieldTypeId",
                table: "CmsContentTypeToFieldType",
                column: "CmsFieldTypeId",
                principalTable: "CmsFieldType",
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
                name: "FK_Section_Content_ContentId",
                table: "Section",
                column: "ContentId",
                principalTable: "Content",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_SectionToPage_Page_PageId",
                table: "SectionToPage",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_SectionToPage_Section_SectionId",
                table: "SectionToPage",
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
