namespace BedAndBreakfast.Domain
{
    public class BoekingWeekend : IReservatie
    {
        public void InfoReservatie()
        {
            Console.WriteLine("Het weekend is geboekt!");
            VoorzieActiviteit();
            MaakKamersVrij();
            VoorzieMaaltijden();
        }

        public void VoorzieActiviteit()
        {
            Console.WriteLine("De activiteit voor het weekend is voorzien.");
        }

        public void MaakKamersVrij()
        {
            Console.WriteLine("De kamer(s) voor het weekend is vrijgemaakt.");
        }

        public void VoorzieMaaltijden()
        {
            Console.WriteLine("De maaltijden voor het weekend zijn voorzien.");
        }
    }
}