namespace OOP_Passenger_Operations
{
    public class MainClass
    {
        private static TransportParks _transportParks;
        private static TransportManager _transportManager;
        public static void Main(string[] args)
        {
            // Создание объектов классов TransportParks и TransportManager
            _transportParks = new TransportParks();
            _transportManager = new TransportManager();

            //// Вывод общей информации по автобусным паркам
            //Console.WriteLine("\n\n            ////////////////////////////////////////////////////////////////////////// ОБРАЗЕЦ РАБОТЫ #1");
            //Console.WriteLine($"{_transportManager.ReturnTotalTransportInfo(_transportParks, TransportParks.TransportPark.AllParks)}");

            // Вывод информации по БрестОблАвтоТрансу
            Console.WriteLine("            ////////////////////////////////////////////////////////////////////////// ОБРАЗЕЦ РАБОТЫ #2");
            Console.WriteLine($"{_transportManager.ReturnTotalTransportInfo(_transportParks, TransportParks.TransportPark.BrestOblAvtoTrans)}");

            //// Вывод информации по МинскОблАвтоТрансу
            Console.WriteLine("            ////////////////////////////////////////////////////////////////////////// ОБРАЗЕЦ РАБОТЫ #3");
            Console.WriteLine($"{_transportManager.ReturnTotalTransportInfo(_transportParks, TransportParks.TransportPark.MinskOblAvtoTrans)}");

            //// Вывод информации по ВитебскОблАвтоТрансу
            Console.WriteLine("            ////////////////////////////////////////////////////////////////////////// ОБРАЗЕЦ РАБОТЫ #4");
            Console.WriteLine($"{_transportManager.ReturnTotalTransportInfo(_transportParks, TransportParks.TransportPark.VitebskOblAvtoTrans)}");
        }
    }
}

