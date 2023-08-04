using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedAndBreakfast.Domain;

namespace BedAndBreakfast.Cui
{
    public class BedAndBreakfastApp
    {
        private Domain.BedAndBreakfast _beheerder;
        private IReservatie _reservatie;
        private List<IReservatie> _reservaties;
        public BedAndBreakfastApp()
        {
            _beheerder = new();
            _reservaties = new List<IReservatie>();
        }

        public void Start()
        {
            Console.WriteLine("Welkom bij de Bed and Breakfast!");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Reserveer een weekend");
                Console.WriteLine("2. Reserveer een midweek");
                Console.WriteLine("3. Reserveer een volledige week");
                Console.WriteLine("4. Laat boekingen zien");
                Console.WriteLine("5. Wijzig boeking");
                Console.WriteLine("6. Stop");

                Console.Write("Uw keuze: ");
                int keuze = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (keuze)
                {
                    case 1:
                        _reservatie = _beheerder.MaakReservatie(Boekingstypes.Weekend);
                        _reservatie.InfoReservatie();
                        break;
                    case 2:
                        _reservatie = _beheerder.MaakReservatie(Boekingstypes.Midweek);
                        _reservatie.InfoReservatie();
                        break;
                    case 3:
                        _reservatie = _beheerder.MaakReservatie(Boekingstypes.Week);
                        _reservatie.InfoReservatie();
                        break;
                    case 4:
                        _reservaties = _beheerder.ToonReservaties();
                        int i = 1;
                        foreach (var item in _reservaties)
                        {
                            Console.Write($"{i}: ");
                            item.InfoReservatie();
                            Console.WriteLine();
                            i++;
                        }
                        break;

                    case 5:
                        Console.WriteLine("Welke boeking wilt u wijzigen?");
                        int index = int.Parse(Console.ReadLine());
                        _reservaties = _beheerder.ToonReservaties();
                        foreach (var item in _reservaties)
                        {
                            item.InfoReservatie();

                        }

                        Console.WriteLine("\n1. Reserveer een weekend");
                        Console.WriteLine("2. Reserveer een midweek");
                        Console.WriteLine("3. Reserveer een volledige week");
                        Console.Write("Uw keuze: ");
                        int wisselKeuze = int.Parse(Console.ReadLine());
                        switch (wisselKeuze)
                        {
                            case 1:
                                _reservatie = _beheerder.WijzigBoeking(Boekingstypes.Weekend, index);
                                _reservatie.InfoReservatie();
                                break;
                            case 2:
                                _reservatie = _beheerder.WijzigBoeking(Boekingstypes.Midweek, index);
                                _reservatie.InfoReservatie();
                                break;
                            case 3:
                                _reservatie = _beheerder.WijzigBoeking(Boekingstypes.Week, index);
                                _reservatie.InfoReservatie();
                                break;
                            default:
                                Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Bedankt voor het gebruik van de Bed and Breakfast!");
                        return;
                    default:
                        Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                        break;
                }
            }
        }
    }
}
