using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveriesCompany.Data.Migrations
{
    public partial class EFMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sending_CompanyId",
                table: "Sending",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sending_DeliveryManId",
                table: "Sending",
                column: "DeliveryManId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_AgreementId",
                table: "Company",
                column: "AgreementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Agreement_AgreementId",
                table: "Company",
                column: "AgreementId",
                principalTable: "Agreement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sending_Company_CompanyId",
                table: "Sending",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sending_DeliveryMan_DeliveryManId",
                table: "Sending",
                column: "DeliveryManId",
                principalTable: "DeliveryMan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Agreement_AgreementId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Sending_Company_CompanyId",
                table: "Sending");

            migrationBuilder.DropForeignKey(
                name: "FK_Sending_DeliveryMan_DeliveryManId",
                table: "Sending");

            migrationBuilder.DropIndex(
                name: "IX_Sending_CompanyId",
                table: "Sending");

            migrationBuilder.DropIndex(
                name: "IX_Sending_DeliveryManId",
                table: "Sending");

            migrationBuilder.DropIndex(
                name: "IX_Company_AgreementId",
                table: "Company");
        }
    }
}
