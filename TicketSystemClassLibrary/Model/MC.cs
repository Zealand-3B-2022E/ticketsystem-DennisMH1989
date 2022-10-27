using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Model
{
    /// <summary>
    /// en class der kan oprette et object af en MC
    /// </summary>
    public class MC : Vehicle
    {
        private DateTime _date;

        private bool _brobizz;
        
        /// <summary>
        /// property til at hente og sætte datoen for overkørselsen
        /// </summary>
        public override DateTime Date { get; set; }
        /// <summary>
        /// property til at hente og sætte om MC har brobizz
        /// </summary>
        public override bool Brobizz { get; set; }
        /// <summary>
        /// defoult constroctor for Mc
        /// </summary>
        public MC()
        {
            LicensePlate = "0000000";
            Date= DateTime.Now;
            Brobizz = false;
        }
        /// <summary>
        /// konstroctor med parameterne 
        /// </summary>
        /// <param name="_licensePlate"></param>
        /// <param name="_date"></param>
        /// <param name="_brobizz"></param>
        public MC(string _licensePlate,DateTime _date, bool _brobizz)
        {
            LicensePlate = _licensePlate;
            Date = _date;
            Brobizz = _brobizz;
        }
        /// <summary>
        /// en metode der give prisen for en motorcykle
        /// </summary>
        /// <returns>prisen for en motorcykle</returns>

        public override double Price()
        {
            if (Brobizz == true)
            {
                return 125 * 0.95;
            }
            return 125;
        }
        /// <summary>
        /// en metode der retuner et object af en motorcykle
        /// </summary>
        /// <returns>retuner en motorcykle</returns>
        public override string VehicleType()
        {
            return "MC";
        }

        /// <summary>
        /// override variablerne typen til string 
        /// </summary>
        /// <returns>variablerne i strings</returns>
        public override string ToString()
        {
            return $"{nameof(LicensePlate)}: {LicensePlate},{nameof(Date)}:{Date}";
        }

    }
}
