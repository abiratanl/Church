using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Church.API.Migrations
{
    /// <inheritdoc />
    public partial class addDirectorship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leader_Member_MemberId",
                schema: "backoffice",
                table: "Leader");

            migrationBuilder.CreateTable(
                name: "Directorship",
                schema: "backoffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CongregationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoardRole = table.Column<byte>(type: "TINYINT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: true),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    Notes = table.Column<string>(type: "NVARCHAR(180)", maxLength: 180, nullable: true),
                    StartDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directorship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Directorship_Congregation_CongregationId",
                        column: x => x.CongregationId,
                        principalSchema: "backoffice",
                        principalTable: "Congregation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Directorship_Member_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "backoffice",
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Directorship_CongregationId",
                schema: "backoffice",
                table: "Directorship",
                column: "CongregationId");

            migrationBuilder.CreateIndex(
                name: "IX_Directorship_MemberId",
                schema: "backoffice",
                table: "Directorship",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leader_Member_MemberId",
                schema: "backoffice",
                table: "Leader",
                column: "MemberId",
                principalSchema: "backoffice",
                principalTable: "Member",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leader_Member_MemberId",
                schema: "backoffice",
                table: "Leader");

            migrationBuilder.DropTable(
                name: "Directorship",
                schema: "backoffice");

            migrationBuilder.AddForeignKey(
                name: "FK_Leader_Member_MemberId",
                schema: "backoffice",
                table: "Leader",
                column: "MemberId",
                principalSchema: "backoffice",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
