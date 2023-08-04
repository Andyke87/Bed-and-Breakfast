namespace BedAndBreakfast.Domain
{
    public class BoekingMidweek : IReservatie
    {
        public void InfoReservatie()
        {
            Console.WriteLine("De midweek is geboekt!");
            VoorzieActiviteit();
            MaakKamersVrij();
            VoorzieMaaltijden();
        }

        public void VoorzieActiviteit()
        {
            Console.WriteLine("De activiteit voor de midweek is voorzien.");
        }

        public void MaakKamersVrij()
        {
            Console.WriteLine("De kamer(s) voor de midweek is vrijgemaakt.");
        }

        public void VoorzieMaaltijden()
        {
            Console.WriteLine("De maaltijden voor de midweek zijn voorzien.");
        }
    }
}