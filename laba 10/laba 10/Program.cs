namespace laba_10
{
    public class Car
    {
        public string Avto {get; set;}

    }
    public class Garage
    {
        public static List<Car> cars = new List<Car>();

        public void AddAvto(Car car)
        {
            cars.Add(car);
        }

        public delegate void CarDelegate(Car car);

        public void Carsdelegate(CarDelegate carDelegate)
        {
            foreach (Car car in cars)
            {
                carDelegate(car);
            }
        }

        public void WashCar(Washer washer)
        {
            foreach (Car car in cars)
            {
                washer.Wash(car);
            }
        }


    }
    public class Washer
    { 
        public void Wash(Car car)
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
            garage.WashCar(washer);
        }
    }
}