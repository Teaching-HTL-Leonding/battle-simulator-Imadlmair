Console.Clear();
const string Pirate = "1";
const string StoneChewer = "2";
const string GhostWarrior = "3";
const string Outworlder = "4";
const string MonsterKngiht = "5";
const string DarkGoblin = "6";

int Player1health = 0;
int Player1damage = 0;
int Player1speed = 0;
int Player1armour = 0;
int Player2health = 0;
int Player2damage = 0;
int Player2speed = 0;
int Player2armour = 0;

Console.Write("Write (1) fort Pirate, Enter (2) for StoneChewer or enter (3) for GhostWarrior,(4) for Outworlder, (5) for MonsterKnight or (6) for Darkgoblin ");

Console.WriteLine();

Console.Write("Player1, choose a charakter: ");
string Player1 = Console.ReadLine()!;

Console.Write("Player2, choose a charakter: ");
string Player2 = Console.ReadLine()!;

switch (Player1)
{
    case Pirate:
        Player1health = 20;
        Player1damage = 3;
        Player1speed = 3;
        Player1armour = 3;
        break;

    case StoneChewer:
        Player1health = 50;
        Player1damage = 8;
        Player1speed = 1;
        Player1armour = 10;
        break;


    case GhostWarrior:
        Player1health = 20;
        Player1damage = 2;
        Player1speed = 5;
        Player1armour = 2;
        break;

    case Outworlder:
        Player1health = 15;
        Player1damage = 1;
        Player1speed = 10;
        Player1armour = 2;
        break;


    case MonsterKngiht:
        Player1health = 15;
        Player1damage = 4;
        Player1speed = 3;
        Player1armour = 3;
        break;


    case DarkGoblin:
        Player1health = 10;
        Player1damage = 1;
        Player1speed = 3;
        Player1armour = 8;
        break;

    default:
        System.Console.WriteLine("invalid input");
        return;
}

switch (Player2)
{
    case Pirate:
        Player2health = 20;
        Player2damage = 3;
        Player2speed = 3;
        Player2armour = 3;
        break;

    case StoneChewer:
        Player2health = 50;
        Player2damage = 8;
        Player2speed = 1;
        Player2armour = 10;
        break;


    case GhostWarrior:
        Player2health = 20;
        Player2damage = 2;
        Player2speed = 5;
        Player2armour = 2;
        break;


    case Outworlder:
        Player2health = 15;
        Player2damage = 1;
        Player2speed = 10;
        Player2armour = 2;
        break;


    case MonsterKngiht:
        Player2health = 15;
        Player2damage = 4;
        Player2speed = 3;
        Player2armour = 3;
        break;


    case DarkGoblin:
        Player2health = 10;
        Player2damage = 1;
        Player2speed = 3;
        Player2armour = 8;
        break;


    default:
        System.Console.WriteLine("invalid input");
        default;
}

while (Player1health > 0 && Player2health > 0)
{
    Player1health = Player1armour - Player1health - Player2damage * Player2speed;
    Player2health = Player2armour - Player2damage - Player1damage * Player1speed;
}

if (Player1health > 0) { Console.WriteLine("Player 1 wins"); }
else if (Player2health > 0) { Console.WriteLine("Player 2 wins"); }
else  Console.WriteLine("No winner"); 
