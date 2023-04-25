using OOP_Passenger_Operations.model.other;

namespace OOP_Passenger_Operations.model
{
    internal class MinskTrans: OblAvtoTrans
    {
        public MinskTrans(string _parkName = "МинскТранс", int _busCount = 29)
        {
            BaseConstructor(_parkName, _busCount);
        }
    }
}
