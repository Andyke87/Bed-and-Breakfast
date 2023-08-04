namespace BedAndBreakfast.Domain
{
    public class BoekingWeek : IReservatie
    {
        public void InfoReservatie()
        {
            Console.WriteLine("De week is geboekt!");
            VoorzieActiviteit();
            MaakKamersVrij();
            VoorzieMaaltijden();
        }

        public void VoorzieActiviteit()
        {
            Console.WriteLine("De activiteit voor de week is voorzien.");
        }

        public void MaakKamersVrij()
        {
            Console.WriteLine("De kamer(s) voor de week is vrijgemaakt.");
        }

        public void VoorzieMaaltijden()
        {
            Console.WriteLine("De maaltijden voor de week zijn voorzien.");
        }
    }
}