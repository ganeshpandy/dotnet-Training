using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    internal class Car:ITransport
    {
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public string? Color {  get; set; }
        public Car(string CarName,string CarModel,string Color) {            
            this.CarName = CarName;
            this.CarModel = CarModel;
            this.Color = Color;
        }
        public void Start(string CarName,string CarModel,string Color) {
            Console.WriteLine("===================");
            Console.WriteLine("CarName:"+CarName); 
            Console.WriteLine("CarModel:"+CarModel);
            Console.WriteLine("Color:"+Color);
        }

    }
}
