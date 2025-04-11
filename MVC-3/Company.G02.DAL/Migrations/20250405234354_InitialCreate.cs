using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Company.G02.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E11E65D8-18C4-493F-AF19-4A3B80F8AC01");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C4D17A15-B5A6-41BD-9B6E-B10F86CB48EE", "4EA19E03-C84D-453C-A6B2-CF3A9981F594" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C4D17A15-B5A6-41BD-9B6E-B10F86CB48EE");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4EA19E03-C84D-453C-A6B2-CF3A9981F594");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42985960-DEC0-4611-A26F-FEE23079388E", null, "Admin", "ADMIN" },
                    { "5F701205-7E32-42EF-B43E-AD0B42B31FC8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAgree", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1225AE25-67AD-4AE0-8EBF-1DC351BC6242", 0, "cc74ef42-74bc-4a35-aae2-6549b42eb7a4", "nadaeissa13@gmail.com", false, "Nada", false, "Eissa", false, null, null, null, "AQAAAAIAAYagAAAAELZnUbgx/1RPw/U9iCCKRv27vQ4owDdVya5/jucC/Ei22GEeP+uF+ibKXqqx/FJ90A==", null, false, "2f59b7dd-fd83-43db-8c3d-e361c75a5a94", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "42985960-DEC0-4611-A26F-FEE23079388E", "1225AE25-67AD-4AE0-8EBF-1DC351BC6242" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5F701205-7E32-42EF-B43E-AD0B42B31FC8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "42985960-DEC0-4611-A26F-FEE23079388E", "1225AE25-67AD-4AE0-8EBF-1DC351BC6242" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42985960-DEC0-4611-A26F-FEE23079388E");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1225AE25-67AD-4AE0-8EBF-1DC351BC6242");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "C4D17A15-B5A6-41BD-9B6E-B10F86CB48EE", null, "Admin", "ADMIN" },
                    { "E11E65D8-18C4-493F-AF19-4A3B80F8AC01", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAgree", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4EA19E03-C84D-453C-A6B2-CF3A9981F594", 0, "bc2e710e-766c-4054-9e69-9b4cb6c8be46", "malakelsayyad@gmail.com", false, "malak", false, "elsayyad", false, null, null, null, "AQAAAAIAAYagAAAAEJC2O18ue5iizJSCG18MKdJMBf1b2cGgFrYrJC0QVLYATSg4xvQUCqxHSZCqIPeMiQ==", null, false, "b10f35f2-d117-4dd1-8757-102e8af66a3b", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "C4D17A15-B5A6-41BD-9B6E-B10F86CB48EE", "4EA19E03-C84D-453C-A6B2-CF3A9981F594" });
        }
    }
}
