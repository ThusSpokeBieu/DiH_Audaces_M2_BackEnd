using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace carros.entities
{
    public class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Plate  { get; private set; }
        public string Color { get; private set; }
        public Owner Owner { get; private set; }
        
        public Car( string brand,
                    string model,
                    int year,
                    string plate,
                    string color,
                    Owner owner)
        {

            if (!ValidatePlate(plate)) {
                throw new Exception("Placa inválida.");
            }

            if (!ValidateYear(year)) {
                throw new Exception("Ano inválido");
            }
            Brand = brand;
            Model = model;
            Year = year;
            Plate = plate;
            Color = color;
            Owner = owner;    
        }

        public bool ValidatePlate(string plate) {
            string pattern = @"^[A-Z]{3}-\d{4}$";

            if(!Regex.IsMatch(plate, pattern)) {
                return false;
            }

            return true;
        }

        public bool ValidateYear(int year) {
            
            if(year < 1800 || year > 2030) {
                return false;
            }

            return true;
        }
    }
}