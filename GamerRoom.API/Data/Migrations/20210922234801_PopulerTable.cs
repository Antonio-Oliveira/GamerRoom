using Microsoft.EntityFrameworkCore.Migrations;

namespace GamerRoom.API.Data.Migrations
{
    public partial class PopulerTable : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('aaf33b90-1e24-47ae-a4a6-c22d30fbce54','Fortnite', 'Fortnite é um jogo eletrônico multijogador online revelado originalmente em 2011, desenvolvido pela Epic Games e lançado como diferentes modos de jogo que compartilham a mesma jogabilidade e motor gráfico de jogo.','Epic Games', 'Epic Games', 'PC; Consoles; Mobile;', 'Battle Royale', 'Multiplayer')");
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('4c5afb21-e651-4110-8b35-157870a1527d','Among Us', 'Among Us é um jogo eletrônico online, dos gêneros jogo em grupo e sobrevivência, desenvolvido e publicado pelo estúdio de jogos estadunidense InnerSloth. Foi lançado em 15 de junho de 2018 para Android e iOS e em 17 de agosto de 2018 para Microsoft Windows.','InnerSloth', 'InnerSloth', 'PC; Consoles; Mobile;', 'Survival', 'Multiplayer')");
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('d01106d4-e828-4f35-a4cc-ae534f220f14','God of War', 'God of War é um jogo eletrônico de ação-aventura desenvolvido pela Santa Monica Studio e publicado pela Sony Interactive Entertainment.','Santa Monica Studio', 'Sony', 'PlayStation 4', 'Action-adventure', 'Single Player')");
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('6aa3cdb5-1b44-4523-83d9-54d1f1d740a8','Paladins', 'Paladins se passa em um mundo vibrante de fantasia e oferece uma grande variedade de personagens, que vão desde humanos bons de pontaria a goblins com armaduras tecnológicas, de elfos místicos a dragões com jatos.', 'Evil Mojo Games', 'Hi-Rez Studios', 'PC; Consoles;', 'Hero Shooter', 'Multiplayer')");
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('b854b283-f4c7-4c2a-9596-5bcadb76a8e9','Euro Truck Simulator 2', 'Euro Truck Simulator 2 é um jogo de simulação de caminhões desenvolvido, e publicado pela SCS Software para Microsoft Windows, Linux e recentemente para OSX. Foi inicialmente lançado como um jogo de desenvolvimento aberto em 19 de outubro de 2012.','SCS Software', 'SCS Software', 'PC;', 'Simulator', 'Single Player')");
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('3e2d34d9-2171-4c6a-9bab-0b52cb44163c','Genshin Impact', 'Genshin Impact é um jogo eletrônico RPG de ação gratuito desenvolvido e publicado pela miHoYo. O jogo apresenta um ambiente de mundo aberto de fantasia e sistema de batalha baseado em ação usando magia elemental e troca de personagem.','miHoYo', 'miHoYo', 'PC; Consoles; Mobile;', 'RPG', 'Single and Multiplayer')");
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('6e31c499-7037-4384-9ae6-d0d8a94face0','Amnesia: A Machine for Pigs', 'Amnesia: A Machine for Pigs é um videogame de terror de sobrevivência desenvolvido pela The Chinese Room e publicado pela Frictional Games.', 'The Chinese Room', 'Frictional Games', 'PC; Consoles;', 'Survival Horror', 'Single Player')");
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('c1d9e6bb-75a7-4bbb-8b27-e4034601080d','This War of Mine', 'Em This War of Mine você não irá jogar com um soldado de elite, mas sim com um grupo de civis tentando sobreviver em uma cidade sitiada, lutando contra a falta de alimentos, medicamentos e constante perigo de franco-atiradores e catadores hostis.', '11 bit Studios', '11 bit Studios', 'PC; Consoles; Mobile;', 'Survival', 'Single Player')");
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('25153b71-c9b8-4242-a630-076d72a6274d','First Class Trouble', 'First Class Trouble é um jogo de equipe onde os jogadores devem trabalhar juntos e, ao mesmo tempo, contra uns aos outros para sobreviverem a um disastre. O objetivo é desligar a A.I. assassina.', 'Invisible Walls', 'Versus Evil', 'PC; Consoles;', 'Survival', 'Multiplayer')");
            mb.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Platform, Genre, Mode) VALUES('59a6f579-30cb-4863-95d4-caaeb42fcf01','Cuphead', 'Cuphead é um jogo de ação e tiros clássico, com enorme ênfase nas batalhas de chefes. Inspirado nas animações infantis da década de 1930, os visuais e efeitos sonoros foram minuciosamente recriados com as mesmíssimas técnicas dessa era, com destaque para desenhos feitos à mão, fundos em aquarela e gravações originais de jazz.', 'Studio MDHR Entertainment', 'Studio MDHR Entertainment', 'PC; Consoles;', 'Shoot 'em up', 'Single and Multiplayer')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TB_GAMES");
        }
    }
}
