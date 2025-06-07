using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolokwium.Migrations
{
    /// <inheritdoc />
    public partial class addedexampledata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "IdClient", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, "John", "Doe", "08888888888" });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "IdSubscription", "EndDate", "Name", "Price", "RenewalPeriod" },
                values: new object[] { 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Subscription1", 80.0, 8 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "IdSale", "CreatedAt", "IdClient", "IdSubscription" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "IdSale",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "IdClient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "IdSubscription",
                keyValue: 1);
        }
    }
}
