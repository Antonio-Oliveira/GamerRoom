﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GamerRoom.API.Data.Migrations
{
    public partial class PopuleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Fortnite
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('aaf33b90-1e24-47ae-a4a6-c22d30fbce54', 'Fortnite', 'Fortnite is a survival game where 100 players fight against each other in player versus player combat to be the last one standing. It is a fast-paced, action-packed game, not unlike The Hunger Games, where strategic thinking is a must in order to survive.', 'Epic Games', 'Epic Games', 'Battle Royale', 'PC; PlayStation 4; Xbox One; Nitendo Switch; Android;', 'Multiplayer', '2017-07-21', 'https://gamerroom.blob.core.windows.net/images/fortnite.jpg', 'https://www.youtube.com/watch?v=gMWMWEy0Oak')");
            //Among Us
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('4c5afb21-e651-4110-8b35-157870a1527d', 'Among Us', 'Among Us is a multiplayer game where between four and 10 players are dropped onto an alien spaceship. Each player is designated a private role as a crewmate or impostor.', 'InnerSloth', 'InnerSloth', 'Survival', 'PC; PlayStation 4; Xbox One; Nitendo Switch; Android; iOS;', 'Multiplayer', '2018-06-15', 'https://gamerroom.blob.core.windows.net/images/among-us.jpg', 'https://www.youtube.com/watch?v=JpalSQkmp2g')");
            //God of War
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('d01106d4-e828-4f35-a4cc-ae534f220f14', 'God of War', 'God of War is an action-adventure game franchise created by David Jaffe at Sony Santa Monica Studio. It began in 2005 on the PlayStation 2 video game console, and has become a flagship title for the PlayStation brand, consisting of eight games across multiple platforms with a ninth currently in development.', 'Santa Monica Studio', 'Sony Interactive Entertainment', 'Action-adventure', 'PlayStation 4;', 'Single Player', '2018-04-20', 'https://gamerroom.blob.core.windows.net/images/god-of-war.png', 'https://www.youtube.com/watch?v=EE-4GvjKcfs')");
            //Paladins
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('6aa3cdb5-1b44-4523-83d9-54d1f1d740a8', 'Paladins', 'Paladins is a team-based first-person shooter that focuses on two groups of five players each, who compete for combat-based goals. The game is set in colorful sci-fi fantasy maps, where each player chooses a champion that cannot be repeated in the same team and cannot be changed in the match. Each champion has their own weapons, skills and fighting style; in addition, they can be enhanced and personalized from a card and skin system.', 'Evil Mojo Games', 'Hi-Rez Studios', 'Hero Shooter', 'PC; PlayStation 4; Xbox One; Nitendo Switch;', 'Multiplayer', '2016-09-16', 'https://gamerroom.blob.core.windows.net/images/paladins.jpg', 'https://www.youtube.com/watch?v=lC6xaJlrukU')");
            //Euro Truck Simulator 2
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('b854b283-f4c7-4c2a-9596-5bcadb76a8e9', 'Euro Truck Simulator 2', 'Euro Truck Simulator 2 gives you the chance to become a real truck driver from the comfort of your home! Featuring licensed trucks with countless customization options and advanced driving physics, the game delivers an unparalleled driving experience which has put it in the spot of the most popular truck driving simulator on the market.', 'SCS Software', 'SCS Software', 'Simulator', 'PC;', 'Single Player', '2012-10-18', 'https://gamerroom.blob.core.windows.net/images/euro-truck-simulator-2.jpg', 'https://www.youtube.com/watch?v=xlTuC18xVII')");
            //Genshin Impact
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('3e2d34d9-2171-4c6a-9bab-0b52cb44163c', 'Genshin Impact', 'Genshin Impact is an open-world action role-playing game that allows the player to control one of four interchangeable characters in a party. Switching between characters can be done quickly during combat, allowing the player to use several different combinations of skills and attacks.', 'miHoYo', 'miHoYo', 'RPG', 'PC; PlayStation 4; Xbox One; Nitendo Switch; Android; iOS', 'Single and Multiplayer', '01-01-2001', 'https://gamerroom.blob.core.windows.net/images/genshin-impact.jpg', 'https://www.youtube.com/watch?v=NF_sUT6WjBY')");
            //Amnesia: Rebirth
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('6e31c499-7037-4384-9ae6-d0d8a94face0', 'Amnesia: Rebirth', 'Like The Dark Descent, the game is played from a first-person perspective. The player assumes control of Tasi Trianon, who must wander through desert caves and ancient tombs in order to find the whereabouts of her companions. The game is dimly lit, and players must use light sources, such as Tasi is own fuel lamp, to see clearly and find ways to progress. Players can also scavenge matches, which can be used to light up mounted torches and candles.', 'Frictional Games', 'Frictional Games', 'Survival Horror', 'PC; PlayStation 4; Xbox One; Nitendo Switch;', 'Single Player', '2020-10-20', 'https://gamerroom.blob.core.windows.net/images/amnesia-rebirth.jpg', 'https://www.youtube.com/watch?v=wqozgX92qBM')");
            //This War of Mine
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('c1d9e6bb-75a7-4bbb-8b27-e4034601080d', 'This War of Mine', 'This War of Mine is a survival-themed strategy game where the player controls a group of civilian survivors in a makeshift-damaged house in the besieged fictional city of Pogoren, Graznavia. The player starts off with one to four survivors whose actions the player can affect.', '11 bit Studios', '11 bit Studios', 'Survival', 'PC; PlayStation 4; Xbox One; Nitendo Switch; Android; iOS', 'Single Player', '2014-11-14', 'https://gamerroom.blob.core.windows.net/images/this-war-of-mine.png', 'https://www.youtube.com/watch?v=Hxf1seOpijE')");
            //First Class Trouble
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('25153b71-c9b8-4242-a630-076d72a6274d', 'First Class Trouble', 'First Class Trouble is a party game where players must work together and against each other to survive a disaster. The goal is to shut down a deadly A.I. Some players are impostors, secretly playing as human-looking killer robots intent on betraying the other players.', 'Invisible Walls', 'Versus Evil', 'Survival', 'PC; PlayStation 4; PlayStation 5; Xbox One; Xbox Series X; Nitendo Switch;', 'Multiplayer', '2021-04-08', 'https://gamerroom.blob.core.windows.net/images/first-class-trouble.jpg', 'https://www.youtube.com/watch?v=HlkB7c7BEvw')");
            //Cuphead
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('59a6f579-30cb-4863-95d4-caaeb42fcf01', 'Cuphead', 'Cuphead features one or two players taking control of its titular protagonist and his brother Mugman to fight through several levels, that culminate in boss fights, in order to repay their debt to the devil.', 'Studio MDHR Entertainment', 'Studio MDHR Entertainment', 'Shoot Em Up', 'PC; PlayStation 4; Xbox One; Nitendo Switch;', 'Single and Multiplayer', '2017-09-29', 'https://gamerroom.blob.core.windows.net/images/cuphead.jpg', 'https://www.youtube.com/watch?v=NN-9SQXoi50')");
            //Brawlhalla
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('c145abd8-b93a-4280-8056-7d4d43caeabd', 'Brawlhalla', 'A 2D platform fighter where the best of the baddest-ass warriors in history battle each other in an eternal tourney of champions for bragging rights, infinite mead, and the pure pleasure of delivering a beatdown.', 'Blue Mammoth Games', 'Ubisoft', 'Fighting Game', 'PC; PlayStation 4; Xbox One; Nitendo Switch; Android; iOS', 'Multiplayer', '2017-10-17', 'https://gamerroom.blob.core.windows.net/images/brawlhalla.jpg', 'https://www.youtube.com/watch?v=fnd71bqiiW0')");
            //Valorant
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('68cd3908-eceb-4a7a-9a4d-7d5c476c24e5', 'Valorant', 'Valorant is a competitive tactical shooter from the first-person perspective. It takes place on a near-future Earth and features a cast of characters known as agents, each of which have their own unique set of abilities to create tactical opportunities.', 'Riot Games', 'Riot Games', 'Hero Shooter', 'PC;', 'Multiplayer', '2020-06-02', 'https://gamerroom.blob.core.windows.net/images/valorant.jpg', 'https://www.youtube.com/watch?v=e_E9W2vsRbQ')");
            //Pokemon Unite
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('d74796f4-4f99-49e6-b276-b90c84386e2d', 'Pokemon Unite', 'In this game, players face off against each other in 5-on-5 team battles. During battles, players will cooperate with teammates to catch wild Pokémon, level up and evolve their own Pokémon, and defeat opponents. Pokémon while trying to earn more points than the opposing team within the allotted time.', 'TiMi Studio Group', 'The Pokemon Company', 'MOBA', 'Nitendo Switch; Android; iOS;', 'Multiplayer', '2021-07-21', 'https://gamerroom.blob.core.windows.net/images/pokemon-unite.jpg', 'https://www.youtube.com/watch?v=Q3WMddjkuwM')");
            //The Last of Us Part II
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('12247705-f2dc-49c6-9192-601a292b021f', 'The Last of Us Part II', 'Set five years after The Last of Us (2013), the game focuses on two playable characters in a post-apocalyptic United States whose lives intertwine: Ellie, who sets out for revenge after suffering a tragedy, and Abby, a soldier who becomes involved in a conflict between her militia and a religious cult.', 'Naughty Dog', 'Sony Interactive Entertainment', 'Action-adventure', 'PlayStation 4;', 'Single Player', '2020-06-19', 'https://gamerroom.blob.core.windows.net/images/the-last-of-us-part-ii.jpg', 'https://www.youtube.com/watch?v=W2Wnvvj33Wo')");
            //Garena Free Fire
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('788cb9d7-1459-4152-9fd9-fe8d3f6d8548', 'Garena Free Fire', 'A battle royale match consists of up to 50 players parachuting onto an island in search of weapons and equipment to kill the other players. Players are free to choose their starting position and take weapons and supplies to extend their battle life.', 'Garena', 'Garena', 'Battle Royale', 'Android; iOS;', 'Multiplayer', '2017-08-13', 'https://gamerroom.blob.core.windows.net/images/garena-free-fire.jpg', 'https://www.youtube.com/watch?v=oq2Rz2I11l0')");
            //Kena: Bridge of Spirits
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('d5ee78df-9e31-4188-bfea-9be7a27c4238', 'Kena: Bridge of Spirits', 'The story follows Kena, a young spirit guide who uses her magical abilities to help deceased people move from the physical to the spirit world. The game is presented through a third-person perspective. The player uses Kena is staff for attacking enemies, and her pulse ability for defending against attacks. They are tasked with collecting small spirit companions known as the Rot, who help to complete tasks and battle against enemies.', 'Ember Lab', 'Ember Lab', 'Action-adventure', 'PC; PlayStation 4; PlayStation 5;', 'Single Player', '2021-09-21', 'https://gamerroom.blob.core.windows.net/images/kena-bridge-of-spirits.jpg', 'https://www.youtube.com/watch?v=pWh5388AEHw')");
            //Outlast
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('8909104a-1b4b-481b-80b3-507dd7366c29', 'Outlast', 'The game revolves around a freelance investigative journalist, Miles Upshur, who decides to investigate a remote psychiatric hospital named Mount Massive Asylum, located deep in the mountains of Lake County, Colorado. The downloadable content Outlast: Whistleblower centers on Waylon Park, the man who led Miles there in the first place.', 'Red Barrels', 'Red Barrels', 'Survival Horror', 'PC; PlayStation 4; Xbox One; Nitendo Switch;', 'Single Player', '2013-09-04', 'https://gamerroom.blob.core.windows.net/images/outlast.jpg', 'https://www.youtube.com/watch?v=uKA-IA4locM')");
            //Forza Horizon 4
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('b6c719a6-d4cc-44dc-a839-0205da80c1c3', 'Forza Horizon 4', 'Forza Horizon 4 is a racing video game set in an open world environment based in a fictionalised Great Britain, with regions that include condensed representations of Edinburgh, the Lake District (including Derwentwater), Ambleside and the Cotswolds (including Broadway), Bamburgh among others. The game features a route creator which enables players to create races using completely customized routes.', 'Playground Games', 'Microsoft Studios', 'Racing', 'PC; Xbox One; Xbox Series X;', 'Single and Multiplayer', '2018-10-02', 'https://gamerroom.blob.core.windows.net/images/forza-horizon-4.jpg', 'https://www.youtube.com/watch?v=5xy4n73WOMM')");
            //Dead by Daylight
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('474db5ee-2938-4d0a-9162-25ad12c41dd0', 'Dead by Daylight', 'A group of four survivors must elude one killer bent on sacrificing them on hooks to The Entity, an almighty malevolent being. The survivors perspectives are third-person, while the killers perspective is first-person. The survivors can only fight back by stunning the killer or using items such as flashlights to blind the killer. Survivors can also vault over obstacles much faster than the killer, therefore providing a means of escape. Survivors use these obstacles and tools to help them elude the killer for as long as they can.', 'Behaviour Interactive', 'Behaviour Interactive', 'Survival Horror', 'PC; PlayStation 4; PlayStation 5; Xbox One; Xbox Series X; Nitendo Switch; Stadia; Android; iOS;', 'Multiplayer', '2016-06-14', 'https://gamerroom.blob.core.windows.net/images/dead-by-daylight.jpg', 'https://www.youtube.com/watch?v=WhhO7o-5KjA')");
            //Rocket League
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('d07ab195-38bc-420e-b802-b66e3326763f', 'Rocket League', 'Rocket League has up to eight players assigned to each of the two teams, using rocket-powered vehicles to hit a ball into their opponent is goal and score points over the course of a match. The game includes single-player and multiplayer modes that can be played both locally and online, including cross-platform play between all versions. Later updates for the game enabled the ability to modify core rules and added new game modes, including ones based on ice hockey and basketball.', 'Psyonix', 'Psyonix', 'Sports', 'PC; PlayStation 4; PlayStation 5; Xbox One; Nitendo Switch;', 'Single and Multiplayer', '2015-07-07', 'https://gamerroom.blob.core.windows.net/images/rocket-league.jpg', 'https://www.youtube.com/watch?v=SgSX3gOrj60')");
            //Horizon Zero Dawn
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('c7063238-4c4f-4049-9afc-61cbae413968', 'Horizon Zero Dawn', 'The plot follows Aloy, a young hunter in a world overrun by machines, who sets out to uncover her past. The player uses ranged weapons, a spear, and stealth to combat mechanical creatures and other enemy forces. A skill tree provides the player with new abilities and bonuses. The player can explore the open world to discover locations and take on side quests.', 'Guerrilha Games', 'Sony Interactive Entertainment', 'ARPG', 'PC; PlayStation 4;', 'Single Player', '2017-02-28', 'https://gamerroom.blob.core.windows.net/images/horizon-zero-dawn.jpg', 'https://www.youtube.com/watch?v=u4-FCsiF5x4')");
            //Knockout City
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('3038c317-b223-43bb-aa24-8b42d3b4109a', 'Knockout City', 'Knockout City is a team-based competitive multiplayer video game whose gameplay rules resemble dodgeball. The player is goal is to attack enemies from the opposing team by knocking them out with a ball. There are several types of balls in the game, including the Moon Ball, which allows the player holding the ball to jump higher, and the Bomb Ball, which is a time bomb that explodes on impact. A player can also throw another player as a ball.', 'Velan Studios', 'Electronic Arts', 'Action', 'PC; PlayStation 4; Xbox One; Nitendo Switch;', 'Multiplayer', '2021-05-21', 'https://gamerroom.blob.core.windows.net/images/knockout-city.jpg', 'https://www.youtube.com/watch?v=Pf8MJkuE3N0')");
            //Rise of Kingdoms
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('e90a0aba-a9ef-4bb2-b0f4-364648fd0cee', 'Rise of Kingdoms', 'Rise of Kingdoms is a staggeringly huge mobile game. You can play in a way that suits your style, whether that be reckless military adventurism and dreams of global dominance, or quiet and unobtrusive statecraft and dreams of a happy populace.', 'Lilith Games', 'Lilith Games', 'RTS', 'Android; iOS; HarmonyOS;', 'Multiplayer', '2018-09-20', 'https://gamerroom.blob.core.windows.net/images/rise-of-kingdoms.jpg', 'https://www.youtube.com/watch?v=FzW6xACkL-U')");
            //League of Legends
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('77324382-a285-4612-8306-cd4ced2489c7', 'League of Legends', 'In the game, two teams of five players battle in player versus player combat, each team occupying and defending their half of the map. Each of the ten players controls a character, known as a champion, with unique abilities and differing styles of play. During a match, champions become more powerful by collecting experience points, earning gold, and purchasing items to defeat the opposing team.', 'Riot Games', 'Riot Games', 'MOBA', 'PC;', 'Multiplayer', '2009-10-27', 'https://gamerroom.blob.core.windows.net/images/league-of-legends.jpg', 'https://www.youtube.com/watch?v=aR-KAldshAE')");
            //Battlefield V
            migrationBuilder.Sql("INSERT INTO TB_GAMES(ID, Name, Description, Developer, Publisher, Genre, Platform, Mode, ReleaseDate, ImageUri, TrailerUri) VALUES('2d49a9ed-6728-4b7f-b866-66ac29397bda', 'Battlefield V', 'Battlefield V is focused extensively on party-based features and mechanics, scarcity of resources, and removing abstractions from game mechanics to increase realism. There is an expanded focus on player customization through the new Company system, where players can create multiple characters with cosmetic and weapon options. Cosmetic items, and currency used to purchase others, are earned by completing in-game objectives.', 'DICE', 'Electronic Arts', 'FPS', 'PC; PlayStation 4; Xbox One;', 'Single and Multiplayer', '2018-11-20', 'https://gamerroom.blob.core.windows.net/images/battlefield-v.jpg', 'https://www.youtube.com/watch?v=fb1MR85XFOc')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TB_GAMES");
        }
    }
}
