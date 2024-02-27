
namespace Children_game;

internal class Round
{
    internal string RandomChoice()
    {
        var rand = new Random();
        switch (rand.Next(3))
        {
            case 0:
                return "камень";
            case 1:
                return "ножницы";
            case 2:
                return "бумага";
            default:
                return "Изивинет, но значение не верное!";
        }
    }
}