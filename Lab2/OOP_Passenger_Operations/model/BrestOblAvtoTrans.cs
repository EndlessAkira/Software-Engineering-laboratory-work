using OOP_Passenger_Operations.model.other;

namespace OOP_Passenger_Operations.model
{
    internal class BrestOblAvtoTrans : OblAvtoTrans
    {
        public BrestOblAvtoTrans(string _parkName = "БрестОблАвтоТранс", int _busCount = 20)
        {
            BaseConstructor(_parkName, _busCount);
        }
    }
}
