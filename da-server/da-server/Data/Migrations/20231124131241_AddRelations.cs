using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace da_server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "User_id",
                table: "Profiles",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "Local_number",
                table: "Profiles",
                newName: "LocalNumber");

            migrationBuilder.RenameColumn(
                name: "Last_name",
                table: "Profiles",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "First_name",
                table: "Profiles",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "Edited_at",
                table: "Profiles",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Profiles",
                newName: "EditedAt");

            migrationBuilder.RenameColumn(
                name: "Address_number",
                table: "Profiles",
                newName: "AddressNumber");

            migrationBuilder.RenameColumn(
                name: "User_id",
                table: "Matches",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Matched_id",
                table: "Matches",
                newName: "MatchedId");

            migrationBuilder.RenameColumn(
                name: "Created_ad",
                table: "Matches",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Matches",
                newName: "MatchId");

            migrationBuilder.AddColumn<string>(
                name: "CreatedAt",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Profiles",
                newName: "Last_name");

            migrationBuilder.RenameColumn(
                name: "LocalNumber",
                table: "Profiles",
                newName: "Local_number");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Profiles",
                newName: "First_name");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Profiles",
                newName: "Edited_at");

            migrationBuilder.RenameColumn(
                name: "EditedAt",
                table: "Profiles",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "AddressNumber",
                table: "Profiles",
                newName: "Address_number");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Profiles",
                newName: "User_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Matches",
                newName: "User_id");

            migrationBuilder.RenameColumn(
                name: "MatchedId",
                table: "Matches",
                newName: "Matched_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Matches",
                newName: "Created_ad");

            migrationBuilder.RenameColumn(
                name: "MatchId",
                table: "Matches",
                newName: "Id");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Profiles",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Id");
        }
    }
}
