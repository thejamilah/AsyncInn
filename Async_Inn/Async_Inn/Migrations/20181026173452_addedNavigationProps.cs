using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn.Migrations
{
    public partial class addedNavigationProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_RoomAmenities_AmenitiesID",
                table: "RoomAmenities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "HotelRooms");

            migrationBuilder.AddColumn<int>(
                name: "RoomAmenityAmenitiesID",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomAmenityRoomID",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HotelID",
                table: "HotelRooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomID1",
                table: "HotelRooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomAmenitiesAmenitiesID",
                table: "Amenities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomAmenitiesRoomID",
                table: "Amenities",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms",
                columns: new[] { "HotelID", "RoomNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomAmenityAmenitiesID_RoomAmenityRoomID",
                table: "Rooms",
                columns: new[] { "RoomAmenityAmenitiesID", "RoomAmenityRoomID" });

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomID1",
                table: "HotelRooms",
                column: "RoomID1");

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_RoomAmenitiesAmenitiesID_RoomAmenitiesRoomID",
                table: "Amenities",
                columns: new[] { "RoomAmenitiesAmenitiesID", "RoomAmenitiesRoomID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_RoomAmenities_RoomAmenitiesAmenitiesID_RoomAmenitiesRoomID",
                table: "Amenities",
                columns: new[] { "RoomAmenitiesAmenitiesID", "RoomAmenitiesRoomID" },
                principalTable: "RoomAmenities",
                principalColumns: new[] { "AmenitiesID", "RoomID" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Hotel_HotelID",
                table: "HotelRooms",
                column: "HotelID",
                principalTable: "Hotel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID1",
                table: "HotelRooms",
                column: "RoomID1",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomAmenities_RoomAmenityAmenitiesID_RoomAmenityRoomID",
                table: "Rooms",
                columns: new[] { "RoomAmenityAmenitiesID", "RoomAmenityRoomID" },
                principalTable: "RoomAmenities",
                principalColumns: new[] { "AmenitiesID", "RoomID" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_RoomAmenities_RoomAmenitiesAmenitiesID_RoomAmenitiesRoomID",
                table: "Amenities");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Hotel_HotelID",
                table: "HotelRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID1",
                table: "HotelRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomAmenities_RoomAmenityAmenitiesID_RoomAmenityRoomID",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomAmenityAmenitiesID_RoomAmenityRoomID",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_RoomID1",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_Amenities_RoomAmenitiesAmenitiesID_RoomAmenitiesRoomID",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "RoomAmenityAmenitiesID",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomAmenityRoomID",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "HotelID",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "RoomID1",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "RoomAmenitiesAmenitiesID",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "RoomAmenitiesRoomID",
                table: "Amenities");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "HotelRooms",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_RoomAmenities_AmenitiesID",
                table: "RoomAmenities",
                column: "AmenitiesID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms",
                column: "ID");
        }
    }
}
