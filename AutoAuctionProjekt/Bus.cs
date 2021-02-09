using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAuctionProjekt
{
    class Bus : Vehicle
    {
        public Bus (
            string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            FuelTypeEnum fuelType) : base(name, km, registrationNumber, year, newPrice, towbar, kmPerLiter, fuelType)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Engine size proberty
        /// must be between 4.2 and 15.0 L or cast an out of range exection.
        /// </summary>
        public override double EngineSize
        {
            get { return this.engineSize; }
            set
            {
                if (value < 4.2 || value > 15.0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be between 4.2 and 15.0 L.");

                this.engineSize = value;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
