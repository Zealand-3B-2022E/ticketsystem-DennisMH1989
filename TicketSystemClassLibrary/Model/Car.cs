using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Model
{
    /// <summary>
    /// en class der kan oprette et object af en bil
    /// </summary>
    public class Car : Vehicle
    {
        private DateTime _date;
        private bool _brobizz;
        
        /// <summary>
        /// property til at hente og sætte datoen for overkørselsen
        /// </summary>
        public override DateTime Date { get; set; }
        /// <summary>
        /// property til at hente og sætte om bilen har brobizz
        /// </summary>
        public override bool Brobizz { get; set; }
        /// <summary>
        /// defoult constroctor for Mc
        /// </summary>
        public Car()
        {
            LicensePlate = "0000000";
            Date = DateTime.Now;
            Brobizz = false;
        }
        /// <summary>
        /// konstroctor med parameterne 
        /// </summary>
        /// <param name="_licensePlate"></param>
        /// <param name="_date"></param>
        /// <param name="_brobizz"></param>
        public Car(string _licensePlate, DateTime _date, bool _brobizz)
        {
            LicensePlate = _licensePlate;
            Date = _date;
            Brobizz = _brobizz;
        }
        /// <summary>
        /// en metode der retuner prisen for en bil
        /// </summary>
        /// <returns>prisen for en bil</returns>
        public override double Price()
        {
            if (Brobizz == true)
            {
                return 240 * 0.95;
            } 
            return 240;
        }
        /// <summary>
        /// en metode der retuner et object af en bil
        /// </summary>
        /// <returns>retuner en bil</returns>
        public override string VehicleType()
        {
            return "Car";
        }

        /// <summary>
        /// override variablerne typen til string 
        /// </summary>
        /// <returns>variablerne i strings</returns>
        public override string ToString()
        {
            return $"{nameof(LicensePlate)}: {LicensePlate}, {nameof(Date)}: {Date},";
        }

    }
}
