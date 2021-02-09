using System;
using System.Collections.Generic;

namespace AutoAuctionProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalCar.trunkDimentionsStruct td;
            td.height = 14.0;
            td.width = 10.0;
            td.depth = 16.0;

            ProfessionalPersonalCar p = new ProfessionalPersonalCar("Suzuki Swift", 500.0, "XY12345", 2012, 10000.0, 10.0, 20.0, Vehicle.FuelTypeEnum.Benzin, 2, td, true, 400.0);
            Console.WriteLine(p.ToString() + "\n");

            List<Vehicle> v = new List<Vehicle>();
            foreach (Vehicle vi in v)
            {

            }
        }
    }
}
