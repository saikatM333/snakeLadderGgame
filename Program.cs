// See https://aka.ms/new-console-template for more information
using SnakeAndLadderGame;
using SnakeLadderGame;

Console.WriteLine("Snake and ladder game ");
int select = Convert.ToInt32(Console.ReadLine());
switch (select) {
    case 0:
        singlePlayerGame s = new singlePlayerGame();
s.playingTheGame();
        break;
        case 1:
        twoplayergame game = new twoplayergame();
        game.playingTheGame();
        break;
    default: Console.WriteLine("pls select between 0 and 1 ");
        break;
}