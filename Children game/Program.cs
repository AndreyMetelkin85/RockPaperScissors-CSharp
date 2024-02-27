namespace Children_game;

internal class Program
{
    public static void Main()
    {
        var myGame = new Game();
        var result = myGame.StartGame();
        Console.WriteLine(result);
    }
    
}