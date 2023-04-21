using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using carros.entities;

namespace carros.repository
{
    public class CarRepository
    {
        public List<Car> CarList = new List<Car>();
        public List<Owner> OwnerList = new List<Owner>();

        public CarRepository() {
            Owner owner1 = new Owner(  "Nicolas Breno Novaes",
                                        "299.396.010-50",
                                        "(63) 99804-1322",
                                        "04/04/1952",
                                        "Masculino");

            Owner owner2 = new Owner(  "Cecília Carla da Silva",
                                       "110.208.411-50",
                                       "(37) 98348-3911",
                                       "17/01/1945",
                                       "Feminino");

            Owner owner3 = new Owner(  "Isabela Luciana Pinto",
                                        "694.037.477-90",
                                        "(11) 98729-3196",
                                        "15/02/1986",
                                        "Feminino");


            Car car1 = new Car( "VW - VolksWagen",
                                "Quantum CLi / CL / C/ CS/ CD/ CG 1.8/2.0",
                                1985,
                                "LVU-4557",
                                "Verde",
                                owner1);

            Car car2 = new Car( "LAMBORGHINI",
                                "Gallardo Spyder Performante LP570-4",
                                2012,
                                "HRR-8147",
                                "Bege",
                                owner2);

            Car car3 = new Car( "EFFA",
                                "Plutus 3.2 8V 4x2 CD Turbo Diesel",
                                2011,
                                "ANU-2758",
                                "Cinza",
                                owner3);

            Owner[] owners = { owner1, owner2, owner3};
            OwnerList.AddRange(owners);
            Car[] cars = { car1, car2, car3 };
            CarList.AddRange(cars);
        }

        public void AddCar(Car car){
            CarList.Add(car);
            OwnerList.Add(car.Owner);
        }  

    }
}
