namespace OOP_Passenger_Operations
{
    public class NationalBusPark
    {
        private static TransportParks _transportParks;
        private static TransportManager _transportManager;
        public static void Main(string[] args)
        {
            CreateNationalBusPark();
            CreateNationalBusPark();


            AddOblAvtoTrans(TransportParks.TransportParkList.MinskOblAvtoTrans);
            AddOblAvtoTrans(TransportParks.TransportParkList.MinskOblAvtoTrans);
            PrintOblAvtoTransInfo(TransportParks.TransportParkList.MinskOblAvtoTrans);

            DeleteOblAvtoTrans(TransportParks.TransportParkList.MinskOblAvtoTrans);
            PrintOblAvtoTransInfo(TransportParks.TransportParkList.MinskOblAvtoTrans);
            DeleteOblAvtoTrans(TransportParks.TransportParkList.MinskOblAvtoTrans);

            DeleteNationalBusPark();
            DeleteNationalBusPark();
        }
        private static void CreateNationalBusPark()
        {
            if (_transportParks == null && _transportManager == null)
            {
                _transportParks = new TransportParks();
                _transportManager = new TransportManager();
                Console.WriteLine("Вы основали Национальный Автопарк!");
            }
            else
                Console.WriteLine("Основание невозможно - Национальный Автопарк уже создан!");
        }
        private static void DeleteNationalBusPark()
        {
            if (_transportParks != null && _transportManager != null)
            {
                _transportParks = null;
                _transportManager = null;
                Console.WriteLine("Национальный Автопарк был упразднён.");
            }
            else
                Console.WriteLine("Невозможно упразднить Национальный Автопарк.");
        }
        private static void AddOblAvtoTrans(TransportParks.TransportParkList park)
        {
            if(_transportParks.AddBusPark(park))
            {
                Console.WriteLine("Выбранный ОблАвтоТранс был успешно основан!");
            }
            else
            {
                Console.WriteLine("Выбранный ОблАвтоТранс уже был основан.");
            }
        }
        private static void DeleteOblAvtoTrans(TransportParks.TransportParkList park)
        {
            if(_transportParks.DeleteBusPark(park))
            {
                Console.WriteLine("Выбранный ОблАвтоТранс был успешно упразднён.");
            }
            else
            {
                Console.WriteLine("Невозможно упразднить выбранный ОблАвтоТранс.");
            }
        }
        private static void PrintOblAvtoTransInfo(TransportParks.TransportParkList park)
        {
            Console.WriteLine(_transportManager.ReturnTotalTransportInfo(_transportParks, park));
        }
        
    }
    public class MenuItem
    {
        private string _text;
        private bool _isAvailable;
        private Delegate _delegate;
        public MenuItem(string text, bool isAvailable, Delegate @delegate)
        {
            _text = text;
            _isAvailable = isAvailable;
            _delegate = @delegate;
        }
        public string GetText() => _text;
        public bool IsAvailable => _isAvailable;
        public Delegate GetDelegate => _delegate;
    }
}

