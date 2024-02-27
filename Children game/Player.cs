namespace Children_game;

internal class Player
{
    internal string PlayerInfo()
    {
        Console.WriteLine("Добро пожаловать!");
        Console.WriteLine("Давай сыграем в игру камень, ножницы, бумага!");
        Console.Write("Напиши свой выбор: ");

        var userChoice = Console.ReadLine();

        while (userChoice != "камень" && userChoice != "ножницы" && userChoice != "бумага")
        {
            Console.WriteLine("Не корректный ввод. Давай ещё раз");
            Console.Write("Напиши свой выбор (камень, ножницы, бумага): ");
            userChoice = Console.ReadLine();
        }


        return userChoice;
    }
}