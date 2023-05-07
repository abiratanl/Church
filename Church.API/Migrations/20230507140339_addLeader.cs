using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Church.API.Migrations
{
    /// <inheritdoc />
    public partial class addLeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leader",
                schema: "backoffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CongregationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EndDate = table.Column<DateTime>(type: "Datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "NVARCHAR(180)", maxLength: 180, nullable: true),
                    StartDate = table.Column<DateTime>(type: "Datetime", nullable: false),
                    TrackerCreatedAt = table.Column<DateTime>(name: "Tracker_CreatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerUpdatedAt = table.Column<DateTime>(name: "Tracker_UpdatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerNotes = table.Column<string>(name: "Tracker_Notes", type: "NVARCHAR(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leader_Congregation_CongregationId",
                        column: x => x.CongregationId,
                        principalSchema: "backoffice",
                        principalTable: "Congregation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Leader_Member_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "backoffice",
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leader_CongregationId",
                schema: "backoffice",
                table: "Leader",
                column: "CongregationId");

            migrationBuilder.CreateIndex(
                name: "IX_Leader_MemberId",
                schema: "backoffice",
                table: "Leader",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leader",
                schema: "backoffice");
        }
    }
}
