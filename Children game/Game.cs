namespace Children_game;

internal class Game
{
    internal string StartGame()
    {
        var player = new Player();
        var userChoice = player.PlayerInfo();
        var pc = new Round();
        var computerChoice = pc.RandomChoice();

        if (computerChoice == userChoice)
        {
            return "Ничья";
        }
        else if (computerChoice == "камень" && userChoice == "ножницы")
        {
            return "Выиграл компьютер";
        }
        else if (computerChoice == "ножницы" && userChoice == "бумага")
        {
            return "Выиграл компьютер";
        }
        else if (computerChoice == "буага" && userChoice == "каень")
        {
            return "Выиграл компьютер";
        }
        else
        {
            return "Выиграл игрок";
        }
    }
}