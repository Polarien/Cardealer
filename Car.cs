public class Car{
    public BrandType brand;
    public ColourType colour;
    public Gear gear;
    public TireType tires;
    public ModelType model;
    public int price;

    public Car(BrandType brand, ColourType colour, Gear gear, TireType tires, ModelType model, int price){
        this.brand = brand;
        this.colour = colour;
        this.gear = gear;
        this.tires = tires;
        this.model = model;
        this.price = price;
    }
}