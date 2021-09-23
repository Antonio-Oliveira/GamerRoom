using Microsoft.EntityFrameworkCore.Migrations;

namespace GamerRoom.API.Data.Migrations
{
    public partial class PopulerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode, ReleaseDate) VALUES('aaf33b90-1e24-47ae-a4a6-c22d30fbce54','Free Fire', 'Free Fire[a] é um jogo eletrônico mobile de ação-aventura do gênero battle royale, criado pela desenvolvedora vietnamita 111dots Studio e publicado pela Garena.[2] O jogo obteve um beta aberto em novembro de 2017 e foi lançado oficialmente para Android de iOS em 4 de dezembro de 2017.','111dots Studio','Garena','Android;iOS','battle royale','Multijogador','0001-01-01 00:00:00.0000000')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TB_GAMES");
        }
    }
}
