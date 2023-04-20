using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carros
{
    public class Car
    {
        private String Brand { get; set; }
        private String Model { get; set; }
        private String Plate  { get; set; }
        private String Color { get; set; }
        private Owner Owner { get; set; }
        
        public Car( String brand,
                    String model,
                    String plate,
                    String color,
                    Owner owner)
        {
            Brand = brand;
            Model = model;
            Plate = plate;
            Color = color;
            Owner = owner;    
        }
    }
}