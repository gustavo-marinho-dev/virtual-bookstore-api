using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualBookstore.Infrastructure.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Address",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        City = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        State = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Latitude = table.Column<long>(type: "bigint", nullable: false),
            //        Longitude = table.Column<long>(type: "bigint", nullable: false),
            //        BuildingNumber = table.Column<int>(type: "int", nullable: false),
            //        CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Address", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "varchar(255)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationality = table.Column<string>(type: "varchar(50)", nullable: false),
                    Biography = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "varchar(255)", nullable: false),
                    PublicationYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Publisher = table.Column<string>(type: "varchar(255)", nullable: false),
                    Subject = table.Column<string>(type: "varchar(50)", nullable: false),
                    Categorie = table.Column<string>(type: "varchar(50)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Synopsis = table.Column<string>(type: "varchar(50)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "varchar(255)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Backing = table.Column<string>(type: "varchar(50)", nullable: false),
                    Dimensions = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Customer",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Customer", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Stock",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AdressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        IsAvailable = table.Column<bool>(type: "bit", nullable: false),
            //        CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Stock", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Stock_Address_AddressId",
            //            column: x => x.AddressId,
            //            principalTable: "Address",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "AddressCustomer",
            //    columns: table => new
            //    {
            //        AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AddressCustomer", x => new { x.AddressId, x.CustomersId });
            //        table.ForeignKey(
            //            name: "FK_AddressCustomer_Address_AddressId",
            //            column: x => x.AddressId,
            //            principalTable: "Address",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AddressCustomer_Customer_CustomersId",
            //            column: x => x.CustomersId,
            //            principalTable: "Customer",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cart",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ShippingCost = table.Column<double>(type: "float", nullable: false),
            //        TaxAmount = table.Column<double>(type: "float", nullable: false),
            //        CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cart", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Cart_Customer_CustomerId",
            //            column: x => x.CustomerId,
            //            principalTable: "Customer",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Order",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Subtotal = table.Column<double>(type: "float", nullable: false),
            //        Tax = table.Column<double>(type: "float", nullable: false),
            //        Total = table.Column<double>(type: "float", nullable: false),
            //        ShipType = table.Column<int>(type: "int", nullable: false),
            //        ShipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Status = table.Column<int>(type: "int", nullable: false),
            //        BillingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ShippingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Order", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Order_Address_BillingAddressId",
            //            column: x => x.BillingAddressId,
            //            principalTable: "Address",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Order_Address_ShippingAddressId",
            //            column: x => x.ShippingAddressId,
            //            principalTable: "Address",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Order_Customer_CustomerId",
            //            column: x => x.CustomerId,
            //            principalTable: "Customer",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "StockItem",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Quantity = table.Column<int>(type: "int", nullable: false),
            //        Cost = table.Column<double>(type: "float", nullable: false),
            //        CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_StockItem", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_StockItem_Book_BookId",
            //            column: x => x.BookId,
            //            principalTable: "Book",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_StockItem_Stock_StockId",
            //            column: x => x.StockId,
            //            principalTable: "Stock",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CartItem",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        StockItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Quantity = table.Column<int>(type: "int", nullable: false),
            //        CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CartItem", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CartItem_Cart_CartId",
            //            column: x => x.CartId,
            //            principalTable: "Cart",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_CartItem_StockItem_StockItemId",
            //            column: x => x.StockItemId,
            //            principalTable: "StockItem",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OrderItem",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        StockItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Quantity = table.Column<int>(type: "int", nullable: false),
            //        Discount = table.Column<double>(type: "float", nullable: false),
            //        Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderItem", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_OrderItem_Order_OrderId",
            //            column: x => x.OrderId,
            //            principalTable: "Order",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_OrderItem_StockItem_StockItemId",
            //            column: x => x.StockItemId,
            //            principalTable: "StockItem",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AddressCustomer_CustomersId",
            //    table: "AddressCustomer",
            //    column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor",
                column: "BookId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cart_CustomerId",
            //    table: "Cart",
            //    column: "CustomerId",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_CartItem_CartId",
            //    table: "CartItem",
            //    column: "CartId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CartItem_StockItemId",
            //    table: "CartItem",
            //    column: "StockItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Order_BillingAddressId",
            //    table: "Order",
            //    column: "BillingAddressId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Order_CustomerId",
            //    table: "Order",
            //    column: "CustomerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Order_ShippingAddressId",
            //    table: "Order",
            //    column: "ShippingAddressId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_OrderId",
            //    table: "OrderItem",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_StockItemId",
            //    table: "OrderItem",
            //    column: "StockItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Stock_AddressId",
            //    table: "Stock",
            //    column: "AddressId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StockItem_BookId",
            //    table: "StockItem",
            //    column: "BookId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StockItem_StockId",
            //    table: "StockItem",
            //    column: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "AddressCustomer");

            migrationBuilder.DropTable(
                name: "BookAuthor");

            //migrationBuilder.DropTable(
            //    name: "CartItem");

            //migrationBuilder.DropTable(
            //    name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Author");

            //migrationBuilder.DropTable(
            //    name: "Cart");

            //migrationBuilder.DropTable(
            //    name: "Order");

            //migrationBuilder.DropTable(
            //    name: "StockItem");

            //migrationBuilder.DropTable(
            //    name: "Customer");

            migrationBuilder.DropTable(
                name: "Book");

            //migrationBuilder.DropTable(
            //    name: "Stock");

            //migrationBuilder.DropTable(
            //    name: "Address");
        }
    }
}
