using System;
using Дз3;

namespace Cars
{
    public class Program
    {
        static void Main(string[] args)
        {
            PassengerCar Audi = new PassengerCar("Audi", 350, 2020, 5, new Dictionary<string, int> { ["Motor"] = 2020, ["Wheals"] = 2020, ["Cardan"] = 2020 });

            PassengerCar Porshe = new PassengerCar("Porche", 400, 2018, 6, new Dictionary<string, int> { ["Motor"] = 2018, ["Wheals"] = 2018, ["Cardan"] = 2018 });

            Truck Kamaz = new Truck("Kamaz", 300, 2010, 2000, "Ivanov Ivan", new Dictionary<string, int> { ["Pubbles"] = 150, ["Sand"] = 300, ["Stone"] = 500 });

            Truck GAZ_3302 = new Truck("GAZ_3302", 200, 208, 500, "Petrov Petr", new Dictionary<string, int> { ["Tomatoes"] = 75, ["Сucumbers"] = 35, ["Potatoes"] = 125 });

            Autopark autopark = new Autopark("Name", new List<Car> { Audi, Porshe, Kamaz, GAZ_3302 });

            autopark.ToString();
        }

        
    }
}
