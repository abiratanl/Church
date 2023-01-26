using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Church.API.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "adm");

            migrationBuilder.CreateTable(
                name: "BlackList",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(120)", maxLength: 120, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Congregation",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    Complement = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    Country = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    District = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    Number = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    State = table.Column<string>(type: "NVARCHAR(2)", maxLength: 2, nullable: false),
                    Street = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    ZipCode = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    FundationDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    Leader = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    LeaderExchangeDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Congregation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    Code = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    Complement = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    Country = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true, defaultValue: "BR"),
                    District = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    Notes = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    Number = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    State = table.Column<string>(type: "NVARCHAR(2)", maxLength: 2, nullable: false),
                    Street = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    ZipCode = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    Citizenship = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    FatherName = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    Gender = table.Column<int>(type: "INT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MotherName = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: false),
                    Nationality = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    Obs = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    PhoneFullNumber = table.Column<string>(name: "Phone_FullNumber", type: "VARCHAR(16)", maxLength: 16, nullable: true),
                    PhoneVerificationIsVerified = table.Column<bool>(name: "Phone_Verification_IsVerified", type: "BIT", nullable: true),
                    PhoneVerificationCode = table.Column<string>(name: "Phone_Verification_Code", type: "CHAR(6)", maxLength: 6, nullable: true),
                    PhoneVerificationCodeExpireDate = table.Column<DateTime>(name: "Phone_Verification_CodeExpireDate", type: "DATETIME2", nullable: true),
                    Photo = table.Column<string>(type: "NVARCHAR", nullable: true),
                    TrackerCreatedAt = table.Column<DateTime>(name: "Tracker_CreatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerUpdatedAt = table.Column<DateTime>(name: "Tracker_UpdatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerNotes = table.Column<string>(name: "Tracker_Notes", type: "NVARCHAR(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                schema: "adm",
                columns: table => new
                {
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => new { x.PersonId, x.Id });
                    table.ForeignKey(
                        name: "FK_Document_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "adm",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CongregationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    IsBaptizedHolySpirit = table.Column<bool>(type: "BIT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    MaritalStatus = table.Column<byte>(type: "TINYINT", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<byte>(type: "TINYINT", nullable: false),
                    SpouseIsBeliever = table.Column<bool>(type: "BIT", nullable: true),
                    SpouseName = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    Status = table.Column<byte>(type: "TINYINT", nullable: false),
                    TrackerCreatedAt = table.Column<DateTime>(name: "Tracker_CreatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerUpdatedAt = table.Column<DateTime>(name: "Tracker_UpdatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerNotes = table.Column<string>(name: "Tracker_Notes", type: "NVARCHAR(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Congregation_CongregationId",
                        column: x => x.CongregationId,
                        principalSchema: "adm",
                        principalTable: "Congregation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Member_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "adm",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(120)", maxLength: 120, nullable: false),
                    EmailVerified = table.Column<bool>(type: "BIT", nullable: false),
                    EmailVerificationCode = table.Column<string>(type: "CHAR(8)", maxLength: 8, nullable: false),
                    EmailVerificationCodeExpireDate = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    PasswordHash = table.Column<string>(name: "Password_Hash", type: "VARCHAR(120)", maxLength: 120, nullable: false),
                    PasswordExpired = table.Column<bool>(name: "Password_Expired", type: "BIT", nullable: false),
                    TrackerCreatedAt = table.Column<DateTime>(name: "Tracker_CreatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerUpdatedAt = table.Column<DateTime>(name: "Tracker_UpdatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerNotes = table.Column<string>(name: "Tracker_Notes", type: "NVARCHAR(1024)", maxLength: 1024, nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "adm",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "adm",
                columns: table => new
                {
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => new { x.MemberId, x.Id });
                    table.ForeignKey(
                        name: "FK_Contact_Member_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "adm",
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Occurrence",
                schema: "adm",
                columns: table => new
                {
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccurrenceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OccurrenceType = table.Column<byte>(type: "tinyint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occurrence", x => new { x.MemberId, x.Id });
                    table.ForeignKey(
                        name: "FK_Occurrence_Member_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "adm",
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    UserId = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: true),
                    EndDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "adm",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "adm",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Member_CongregationId",
                schema: "adm",
                table: "Member",
                column: "CongregationId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_PersonId",
                schema: "adm",
                table: "Member",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonId",
                schema: "adm",
                table: "User",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "adm",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                schema: "adm",
                table: "UserRole",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlackList",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Contact",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Document",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Occurrence",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Member",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "User",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Congregation",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "adm");
        }
    }
}
