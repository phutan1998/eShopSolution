using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "724a87d1-1ab4-4deb-a06b-dc490f9c67bb");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56b26b32-c2d7-46f6-b370-c6687a7a461c", "AQAAAAEAACcQAAAAEBrdD5d498nNzW6HOBy4uvZQ4InaYD5t5pnYScJGfoRmsTyfrURquCS2IO6oLoNMGg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 25, 21, 54, 52, 184, DateTimeKind.Local).AddTicks(3598));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "cf707b23-1506-4abd-8a8d-bad518b632e1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5fd6369-b62e-4427-8a3f-64f28df4f951", "AQAAAAEAACcQAAAAEBWWLo/4DPQn2F0xxNCSFGoBXAkGbAy1F6ys2rjEhsP4sjjZLyAE215KqloS9L7xGg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 25, 21, 3, 31, 154, DateTimeKind.Local).AddTicks(5009));
        }
    }
}
