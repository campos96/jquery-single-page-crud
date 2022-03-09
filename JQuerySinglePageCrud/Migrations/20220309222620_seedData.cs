using Microsoft.EntityFrameworkCore.Migrations;

namespace JQuerySinglePageCrud.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Active", "Email", "FirstName", "LastName", "Location", "Password", "PasswordSalt", "Phone", "Username" },
                values: new object[,]
                {
                    { 1, true, "johndoe@mail.com", "John", "Doe", null, null, null, null, "johndoe" },
                    { 2, true, "janedoe@mail.com", "Jane", "Doe", null, null, null, null, "janedoe" },
                    { 3, true, "johnroe@mail.com", "John", "Roe", null, null, null, null, "johnroe" },
                    { 4, true, "richardroe@mail.com", "Richard", "Roe", null, null, null, null, "richardroe" },
                    { 5, true, "janeroe@mail.com", "Jane", "Roe", null, null, null, null, "janeroe" },
                    { 6, true, "babydoe@mail.com", "Baby", "Doe", null, null, null, null, "babydoe" },
                    { 7, true, "janedoe@mail.com", "Janie", "Doe", null, null, null, null, "janiedoe" },
                    { 8, true, "jhonnydoe@mail.com", "Jhonny", "Doe", null, null, null, null, "jhonnydoe" },
                    { 9, true, "joebloggs@mail.com", "Joe", "Bloggs", null, null, null, null, "joebloggs" },
                    { 10, true, "janesmith@mail.com", "Jane", "Smith", null, null, null, null, "janesmith" },
                    { 11, true, "joeschmoe@mail.com", "Joe", "Schmoe", null, null, null, null, "joeschmoe" },
                    { 12, true, "tomdoe@mail.com", "Tom", "Doe", null, null, null, null, "tomdoe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 12);
        }
    }
}
