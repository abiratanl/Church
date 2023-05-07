using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Church.API.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "backoffice");

            migrationBuilder.CreateTable(
                name: "BlackList",
                schema: "backoffice",
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
                schema: "backoffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZipCode = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    Street = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    Number = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    Complement = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    District = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    City = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    State = table.Column<string>(type: "NVARCHAR(2)", maxLength: 2, nullable: false),
                    Country = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    EndDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    FundationDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: true),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    TrackerCreatedAt = table.Column<DateTime>(name: "Tracker_CreatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerUpdatedAt = table.Column<DateTime>(name: "Tracker_UpdatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerNotes = table.Column<string>(name: "Tracker_Notes", type: "NVARCHAR(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Congregation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Newsletter",
                schema: "backoffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventDescription = table.Column<string>(type: "NVARCHAR(180)", maxLength: 180, nullable: false),
                    EventTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EventLocal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    EndDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "backoffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressZipCode = table.Column<string>(name: "Address_ZipCode", type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    AddressStreet = table.Column<string>(name: "Address_Street", type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    AddressNumber = table.Column<string>(name: "Address_Number", type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    AddressComplement = table.Column<string>(name: "Address_Complement", type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    AddressDistrict = table.Column<string>(name: "Address_District", type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    AddressCity = table.Column<string>(name: "Address_City", type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    AddressState = table.Column<string>(name: "Address_State", type: "NVARCHAR(2)", maxLength: 2, nullable: false),
                    AddressCountry = table.Column<string>(name: "Address_Country", type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    AddressCode = table.Column<string>(name: "Address_Code", type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    AddressNotes = table.Column<string>(name: "Address_Notes", type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    Citizenship = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: true),
                    Gender = table.Column<int>(type: "INT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NameFirstName = table.Column<string>(name: "Name_FirstName", type: "NVARCHAR(60)", maxLength: 60, nullable: false),
                    NameLastName = table.Column<string>(name: "Name_LastName", type: "NVARCHAR(60)", maxLength: 60, nullable: false),
                    Nationality = table.Column<string>(type: "NVARCHAR(160)", maxLength: 160, nullable: false),
                    Obs = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    PhoneFullNumber = table.Column<string>(name: "Phone_FullNumber", type: "VARCHAR(16)", maxLength: 16, nullable: true),
                    PhoneVerificationIsVerified = table.Column<bool>(name: "Phone_Verification_IsVerified", type: "BIT", nullable: true),
                    PhoneVerificationCode = table.Column<string>(name: "Phone_Verification_Code", type: "CHAR(6)", maxLength: 6, nullable: true),
                    PhoneVerificationCodeExpireDate = table.Column<DateTime>(name: "Phone_Verification_CodeExpireDate", type: "DATETIME2", nullable: true),
                    Photo = table.Column<string>(type: "NVARCHAR", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                schema: "backoffice",
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
                schema: "backoffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentNumber = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    DocumentType = table.Column<int>(type: "INT", nullable: false, defaultValue: 2),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrackerCreatedAt = table.Column<DateTime>(name: "Tracker_CreatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerUpdatedAt = table.Column<DateTime>(name: "Tracker_UpdatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerNotes = table.Column<string>(name: "Tracker_Notes", type: "NVARCHAR(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "backoffice",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                schema: "backoffice",
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
                        principalSchema: "backoffice",
                        principalTable: "Congregation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Member_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "backoffice",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "backoffice",
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
                        principalSchema: "backoffice",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "backoffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactType = table.Column<byte>(type: "TINYINT", nullable: false),
                    CongregationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "NVARCHAR(180)", maxLength: 180, nullable: false),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrackerCreatedAt = table.Column<DateTime>(name: "Tracker_CreatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerUpdatedAt = table.Column<DateTime>(name: "Tracker_UpdatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerNotes = table.Column<string>(name: "Tracker_Notes", type: "NVARCHAR(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Congregation_CongregationId",
                        column: x => x.CongregationId,
                        principalSchema: "backoffice",
                        principalTable: "Congregation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contact_Member_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "backoffice",
                        principalTable: "Member",
                        principalColumn: "Id");
                });

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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leader_Member_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "backoffice",
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Occurrence",
                schema: "backoffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OccurrenceDate = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    OccurrenceType = table.Column<byte>(type: "TINYINT", nullable: false),
                    Notes = table.Column<string>(type: "NVARCHAR(200)", maxLength: 200, nullable: false),
                    TrackerCreatedAt = table.Column<DateTime>(name: "Tracker_CreatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerUpdatedAt = table.Column<DateTime>(name: "Tracker_UpdatedAt", type: "SMALLDATETIME", nullable: false),
                    TrackerNotes = table.Column<string>(name: "Tracker_Notes", type: "NVARCHAR(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occurrence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Occurrence_Member_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "backoffice",
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "backoffice",
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
                        principalSchema: "backoffice",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "backoffice",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CongregationId",
                schema: "backoffice",
                table: "Contact",
                column: "CongregationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_MemberId",
                schema: "backoffice",
                table: "Contact",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_PersonId",
                schema: "backoffice",
                table: "Document",
                column: "PersonId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Member_CongregationId",
                schema: "backoffice",
                table: "Member",
                column: "CongregationId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_PersonId",
                schema: "backoffice",
                table: "Member",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Occurrence_MemberId",
                schema: "backoffice",
                table: "Occurrence",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonId",
                schema: "backoffice",
                table: "User",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "backoffice",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                schema: "backoffice",
                table: "UserRole",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlackList",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "Contact",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "Document",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "Leader",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "Newsletter",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "Occurrence",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "Member",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "User",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "Congregation",
                schema: "backoffice");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "backoffice");
        }
    }
}
