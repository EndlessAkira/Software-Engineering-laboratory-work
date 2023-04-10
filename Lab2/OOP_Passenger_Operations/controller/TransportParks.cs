namespace OOP_Passenger_Operations
{
    internal class TransportParks
    {
        public BrestOblAvtoTrans _brestOblAvtoTrans;
        public MinskOblAvtoTrans _minskOblAvtoTrans;
        public VitebskOblAvtoTrans _vitebskOblAvtoTrans;

        public OblAvtoTrans[] _parks;
        public enum TransportPark
        {
            
            BrestOblAvtoTrans,
            MinskOblAvtoTrans,
            VitebskOblAvtoTrans,
            AllParks
        }
        public TransportParks()
        {
            Console.WriteLine("Отработал конструктор объекта класса TransportParks");

            _brestOblAvtoTrans = new BrestOblAvtoTrans();
            _minskOblAvtoTrans = new MinskOblAvtoTrans();
            _vitebskOblAvtoTrans = new VitebskOblAvtoTrans();

            _parks = new OblAvtoTrans[] { _brestOblAvtoTrans, _minskOblAvtoTrans, _vitebskOblAvtoTrans };
        }
        public string GetInfo()
        {
            return "";
        }
        ~TransportParks()
        {
            Console.WriteLine("Отработал деструктор объекта класса TransportParks");
        }
    }
}

