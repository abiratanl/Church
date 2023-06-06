using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Church.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNewsletter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EventTime",
                schema: "backoffice",
                table: "Newsletter",
                type: "NVARCHAR(180)",
                maxLength: 180,
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                schema: "backoffice",
                table: "Congregation",
                type: "SMALLDATETIME",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EventTime",
                schema: "backoffice",
                table: "Newsletter",
                type: "time",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(180)",
                oldMaxLength: 180);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                schema: "backoffice",
                table: "Congregation",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldNullable: true);
        }
    }
}
