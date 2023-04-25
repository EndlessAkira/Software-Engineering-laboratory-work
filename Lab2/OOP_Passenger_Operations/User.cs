using OOP_Passenger_Operations.user;

namespace OOP_Passenger_Operations
{
    internal class User
    {
        private static NationalBusParkApplication _app = new();
        internal static int Main(string[] args)
        {
            _app.Start();
            return 0;
        }
    }
}
