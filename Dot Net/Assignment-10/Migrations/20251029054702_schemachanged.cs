using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Banking2.Migrations
{
    /// <inheritdoc />
    public partial class schemachanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_customers_AddressId",
                table: "customers");

            migrationBuilder.CreateIndex(
                name: "IX_customers_AddressId",
                table: "customers",
                column: "AddressId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_customers_AddressId",
                table: "customers");

            migrationBuilder.CreateIndex(
                name: "IX_customers_AddressId",
                table: "customers",
                column: "AddressId");
        }
    }
}
