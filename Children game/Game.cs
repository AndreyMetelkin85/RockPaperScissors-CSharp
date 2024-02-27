namespace Children_game;

public abstract class Game
{
    public static string StartGame()
    {
        var computerChoice = Round.RandomChoice();
        var userChoice = Player.PlayerInfo();

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