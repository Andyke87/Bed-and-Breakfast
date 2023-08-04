namespace BedAndBreakfast.Domain
{
    public class BedAndBreakfast
    {
        private BoekingFactory _boekingFactory;
        private List<IReservatie> _reservaties;

        public BedAndBreakfast() 
        {
            _boekingFactory = new();
            _reservaties = new List<IReservatie>();
        }
        public IReservatie MaakReservatie(Boekingstypes bt)
        { 
            _reservaties.Add(_boekingFactory.MaakBoeking(bt));
            return _boekingFactory.MaakBoeking(bt);
        }
        public IReservatie WijzigBoeking(Boekingstypes bt, int index)
        {
            _reservaties.RemoveAt(index-1);
            _reservaties.Insert(index-1, _boekingFactory.MaakBoeking(bt));
            return _boekingFactory.MaakBoeking(bt);

        }
        public List<IReservatie> ToonReservaties()
        {

            return _reservaties;
        }

      
    }
}