using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }
    }

    public class Garage : IEnumerable<Car>
    {
        private List<Car> cars;

        public Garage()
        {
            cars = new List<Car>();
        }

        public void AddCar(string make, string model)
        {
            cars.Add(new Car(make, model));
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
