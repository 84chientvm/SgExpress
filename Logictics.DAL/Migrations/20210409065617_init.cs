using Microsoft.EntityFrameworkCore.Migrations;

namespace Logictics.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CreateDate = table.Column<double>(nullable: true),
                    ModifyDate = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    StoreId = table.Column<string>(nullable: true),
                    StoreName = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<double>(nullable: true),
                    ModifyDate = table.Column<double>(nullable: true),
                    SenderId = table.Column<string>(nullable: true),
                    SenderAddress = table.Column<string>(nullable: true),
                    SenderPhone = table.Column<string>(nullable: true),
                    SenderFullName = table.Column<string>(nullable: true),
                    RecipientId = table.Column<string>(nullable: true),
                    RecipientFullName = table.Column<string>(nullable: true),
                    RecipientAddress = table.Column<string>(nullable: true),
                    RecipientPhone = table.Column<string>(nullable: true),
                    CustomerConfirmId = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Shipment = table.Column<string>(nullable: true),
                    PickupDate = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    productCategoryId = table.Column<string>(nullable: true),
                    productCategoryName = table.Column<string>(nullable: true),
                    productCode = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    quality = table.Column<int>(nullable: true),
                    weight = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: true),
                    orderId = table.Column<string>(nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    createDate = table.Column<double>(nullable: true),
                    modifyDate = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CreateDate = table.Column<double>(nullable: true),
                    ModifyDate = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    PassWord = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    Role = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<double>(nullable: true),
                    ModifyDate = table.Column<double>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreateDate", "FullName", "ModifyDate", "PassWord", "Phone", "Role", "Status", "UserName" },
                values: new object[] { "69bd714f-9576-45ba-b5b7-f00649be00de", null, null, null, null, "7c4a8d9ca3762af61e59520943dc26494f8941b", null, "ADMIN", "ACTIVE", "admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreateDate", "FullName", "ModifyDate", "PassWord", "Phone", "Role", "Status", "UserName" },
                values: new object[] { "69bd714f-9576-45ba-b5b7-f00649be00df", null, 1.0, null, null, "7c4a8d9ca3762af61e59520943dc26494f8941b", null, "CLIENT", "ACTIVE", "ChienClient" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
