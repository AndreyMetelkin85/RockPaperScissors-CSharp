namespace Children_game;

internal class Game
{
    public static readonly string[] PossibleValues = new[] { "камень", "ножницы", "бумага" };

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

        switch (computerChoice)
        {
            case "камень" when userChoice == "ножницы":
            case "ножницы" when userChoice == "бумага":
            case "бумага" when userChoice == "камень":
                return "Выиграл компьютер";
            default:
                return "Выиграл игрок";
        }
    }
}