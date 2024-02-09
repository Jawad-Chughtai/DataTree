using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTree.Migrations
{
    /// <inheritdoc />
    public partial class SubMemberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppSubMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VuinDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<float>(type: "real", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSubMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSubMembers_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppSubMembers_UserId",
                table: "AppSubMembers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppSubMembers");
        }
    }
}
