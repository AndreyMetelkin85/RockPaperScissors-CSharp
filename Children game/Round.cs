namespace Children_game;

internal class Round
{
    internal string RandomChoice()
    {
        var rand = new Random();

        var index = rand.Next(Game.PossibleValues.Length);
        var computerChoice = Game.PossibleValues[index];

        return computerChoice;
    }
}