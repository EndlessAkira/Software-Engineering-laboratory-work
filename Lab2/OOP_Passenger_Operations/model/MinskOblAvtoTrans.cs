using OOP_Passenger_Operations.model.other;

namespace OOP_Passenger_Operations.model
{
    internal class MinskOblAvtoTrans : OblAvtoTrans
    {
        public MinskOblAvtoTrans(string _parkName = "МинскОблАвтоТранс", int _busCount = 22)
        {
            BaseConstructor(_parkName, _busCount);
        }
    }
}
