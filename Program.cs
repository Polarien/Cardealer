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
string answer = Console.ReadLine();

CarDealer cd = new CarDealer();
while(true){

    Console.WriteLine("Write an action [buy, sell, exit]");
    string input = Console.ReadLine();

    switch (input)
    {
        case "buy":
            Car firstcar = cd.availablecar[1];
            Car myNewCar = cd.Buy(firstcar);
            Console.WriteLine("this new car cost a lot");
            break;
        case "sell":
            break;
        case "exit":
            return;
        default:
            return;
    }
}

class CarDealer{
   public List<Car> availablecar =new List<Car>();

    public CarDealer(){
        Brand b = new Brand();
        Colour c = new Colour();
        Gear g = new Gear();
        Tires t = new Tires();
        Model m = new Model();
        Price p = new Price();
        for(int i=1; i<10; i++){
            availablecar.Add(new Car(b, c, g, t, m, p));
        }
    }

    public string Buy(Car car){
        foreach(Car c in availablecar){
            
        }
    }

}
class Car{
    public Brand brand;
    public Colour colour;
    public Gear gear;
    public Tires tires;
    public Model model;
    public Price price;

    public Car(Brand brand, Colour colour, Gear gear, Tires tires, Model model, Price price){
        this.brand =brand;
        this.colour =colour;
        this.gear =gear;
        this.tires =tires;
        this.model =model;
        this.price =price;
    }
}
class Brand{
    public string BMW;
    public string AUDI;
    public string MERCEDES;
    public string FORD;
    public string FERRARI;
}

class Colour{
    public string BLACK;
    public string WHITE;
    public string RED;
    public string ORANGE;
    public string GRAY;
    public string BLUE;
    public string GREEN;
    public string YELLOW;
}

class Gear{
    public string MANUEL;
    public string AUTOMATIC;
}

class Tires{
    public string SUMMER;
    public string WINTER;
    public string SPIKES;
    public string ALLROUND;

}

class Model{
    public string TOURING;
    public string RANGER;
    public string SEDAN;
    public string COUPE;
}

class Price{

}


#endregion