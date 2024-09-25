
//1. Skapa en klass för fordon

// Skapa en enum Brand med 5 bilmärken, och en enum Color med 5 färger.
// Skriv sedan en klass Vehicle som har publika properties Brand och Color.
// Klassen ska ha en konstruktor som man kan använda för att sätta Brand och Color,
// och en konstruktor som endast tar Brand och sätter en default färg.

//2. Lägg till override för ToString()
// Gör en override på ToString() i Vehicle-klassen, så att "A white Toyota" skrivs ut om man kör följande kod:

//3. Skapa en subklass för bilar
// Skapa en klass Car som ärver av Vehicle. Lägg till en publik property Model,
// och skapa en konstruktor som initierar Brand, Model och Color.

//"A white Yaris from Toyota" ska skrivas ut om man kör följande kod:
Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));


Console.WriteLine(new Vehicle(Brand.Toyota, Color.White)); //2.
Vehicle vehicle1 = new Vehicle(Brand.Volvo);

enum Brand
    {
        Volvo,
        Tesla,
        Mercedes,
        Toyota,
        Ford
    }

    enum Color
    {
        Red,
        Green,
        Yellow,
        Blue,
        White
    }

enum Model
{
    Yaris,
    Focus,
    Roadster,
    XC60,
    Merced
}


class Vehicle
{

    public Brand Brand { get; set; } //Auto-property
    public Color Color { get; set; } //Auto-property

    public Vehicle(Brand brand)// Konstruktor som tar in Brand
    {
        //Sätt default färg
        this.Brand = brand;
        this.Color = Color.White;
        Console.WriteLine($"{this.Brand} {this.Color}");
    }

    public Vehicle(Brand brand, Color color) // Konstruktor som tar in Brand och Color
    {
        Brand = brand;
        Color = color;
    }
    public Vehicle()
    {
        
    }

    public override string ToString() //2. Overridar metoden ToString så att den kan ta in andra parametrar
    {
        return $"A {Color.ToString().ToLower()} {Brand}";
    }

}

class Car : Vehicle
{
    public Model Model { get; set; } //Auto-Property

}

struct Vehiclesize //4.
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Vehiclesize (double length, double width, double height)
    {
        this.Width = width;
        this.Height = height;
        this.Length = length;
    }

}