using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedAndBreakfast.Domain;

namespace BedAndBreakfast.Domain
{
    public class BoekingFactory
    {
        public IReservatie MaakBoeking(Boekingstypes bt)
        {
            switch (bt)
            {
                case Boekingstypes.Weekend:
                    return new BoekingWeekend();
                case Boekingstypes.Midweek:
                    return new BoekingMidweek();
                case Boekingstypes.Week:
                    return new BoekingWeek();
                default:
                    throw new ArgumentException("Ongeldig boekingtype");
            }
        }
    }
}
