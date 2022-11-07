#region Assignment

//Create a CarDealer program
//The CarDealer must have a list of available cars for sale
//The CarDealer must have public Buy/Sell methods
//These methods must be accessiable via console input/output
//These methods must change the car dealers available cars
//Make use of atleast 5 classes.
//Classes are usually nouns (navneord, en/et foran), f.x.:
//Car, CarDealer, Engine, Person
//Make use of atleast 10 methods
//2 of these methods must use paramaters
//Methods usually describes verbs (udsagnsord, at/jeg foran)
//Buy, Sell, Accelerate, Move

// Suggestion to get started on user interaction in the console

#endregion

#region 

Console.WriteLine("Hello Customer");
Console.WriteLine("What do you want to do");

CarDealer cd = new CarDealer();

while(true){

    Console.WriteLine("Write an action [buy, sell, exit]");
    string input = Console.ReadLine();

    switch (input)
    {
        case "buy":
            List<Car> cars = cd.DisplayCars();
            Console.WriteLine("which one you want? (Enter an integer)");
            string? answer = Console.ReadLine();
            int converted = Int32.Parse(answer);
            Car myNewCar = cd.Buy(cars[converted]);
            Console.WriteLine(myNewCar.brand);
            break;
        case "sell":
            break;
        case "exit":
            return;
        default:
            return;
    }
}



#endregion