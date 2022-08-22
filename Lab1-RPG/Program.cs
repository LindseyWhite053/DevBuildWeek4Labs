Console.WriteLine("Welcome to World of BuildCraft!");

List<GameCharacter> gameCharacters = new List<GameCharacter>();
Warrior first = new Warrior("Tormund the Giant Slayer", 20, 11, "War Hammer");
gameCharacters.Add(first);

Warrior second = new Warrior("Jon Snow the Crow", 18, 16, "Sword");
gameCharacters.Add(second);

Wizard third = new Wizard("Sylvanas the Dark", 10, 18, 30, 5);
gameCharacters.Add(third);

Wizard fourth = new Wizard("Lillith Hightower", 13, 20, 25, 3);
gameCharacters.Add(fourth);

Wizard fifth = new Wizard("Kargath the Wise", 12, 18, 38, 4);
gameCharacters.Add(fifth);


foreach(GameCharacter character in gameCharacters)
{
    character.Play();
}

class GameCharacter
{
    public string Name;
    public int Strength;
    public int Intelligence;

    public GameCharacter (string _Name, int _Strength, int _Intelligence) 
    {
        Name = _Name;
        Strength = _Strength;
        Intelligence = _Intelligence;
    }

    public virtual void Play()
    {
        Console.WriteLine($"You are playing the game as {Name} (Strength: {Strength}, Intelligence: {Intelligence})");
    }
}

class MagicUsingCharacter : GameCharacter
{
    public int MagicalEnergy;

    public MagicUsingCharacter (string _Name, int _Strength, int _Intelligence, int _MagicalEnergy)
        :base (_Name, _Strength, _Intelligence)
    {
        MagicalEnergy = _MagicalEnergy;
    }

    public override void Play()
    {
        Console.WriteLine($"You are playing the game as {Name} (Strength: {Strength}, Intelligence: {Intelligence}, Magical Energy {MagicalEnergy})");
    }

}

class Wizard : MagicUsingCharacter
{
    public int SpellNumber;

    public Wizard(string _Name, int _Strength, int _Intelligence, int _MagicalEnergy, int _SpellNumber) 
        : base (_Name, _Strength, _Intelligence, _MagicalEnergy)
    {
        SpellNumber = _SpellNumber;
    }

    public override void Play()
    {
        Console.WriteLine($"Your playing the game as {Name} (Strength: {Strength}, Intelligence: {Intelligence}, Magical Energy {MagicalEnergy}) {SpellNumber} Spells");
    }
}

class Warrior: GameCharacter
{
    public string WeaponType;

    public Warrior (string _Name, int _Strength, int _Intelligence, string _WeaponType)
        : base (_Name, _Strength, _Intelligence)
    {
        WeaponType = _WeaponType;
    }

    public override void Play()
    {
        Console.WriteLine($"You are playing the game as {Name} (Strength: {Strength}, Intelligence: {Intelligence}) Weapon Type: {WeaponType}");
    }
}