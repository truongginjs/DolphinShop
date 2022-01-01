using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class seedfakedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "UpdatedDate", "UserCreateId", "UserUpdateId" },
                values: new object[] { 2, new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765), "user", false, "user", new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765), 0, 0 });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "UpdatedDate", "UserCreateId", "UserUpdateId" },
                values: new object[] { 1, new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765), "admin", false, "admin", new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765), 0, 0 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CommentId", "CreatedDate", "Description", "Email", "Fullname", "Gender", "IsDeleted", "Password", "PhoneNumber", "RoleId", "TagId", "UpdatedDate", "UserCreateId", "UserUpdateId", "Username" },
                values: new object[] { 1, null, new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765), "user", "admin@domain", "admin", "Male", false, "$2a$12$MGa6ScF63rYWdXAnnyY6QetDfkefN6in0g0OfHdf8idMOTr85HtkS", "190000000", 1, null, new DateTime(2022, 1, 1, 12, 2, 12, 233, DateTimeKind.Local).AddTicks(5765), 0, 0, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
