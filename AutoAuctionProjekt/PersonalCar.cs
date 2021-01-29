using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAuctionProjekt
{
    abstract class PersonalCar : Vehicle
    {
        public PersonalCar(
            string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            int numberOfSeat,
            trunkDimentionsStruct trunkDimentions)
            : base(name, km, registrationNumber, year, newPrice, towbar, kmPerLiter, fuelType)
        {
            this.NumberOfSeat = numberOfSeat;
            this.TrunkDimentions = trunkDimentions;
            this.EngineSize = engineSize;
        }
        /// <summary>
        /// Number of seat field and proberty
        /// </summary>
        public int NumberOfSeat
        {
            get { return numberOfSeat; }
            set { numberOfSeat = value; }
        }
        private int numberOfSeat;
        /// <summary>
        /// Trunk dimentions field, proberty and struct
        /// </summary>
        public trunkDimentionsStruct TrunkDimentions
        {
            get { return trunkDimentions; }
            set { trunkDimentions = value; }
        }
        private trunkDimentionsStruct trunkDimentions;
        public struct trunkDimentionsStruct
        {
            public double height;
            public double width;
            public double depth;
            public override string ToString() => $"({height}, {width}, {depth})";
        }
        /// <summary>
        /// Engine size proberty
        /// must be between 0.7 and 10.0 L or cast an out of range exection.
        /// </summary>
        public override double EngineSize
        {
            get { return this.engineSize; }
            set
            {
                if (value < 0.7 || value > 10.0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be between 0.7 and 10.0 L.");

                this.engineSize = value;
            }
        }
        /// <summary>
        /// Returns the PersonalCar in a string with relivant information.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + String.Format("\t {0}: {1}\t {2}: {3}",
                nameof(this.NumberOfSeat),
                this.NumberOfSeat,
                nameof(this.TrunkDimentions),
                this.TrunkDimentions.ToString()
                );
        }
    }

    class PrivatePersonalCar : PersonalCar
    {
        public PrivatePersonalCar(
            string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            int numberOfSeat,
            trunkDimentionsStruct trunkDimentions,
            bool isofixFittings) 
            : base(name, km, registrationNumber, year, newPrice, towbar, engineSize, kmPerLiter, fuelType, numberOfSeat, trunkDimentions)
        {
            this.IsofixFittings = isofixFittings;
            this.DriversLisence = driversLisenceEnum.B;
        }
        /// <summary>
        /// Isofix Fittings field and proberty
        /// </summary>
        public bool IsofixFittings
        {
            get { return isofixFittings; }
            set { isofixFittings = value; }
        }
        private bool isofixFittings;
        /// <summary>
        /// Returns the PrivatePersonalCar in a string with relivant information.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + String.Format("\t {0}: {1}",
                nameof(this.IsofixFittings),
                this.IsofixFittings
                );
        }
    }

    class ProfessionalPersonalCar : PersonalCar
    {
        public ProfessionalPersonalCar(
            string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            int numberOfSeat,
            trunkDimentionsStruct trunkDimentions,
            bool safetyBar,
            double loadCapacity) 
            : base(name, km, registrationNumber, year, newPrice, true, engineSize, kmPerLiter, fuelType, numberOfSeat, trunkDimentions)
        {
            this.SafetyBar = safetyBar;
            this.NumberOfSeat = 2;
            this.LoadCapacity = loadCapacity;
            
            if (this.loadCapacity > 750.0)
            {
                this.DriversLisence = driversLisenceEnum.BE;
            } else
            {
                this.DriversLisence = driversLisenceEnum.B;
            }
        }
        /// <summary>
        /// Safety Bar field and proberty
        /// </summary>
        public bool SafetyBar
        {
            get { return safetyBar; }
            set { safetyBar = value; }
        }
        public bool safetyBar;
        /// <summary>
        /// Load Capacity field and proberty
        /// </summary>
        public double LoadCapacity
        {
            get { return loadCapacity; }
            set { loadCapacity = value; }
        }
        public double loadCapacity;
        /// <summary>
        /// Returns the ProfessionalPersonalCar in a string with relivant information.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + String.Format("\t {0}: {1}\t {2}: {3}",
                nameof(this.SafetyBar),
                this.SafetyBar,
                nameof(this.LoadCapacity),
                this.LoadCapacity
                );
        }
    }
}