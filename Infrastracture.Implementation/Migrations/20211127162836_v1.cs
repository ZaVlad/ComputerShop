using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MsSql.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "GoodsType",
                columns: table => new
                {
                    GoodsTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsType", x => x.GoodsTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Guarantee",
                columns: table => new
                {
                    GuaranteeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantee", x => x.GuaranteeId);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType = table.Column<int>(type: "int", nullable: false),
                    Allowed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    ShipperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipper", x => x.ShipperId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    PaymentType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCode",
                columns: table => new
                {
                    ProductCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoodsTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCode", x => x.ProductCodeId);
                    table.ForeignKey(
                        name: "FK_ProductCode_GoodsType_GoodsTypeId",
                        column: x => x.GoodsTypeId,
                        principalTable: "GoodsType",
                        principalColumn: "GoodsTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipperId = table.Column<int>(type: "int", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Shipper_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "ShipperId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    ComputerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    ProcessorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoCardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuaranteeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firm = table.Column<int>(type: "int", nullable: false),
                    ProductCodeId = table.Column<int>(type: "int", nullable: false),
                    GoodsTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computer", x => x.ComputerId);
                    table.ForeignKey(
                        name: "FK_Computer_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_GoodsType_GoodsTypeId",
                        column: x => x.GoodsTypeId,
                        principalTable: "GoodsType",
                        principalColumn: "GoodsTypeId");
                    table.ForeignKey(
                        name: "FK_Computer_Guarantee_GuaranteeId",
                        column: x => x.GuaranteeId,
                        principalTable: "Guarantee",
                        principalColumn: "GuaranteeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_ProductCode_ProductCodeId",
                        column: x => x.ProductCodeId,
                        principalTable: "ProductCode",
                        principalColumn: "ProductCodeId");
                    table.ForeignKey(
                        name: "FK_Computer_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repair",
                columns: table => new
                {
                    RepairId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HaveGuarantee = table.Column<bool>(type: "bit", nullable: false),
                    ProductCodeId = table.Column<int>(type: "int", nullable: false),
                    RepairStage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repair", x => x.RepairId);
                    table.ForeignKey(
                        name: "FK_Repair_ProductCode_ProductCodeId",
                        column: x => x.ProductCodeId,
                        principalTable: "ProductCode",
                        principalColumn: "ProductCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductCodeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    BillDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_ProductCode_ProductCodeId",
                        column: x => x.ProductCodeId,
                        principalTable: "ProductCode",
                        principalColumn: "ProductCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Active", "Description", "Name" },
                values: new object[,]
                {
                    { 1, true, "Some words", "IT" },
                    { 2, false, "Some words", "Business" },
                    { 3, true, "Some words", "Cartoon" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Adress", "BillingCity", "BillingCountry", "City", "DateEntered", "Email", "FirstName", "LastName", "Phone", "ShipCountry", "ShipRegion" },
                values: new object[,]
                {
                    { 1, "Street1", "City1", "Ukraine", "City1", new DateTime(2021, 11, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(7806), "Email1@gmail.com1", "Example1", "LastExample1", "380500653293", "Country 1", "Region 1" },
                    { 2, "Street2", "City2", "Ukraine", "City2", new DateTime(2021, 11, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(9123), "Email2@gmail.com1", "Example2", "LastExample2", "380500653293", "Country 2", "Region 2" },
                    { 3, "Street3", "City3", "Ukraine", "City3", new DateTime(2021, 11, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(9134), "Email3@gmail.com1", "Example3", "LastExample3", "380500653293", "Country 3", "Region 3" }
                });

            migrationBuilder.InsertData(
                table: "GoodsType",
                columns: new[] { "GoodsTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Computer" },
                    { 2, "Example2" },
                    { 3, "Example3" }
                });

            migrationBuilder.InsertData(
                table: "Guarantee",
                columns: new[] { "GuaranteeId", "ExpireDate" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 2, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(2969) },
                    { 1, new DateTime(2022, 5, 27, 18, 28, 36, 412, DateTimeKind.Local).AddTicks(4872) },
                    { 2, new DateTime(2022, 1, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(2945) }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "PaymentId", "Allowed", "PaymentType" },
                values: new object[,]
                {
                    { 1, true, 2 },
                    { 2, true, 2 },
                    { 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "Shipper",
                columns: new[] { "ShipperId", "CompanyName", "Phone" },
                values: new object[,]
                {
                    { 1, "Apple", "380500653293" },
                    { 2, "Samsung", "380500653293" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "Adress", "City", "Country", "Email", "Name", "PaymentType", "Phone" },
                values: new object[,]
                {
                    { 2, "Example Adress2", "Example City2", "Example Country 2", "Email2@gmail.com1", "SomeSupplier2", 2, "380500653293" },
                    { 1, "Example Adress1", "Example City1", "Example Country 1", "Email1@gmail.com1", "SomeSupplier1", 1, "380500653293" },
                    { 3, "Example Adress3", "Example City3", "Example Country 3", "Email3@gmail.com1", "SomeSupplier3", 1, "380500653293" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "CustomerId", "DeliveryStatus", "OrderDate", "Paid", "PaymentDate", "PaymentId", "ShipDate", "ShipperId" },
                values: new object[,]
                {
                    { 1, 1, 3, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(2306), true, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3060), 1, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3274), 1 },
                    { 3, 3, 1, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3683), true, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3685), 2, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3687), 1 },
                    { 2, 2, 0, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3670), true, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3678), 3, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3681), 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCode",
                columns: new[] { "ProductCodeId", "Code", "GoodsTypeId" },
                values: new object[,]
                {
                    { 1, new Guid("5f1f64d5-e778-402a-874b-8c33e650b325"), 1 },
                    { 2, new Guid("9233e78f-820b-4d5f-97b1-68497b3c529d"), 1 },
                    { 3, new Guid("ae8f5413-0f3d-4079-a533-c6688a7e1b0a"), 1 },
                    { 4, new Guid("4a6f03b9-1dd0-4b47-892c-f0436f1abb3c"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Computer",
                columns: new[] { "ComputerId", "CategoryId", "Color", "Description", "Discount", "Firm", "GoodsTypeId", "GuaranteeId", "Name", "ProcessorName", "ProductCodeId", "SupplierId", "VideoCardName" },
                values: new object[,]
                {
                    { 1, 1, "Red", "Some words", 23, 0, 1, 1, null, "Some Processor 1", 1, 1, "Some VideoCard 1" },
                    { 2, 1, "Blue", "Some words", 0, 1, 1, 2, null, "Some Processor 2", 2, 2, "Some VideoCard 2" },
                    { 3, 1, "Green", "Some words", 25, 1, 1, 1, null, "Some Processor 3", 3, 3, "Some VideoCard 3" },
                    { 4, 1, "Yellow", "Some words", 80, 0, 1, 3, null, "Some Processor 4", 4, 1, "Some VideoCard 4" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailId", "BillDate", "Discount", "OrderId", "Price", "ProductCodeId", "Quantity", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(4489), 25, 1, 4005m, 1, 3, 12015 },
                    { 3, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(5948), 15, 3, 6000m, 3, 5, 30000 },
                    { 2, new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(5938), 10, 2, 1000m, 2, 2, 2000 }
                });

            migrationBuilder.InsertData(
                table: "Repair",
                columns: new[] { "RepairId", "HaveGuarantee", "Price", "ProductCodeId", "RepairStage" },
                values: new object[,]
                {
                    { 1, true, 4000m, 1, 0 },
                    { 2, false, 2000m, 2, 0 },
                    { 3, true, 1000m, 3, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Computer_CategoryId",
                table: "Computer",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_GoodsTypeId",
                table: "Computer",
                column: "GoodsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_GuaranteeId",
                table: "Computer",
                column: "GuaranteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_ProductCodeId",
                table: "Computer",
                column: "ProductCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_SupplierId",
                table: "Computer",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentId",
                table: "Order",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShipperId",
                table: "Order",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductCodeId",
                table: "OrderDetail",
                column: "ProductCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCode_GoodsTypeId",
                table: "ProductCode",
                column: "GoodsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_ProductCodeId",
                table: "Repair",
                column: "ProductCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computer");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Repair");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Guarantee");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ProductCode");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.DropTable(
                name: "GoodsType");
        }
    }
}
