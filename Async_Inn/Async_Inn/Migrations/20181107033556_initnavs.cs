using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn.Migrations
{
    public partial class initnavs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_RoomAmenities_RoomAmenitiesAmenitiesID_RoomAmenitiesRoomID",
                table: "Amenities");

            migrationBuilder.RenameColumn(
                name: "RoomAmenitiesRoomID",
                table: "Amenities",
                newName: "RoomAmenityRoomID");

            migrationBuilder.RenameColumn(
                name: "RoomAmenitiesAmenitiesID",
                table: "Amenities",
                newName: "RoomAmenityAmenitiesID");

            migrationBuilder.RenameIndex(
                name: "IX_Amenities_RoomAmenitiesAmenitiesID_RoomAmenitiesRoomID",
                table: "Amenities",
                newName: "IX_Amenities_RoomAmenityAmenitiesID_RoomAmenityRoomID");

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "Name", "RoomAmenityAmenitiesID", "RoomAmenityRoomID" },
                values: new object[,]
                {
                    { 1, "Coffee Maker", null, null },
                    { 2, "Tea Maker", null, null },
                    { 3, "Craft Cocktail Mini Bar", null, null },
                    { 4, "Free WiFi", null, null },
                    { 5, "Fog Free Mirror", null, null }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "Address", "City", "HotelName", "State", "Zip" },
                values: new object[,]
                {
                    { 2, "123 Elm Street", "Nightmare", "Hotel Babylon", "WA", 98121 },
                    { 3, "1000 Shenanigans Lane", "Seattle", "Polymorphism Manor", "WA", 98101 },
                    { 4, "2000000 Trust Fund St", "Medina", "Inheritance Inn", "WA", 98039 },
                    { 5, "1 Shadow of the Space Needle", "Seattle", "Object Instance Class Inn", "WA", 98101 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Layout", "Name", "RoomAmenityAmenitiesID", "RoomAmenityRoomID" },
                values: new object[,]
                {
                    { 1, 2, "The Million Dollar View", null, null },
                    { 2, 1, "Freddie's Dreamspace", null, null },
                    { 3, 1, "Mesopotamia Suite", null, null },
                    { 4, 0, "The Four OOPs", null, null },
                    { 5, 2, "All Property Behaviors", null, null },
                    { 6, 1, "Seattle Sklyline", null, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_RoomAmenities_RoomAmenityAmenitiesID_RoomAmenityRoomID",
                table: "Amenities",
                columns: new[] { "RoomAmenityAmenitiesID", "RoomAmenityRoomID" },
                principalTable: "RoomAmenities",
                principalColumns: new[] { "AmenitiesID", "RoomID" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_RoomAmenities_RoomAmenityAmenitiesID_RoomAmenityRoomID",
                table: "Amenities");

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.RenameColumn(
                name: "RoomAmenityRoomID",
                table: "Amenities",
                newName: "RoomAmenitiesRoomID");

            migrationBuilder.RenameColumn(
                name: "RoomAmenityAmenitiesID",
                table: "Amenities",
                newName: "RoomAmenitiesAmenitiesID");

            migrationBuilder.RenameIndex(
                name: "IX_Amenities_RoomAmenityAmenitiesID_RoomAmenityRoomID",
                table: "Amenities",
                newName: "IX_Amenities_RoomAmenitiesAmenitiesID_RoomAmenitiesRoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_RoomAmenities_RoomAmenitiesAmenitiesID_RoomAmenitiesRoomID",
                table: "Amenities",
                columns: new[] { "RoomAmenitiesAmenitiesID", "RoomAmenitiesRoomID" },
                principalTable: "RoomAmenities",
                principalColumns: new[] { "AmenitiesID", "RoomID" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
