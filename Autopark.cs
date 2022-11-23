using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз3
{
    class Autopark
    {
        string _name;
        List<Car> _autopark;

        public Autopark(string name, List<Car> autopark)
        {
            _name = name;
            _autopark = autopark;
        }

        public override string ToString()
        {
            for (int i = 0; i < _autopark.Count; i++)
                Console.WriteLine(_autopark[i].ToString());
            return "";
            
        }
    }
}
