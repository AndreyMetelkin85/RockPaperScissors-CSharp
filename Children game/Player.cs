namespace Children_game;

internal class Player
{
    internal string PlayerInfo()
    {
        Console.WriteLine("Добро пожаловать!");
        Console.WriteLine("Давай сыграем в игру камень, ножницы, бумага!");
        Console.Write("Напиши свой выбор: ");

        var userChoice = Console.ReadLine();

        var possibleValues = new[] { "камень", "ножницы", "бумага" };

        while (!possibleValues.Contains(userChoice))
        {
            Console.WriteLine($"Вы ввели не верное значение: {userChoice}");
            Console.Write("Введите повторно своё значение: ");
            userChoice = Console.ReadLine();
        }

        return userChoice;
    }
}