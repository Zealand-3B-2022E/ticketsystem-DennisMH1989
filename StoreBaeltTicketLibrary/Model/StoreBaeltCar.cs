using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary.Model;

namespace StoreBaeltTicketLibrary.Model
{
    /// <summary>
    /// subclass as car lavede for storebaelt hvor den tager højde for om det er weekend eller ej når det gælde rabat for biler
    /// </summary>
    public class StoreBaeltCar : Car
    {
        /// <summary>
        /// constroctor der arver fra car
        /// </summary>
        /// <param name="_licensePlate"></param>
        /// <param name="_date"></param>
        /// <param name="_brobizz"></param>
        public StoreBaeltCar(string _licensePlate, DateTime _date, bool _brobizz): base(_licensePlate, _date, _brobizz)
        {

        }

        /// <summary>
        /// defoult constroctor
        /// </summary>
        public StoreBaeltCar()
        {

        }
        /// <summary>
        /// en metode der retuner prisen for en bil, hvor der er rabat i weekender og yderlige rabt hvis man har brobizz
        /// </summary>
        /// <returns>prisen for en bil, med eller uden brobizz og med eller uden weekend</returns>
        public override double Price()
        {
            var date = Date;
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                if (Brobizz == true)
                {
                    return 240 * 0.80 * 0.95;

                }
                return 240 * 0.80; 
            }
            else if (date.DayOfWeek == DayOfWeek.Monday || date.DayOfWeek == DayOfWeek.Tuesday || date.DayOfWeek == DayOfWeek.Wednesday || date.DayOfWeek==DayOfWeek.Thursday || date.DayOfWeek == DayOfWeek.Friday)
            {
                if (Brobizz == true)
                {
                    return 240 * 0.95;
                }
            }
            return 240;
        }

    }
}
