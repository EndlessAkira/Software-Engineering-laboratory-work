using OOP_Passenger_Operations.model.other;

namespace OOP_Passenger_Operations.model
{
    internal class VitebskOblAvtoTrans : OblAvtoTrans
    {
        public VitebskOblAvtoTrans(string _parkName = "ВитебскОблАвтоТранс", int _busCount = 15)
        {
            BaseConstructor(_parkName, _busCount);
        }
    }
}
