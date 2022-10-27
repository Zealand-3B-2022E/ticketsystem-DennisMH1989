using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Model
{
    /// <summary>
    /// base classen for car og mc og den er abstract
    /// </summary>
    public abstract class Vehicle
    {
        private string _licensePlate = "";

        /// <summary>
        /// property for licenseplate for base classen
        /// </summary>
        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("value to long Needs to be less then 7");
                }
                _licensePlate = value;
            }
        }
        /// <summary>
        /// property for daten for base classen
        /// </summary>
        public abstract DateTime Date { get; set; }
        /// <summary>
        /// property for brobizz for base classen
        /// </summary>
        public abstract bool Brobizz { get; set; }

        /// <summary>
        /// metode der henter prisen for det vehicle der blev kaldt 
        /// </summary>
        /// <returns></returns>
        public abstract double Price();

        /// <summary>
        /// metode der henter vehicletypen
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
    }
}
