using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Banking2.Migrations
{
    /// <inheritdoc />
    public partial class yh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_customers_AddressId",
                table: "customers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_CustomerId",
                table: "accounts",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_customers_CustomerId",
                table: "accounts",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_addresses_AddressId",
                table: "customers",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_customers_CustomerId",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_customers_addresses_AddressId",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_AddressId",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_accounts_CustomerId",
                table: "accounts");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "accounts");
        }
    }
}
