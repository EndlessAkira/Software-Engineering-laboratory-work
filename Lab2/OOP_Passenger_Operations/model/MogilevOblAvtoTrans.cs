using OOP_Passenger_Operations.model.other;

namespace OOP_Passenger_Operations.model
{
    internal class MogilevOblAvtoTrans: OblAvtoTrans
    {
        public MogilevOblAvtoTrans(string _parkName = "МогилёвОблАвтоТранс", int _busCount = 17)
        {
            BaseConstructor(_parkName, _busCount);
        }
    }
}
