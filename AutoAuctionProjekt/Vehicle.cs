using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAuctionProjekt
{
    abstract class Vehicle
    {
        protected Vehicle (string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double kmPerLiter,
            fuelTypeEnum fuelType)
        {
            this.Name = name;
            this.Km = km;
            this.RegistrationNumber = registrationNumber;
            this.Year = year;
            this.NewPrice = newPrice;
            this.KmPerLiter = kmPerLiter;
            this.FuelType = fuelType;
            this.engeryClass = GetEnergyClass();
        }
        /// <summary>
        /// Name field and proberty
        /// </summary>
        public string Name
        {
            get { return name; }
            set { 
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(value)} ");
                }
                name = value; }
        }
        private string name;
        /// <summary>
        /// Km field and proberty
        /// </summary>
        public double Km
        {
            get { return km; }
            set { km = value; }
        }
        private double km;
        /// <summary>
        /// Registration number field and proberty
        /// </summary>
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        private string registrationNumber;
        /// <summary>
        /// Year field and proberty
        /// </summary>
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private int year;
        /// <summary>
        /// New price field and proberty
        /// </summary>
        public double NewPrice
        {
            get { return newPrice; }
            set { newPrice = value; }
        }
        private double newPrice;
        /// <summary>
        /// Towbar field and proberty
        /// </summary>
        public bool Towbar
        {
            get { return towbar; }
            set { towbar = value; }
        }
        private bool towbar;
        /// <summary>
        /// Engine size field and proberty
        /// </summary>

        public virtual double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }
        protected double engineSize;
        /// <summary>
        /// Km per liter field and proberty
        /// </summary>
        public double KmPerLiter
        {
            get { return kmPerLiter; }
            set { kmPerLiter = value; }
        }
        private double kmPerLiter;
        /// <summary>
        /// Drivers lisence Enum, field and proberty
        /// </summary>
        public driversLisenceEnum DriversLisence
        {
            get { return driversLisence; }
            set { driversLisence = value; }
        }
        private driversLisenceEnum driversLisence;
        public enum driversLisenceEnum
        {
            A,
            B,
            C,
            D,
            BE,
            CE,
            DE
        }
        /// <summary>
        /// NFuel type Enum, field and proberty
        /// </summary>
        public fuelTypeEnum FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        private fuelTypeEnum fuelType;
        public enum fuelTypeEnum
        {
            Diesel,
            Benzin
        }
        /// <summary>
        /// Engery class Enum, field and proberty
        /// </summary>
        public engeryClassEnum EngeryClass
        {
            get { return engeryClass; }
        }
        private engeryClassEnum engeryClass;
        public enum engeryClassEnum
        {
            A,
            B,
            C,
            D
        }
        /// <summary>
        /// Engery class is calculated bassed on year of the car and the efficiancy in km/L.
        /// </summary>
        /// <returns>
        /// Returns the energy class in engeryClassEnum (A,B,C,D)
        /// </returns>
        private engeryClassEnum GetEnergyClass ()
        {
            if (this.year < 2010)
            {
                if (this.fuelType is fuelTypeEnum.Diesel)
                {
                    if (this.kmPerLiter >= 23.0)
                    {
                        return engeryClassEnum.A;
                    }
                    else if (this.kmPerLiter < 23.0 && this.kmPerLiter >= 18.0)
                    {
                        return engeryClassEnum.B;
                    }
                    else if (this.kmPerLiter < 18.0 && this.kmPerLiter >= 13.0)
                    {
                        return engeryClassEnum.C;
                    }
                    else if (this.kmPerLiter < 13.0)
                    {
                        return engeryClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    if (this.kmPerLiter >= 18.0)
                    {
                        return engeryClassEnum.A;
                    }
                    else if (this.kmPerLiter < 18.0 && this.kmPerLiter >= 14.0)
                    {
                        return engeryClassEnum.B;
                    }
                    else if (this.kmPerLiter < 14.0 && this.kmPerLiter >= 10.0)
                    {
                        return engeryClassEnum.C;
                    }
                    else if (this.kmPerLiter < 10.0)
                    {
                        return engeryClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            else
            {
                if (this.fuelType is fuelTypeEnum.Diesel)
                {
                    if (this.kmPerLiter >= 25.0)
                    {
                        return engeryClassEnum.A;
                    }
                    else if (this.kmPerLiter < 25.0 && this.kmPerLiter >= 20.0)
                    {
                        return engeryClassEnum.B;
                    }
                    else if (this.kmPerLiter < 20.0 && this.kmPerLiter >= 15.0)
                    {
                        return engeryClassEnum.C;
                    }
                    else if (this.kmPerLiter < 15.0)
                    {
                        return engeryClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    if (this.kmPerLiter >= 20.0)
                    {
                        return engeryClassEnum.A;
                    }
                    else if (this.kmPerLiter < 20.0 && this.kmPerLiter >= 16.0)
                    {
                        return engeryClassEnum.B;
                    }
                    else if (this.kmPerLiter < 16.0 && this.kmPerLiter >= 12.0)
                    {
                        return engeryClassEnum.C;
                    }
                    else if (this.kmPerLiter < 12.0)
                    {
                        return engeryClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }
        /// <summary>
        /// Returns the vehicle in a string with relivant information.
        /// </summary>
        public new virtual string ToString()
        {
            return String.Format("{0}: {1}\t {2}: {3} km\t {4}: {5}\t {6}: {7}\t {8}: {9}\t {10}: {11}\t {12}: {13} km/L\t {14}: {15}\t {16}: {17}\t {18}: {19}",
                nameof(this.Name),
                this.Name,
                nameof(this.Km),
                this.Km,
                nameof(this.RegistrationNumber),
                this.RegistrationNumber,
                nameof(this.Year),
                this.Year,
                nameof(this.NewPrice),
                this.NewPrice,
                nameof(this.EngineSize),
                this.EngineSize,
                nameof(this.KmPerLiter),
                this.KmPerLiter,
                nameof(this.DriversLisence),
                this.DriversLisence,
                nameof(this.FuelType),
                this.FuelType,
                nameof(this.EngeryClass),
                this.EngeryClass
                );
        }
    }
}
