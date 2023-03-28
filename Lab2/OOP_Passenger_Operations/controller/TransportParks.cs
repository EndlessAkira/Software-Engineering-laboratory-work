namespace OOP_Passenger_Operations
{
    internal class TransportParks
    {
        public BrestOblAvtoTrans _brestOblAvtoTrans;
        // public MiskOblAvtoTrans _minskOblAvtoTrans;
        // publuc VitebskOblAvtoTrans _vitebskOblAvtoTrans;
        public TransportParks()
        {
            Console.WriteLine("Отработал конструктор объекта класса TransportParks");

            _brestOblAvtoTrans = new BrestOblAvtoTrans();
            //_minskOblAvtoTrans = new MiskOblAvtoTrans();
            //_vitebskOblAvtoTrans = new VitebskOblAvtoTrans();
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

