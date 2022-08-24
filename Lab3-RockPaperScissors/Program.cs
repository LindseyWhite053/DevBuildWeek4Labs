
RandomPlayer player1 = new RandomPlayer("Fred");
AlwaysPlayer player2 = new AlwaysPlayer("Sally", Roshambo.Rock);
AlwaysPlayer player3 = new AlwaysPlayer("Sam", Roshambo.Paper);
RandomPlayer player4 = new RandomPlayer("Jim");

Play(player1, player2);
Play(player1, player2);
Play(player1, player2);

Play(player1, player3);
Play(player1, player3);
Play(player1, player3);

Play(player1, player4);
Play(player1, player4);
Play(player1, player4);


static void Play(Player p1, Player p2)
{
    p1.Generate();
    p2.Generate();

    string winner = "";
    if(p1.CurrentChoice == p2.CurrentChoice)
    {
        Console.WriteLine($"Players: {p1.Name} and {p2.Name}. Result: Draw");
        winner = "Nobody";
    } 
    else if (p1.CurrentChoice == Roshambo.Rock)
    {
        if (p2.CurrentChoice == Roshambo.Paper)
        {
            winner = p2.Name;
        }
        else 
        {
            winner = p2.Name;
        }
    }
    else if (p1.CurrentChoice == Roshambo.Scissors)
    {
        if (p2.CurrentChoice == Roshambo.Rock)
        {
            winner = p2.Name;
        }
        else
        {
            winner = p1.Name;
        }

    } else
    {
        if (p2.CurrentChoice == Roshambo.Scissors)
        {
            winner = p2.Name;
        }
        else
        {
            winner = p1.Name;
        }
    }

    Console.WriteLine($"Players: {p1.Name} ({p1.CurrentChoice}) and {p2.Name}({p2.CurrentChoice}). Result: {winner} wins!");
}

enum Roshambo
{
    Rock, // 0
    Paper, // 1
    Scissors, // 2
}



//Create the Player classes like so:
// First, create an abstract class named Player that stores a name for the player and a current Roshambo choice. This class should include two member variables and one member function as follows:
// A member variable of type string called Name representing the name of the player.
// A member variable of type Roshambo called CurrentChoice that stores the weapon this player is currently using.
// A virtual method(labeled as “abstract”) called Generate that takes no parameters returns void.
abstract class Player
{
    public string Name;
    public Roshambo CurrentChoice;
    public virtual void Generate()
    {

    }
}


// Next, create two classes derived from Player:
// RandomPlayer - Picks and throws a value at random.
// Include a single constructor that takes a parameter of type string called Name and calls the base class constructor.
// Override Generate to generate a random Roshambo.
class RandomPlayer : Player
{
    public RandomPlayer(string name)
    {
        Name = name;
    }

    public override void Generate()
    {
        Random rnd = new Random();
        CurrentChoice = (Roshambo)rnd.Next(0, 3);
    }
}


// AlwaysPlayer - Always plays a particular weapon.
// For this class, create a constructor that takes two parameters, a Name (string) and a Roshambo, which specifies what weapon this player will always play. 
// Pass Name to the base constructor and store the Roshambo in the appropriate member variable.
// Then override the Generate function to always return the Roshambo that was specified in the constructor.
class AlwaysPlayer : Player
{
    public AlwaysPlayer (string name, Roshambo choice)
    {
        Name = name;
        CurrentChoice = choice;
    }

}

