using Microsoft.EntityFrameworkCore.Migrations;

namespace GamerRoom.API.Data.Migrations
{
    public partial class PopulerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('aaf33b90-1e24-47ae-a4a6-c22d30fbce54','Free Fire', 'sdsdl~sdçs','Garena')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TB_GAMES");
        }
    }
}
