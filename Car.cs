using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Дз3
{
    class Car
    {
        protected string _car_brand;
        protected int _power, _year;

        public Car(string car_brand, int power, int year)
        {
            this._car_brand = car_brand;
            this._power = power;
            this._year = year;
        }

        public override string ToString()
        {
            return "Car brand: " + _car_brand + ". Power: " + _power + ". Year of release: " + _year;
        }
    }

    class PassengerCar : Car 
    {
        int _numberofpassager;
        Dictionary<string, int> _repair_book;

        public PassengerCar(string car_brand, int power, int year, int numberofpassager, Dictionary<string, int> repair_book) : base(car_brand, power, year)
        {
            _numberofpassager = numberofpassager;
            _repair_book = repair_book;
        }

        public void Repair(string detail, int year)
        {
            if (_repair_book.ContainsKey(detail))
                _repair_book[detail] = year;
            else
                _repair_book.Add(detail, year);
        }

        public void GetYear(string detail)
        {
            if (_repair_book.ContainsKey(detail))
                Console.WriteLine(_repair_book[detail]);
            else
                Console.WriteLine("Такой детали нет");
        }

        public void WriteRepairBook()
        {
            foreach (KeyValuePair<string, int> detail in _repair_book)
            {
                Console.WriteLine($"{detail.Key} was replaced in {detail.Value}");
            }
        }

        public override string ToString()
        {
            return "Car brand: " + _car_brand + ". Power: " + _power + ". Year of release: " + _year + ". Number of passenger: " + _numberofpassager;
        }

    }

    class Truck : Car
    {
        int _maxweight;
        string _name_driven;
        Dictionary<string, int> _cargo_book;

        public Truck(string car_brand, int power, int year, int maxweight, string name_driven, Dictionary<string, int> cargo_book) :base(car_brand, power, year)
        {
            _maxweight = maxweight;
            _cargo_book = cargo_book;
            _name_driven = name_driven;
        }

        public string Name { get => _name_driven; set => _name_driven = value; }

        public void Add(string cargo, int weigts)
        {
            _cargo_book.Add(cargo, weigts);
        }

        public void Delet(string cargo)
        {
            _cargo_book.Remove(cargo);
        }

        public void WriteCargoBook()
        {
            foreach (KeyValuePair<string, int> cargo in _cargo_book)
            {
                Console.WriteLine($"Cargo: {cargo.Key}. Wheghts: {cargo.Value}");
            }
        }

        public override string ToString()
        {
            return "Car brand: " + _car_brand + ". Power: " + _power + ". Year of release: " + _year + ". Maximum weights: " + _maxweight + ". Sername and Name: " + _name_driven;
        }
    }

}
