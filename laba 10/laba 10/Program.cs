namespace laba_10
{
    public class Car
    {
        public string Avto {get; set;}
    }
    public class Garage
    {
        public List<Car> cars = new List<Car>();

        public void AddAvto(Car car)
        {
            cars.Add(car);
        }

    }
    public class Washer
    {
        public delegate void CarDelegate(Car car);
        public CarDelegate carDelegate = new CarDelegate(Wash);
        public static void Wash(Car car)
        {
            Console.WriteLine("Автомобиль: " + car.Avto + " помыт");
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { Avto = "Автоваз"};
            Car car2 = new Car { Avto = "Пуф"};

            Garage garage = new Garage();
            garage.AddAvto(car1);
            garage.AddAvto(car2);

            Washer washer = new Washer();

            foreach (var car in garage.cars)
            {
                washer.carDelegate(car);
            }
        }
    }
}
