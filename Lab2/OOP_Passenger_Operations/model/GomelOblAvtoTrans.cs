using OOP_Passenger_Operations.model.other;

namespace OOP_Passenger_Operations.model
{
    internal class GomelOblAvtoTrans: OblAvtoTrans
    {
        public GomelOblAvtoTrans(string _parkName = "ГомельОблАвтоТранс", int _busCount = 19)
        {
            BaseConstructor(_parkName, _busCount);
        }
    }
}
