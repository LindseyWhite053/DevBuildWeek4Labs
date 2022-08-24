Console.WriteLine("Welcome to the Car Emporium!");

// Store the car information in a list.
List<Car> carList = new List<Car>();

// Initialize the car List 
Init(carList);

while (true)
{
    //Determine what the user would like to do. buy car, add car, quit
    string choice = MainMenu(carList).ToLower();

    if (choice == "a")
    {
        // Will prompt the user to add a new or used car
        AddCar(carList);
    }
    else if (choice == "q")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        // will prompt the user to buy a car
        BuyCar(carList, int.Parse(choice));
    }
}

static void Init(List<Car> theList)
{
    Car car1 = new Car("Mitsubishi", "Canter FE125", 2022, 30000);
    theList.Add(car1);
    Car car2 = new Car("Suzuki", "Vitara", 2022, 26490);
    theList.Add(car2);
    Car car3 = new Car("Lexus", "NX300H", 2022, 40000);
    theList.Add(car3);
    UsedCar car4 = new UsedCar("Chevrolet", "SILVERADO 3500", 2006, 53480, 86890);
    theList.Add(car4);
    UsedCar car5 = new UsedCar("Dodge", "MAGNUM", 2006, 34995, 49603);
    theList.Add(car5);
    UsedCar car6 = new UsedCar("Chevrolet", "CAVALIER", 2003, 3995, 163045);
    theList.Add(car6);
}


static string MainMenu(List<Car> theList)
{
    Console.WriteLine();
    for(int i = 0; i < theList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {theList[i]}");
    }

    Console.WriteLine("(A)dd new car");
    Console.WriteLine("(Q)uit");
    Console.Write("Which car would you like:  ");
    string entry = Console.ReadLine();
    return entry;
}


static void AddCar(List<Car> theList)
{
    while (true)
    {
        Console.Write("Which type of car would you like to add (new/used): ");
        string input = Console.ReadLine().ToLower();

        Console.Write("Enter Make: ");
        string make = Console.ReadLine();

        Console.Write("Enter Model: ");
        string model = Console.ReadLine();

        Console.Write("Enter Year: ");
        string year = Console.ReadLine();

        Console.Write("Enter Price: ");
        string price = Console.ReadLine();

        if (input == "n" || input == "new")
        {
            Car newcar = new Car(make, model, int.Parse(year), decimal.Parse(price));
            theList.Add(newcar);

        }
        else if (input == "u" || input == "used")
        {

            Console.Write("Enter Mileage: ");
            string mileage = Console.ReadLine();

            UsedCar usedCar = new UsedCar(make, model, int.Parse(year), decimal.Parse(price), double.Parse(mileage));
            theList.Add(usedCar);
        }

        Console.Write("Would you like to add another car (y/n): ");

        string yesNo = Console.ReadLine().ToLower();

        if  (yesNo == "n" || yesNo == "no")
        {
            break;
        }
    }
 }


static void BuyCar(List<Car> theList, int index)
{
    Console.WriteLine("Would you like to purchase the following car? ");
    Console.WriteLine(theList[index]);
    Console.Write("y/n: ");

    string yesNo = Console.ReadLine().ToLower();

    if (yesNo == "y" || yesNo == "yes")
    {
        Console.WriteLine("Purchased!");
        theList.RemoveAt(index);

    }
    else if (yesNo == "n" || yesNo == "no")
    {
        Console.WriteLine("Heading back to the main menu."); 
    }
}


class Car
{
    public string Make;
    public string Model;
    public int Year;
    public decimal Price;

    public Car()
    {
        Make = "TBD Make";
        Model = "TBD Model";
        Year = 0;
        Price = 0;
    }

    public Car(string make, string model, int year, decimal price)
    {
        Make = make;
        Model = model;
        Year = year;
        Price = price;
    }

    public override string ToString()
    {
        //return "{0,15}{1,10}{5}{3,10}", Make, Model, Year, Price);
        return $"{Make} {Model} ({Year}) ${Price} new";
    }
}

class UsedCar : Car
{
    public double Mileage;

    public UsedCar(string make, string model, int year, decimal price, double mileage)
        : base(make, model, year, price)
    {
        Mileage = mileage;
    }

    public override string ToString()
    {
        return $"{Make} {Model} ({Year}) ${Price} {Mileage} miles";
    }
}


// Extra Challenges:
// Write a CarLotApp class which instantiates and puts cars in your CarLot class.  It should invoke CarLot methods to let a user:
// List all cars.
// Buy a car, which removes it from the inventory.
// Add a car.
// 
// The main method would then create an instance of CarLotApp and call its methods as needed.

// Think about other methods which might be useful for your CarLot. Implement them and modify your app to take advantage of them. 
// Modify or create a class named Validator with static methods to validate the data in this application. 

// Create an Admin mode which lets the user edit, delete, or replace cars. Move the Add a car feature here.

// Provide search features:
// View all cars of an entered make.
// View all cars of an entered year.
// View all cars of an entered price or less.
// View only used cars or view only new cars.
