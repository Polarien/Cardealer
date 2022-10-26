public class CarDealer
{
    public List<Car> _availableCars = new List<Car>();

    public CarDealer()
    {

        Gear autoGear = new Gear(true);
        Car firstCar = new Car(BrandType.BMW, ColourType.WHITE, autoGear, TireType.SPIKES, ModelType.TOURING, 1000);

        Gear manHighGear = new Gear(0, false, 10);
        Car secondCar = new Car(BrandType.AUDI, ColourType.ORANGE, manHighGear, TireType.SPIKES, ModelType.TOURING, 10000);


        _availableCars.Add(firstCar);
        _availableCars.Add(secondCar);
    }

    public Car Buy(Car car)
    {
        _availableCars.Remove(car);
        return car;
    }

    public List<Car> DisplayCars()
    {
        foreach (Car car in _availableCars)
        {
            Console.WriteLine("This car is a " + car.brand + " that costs : " + car.price);
        }
        return _availableCars;
    }
}