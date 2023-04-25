using OOP_Passenger_Operations.model.other;

namespace OOP_Passenger_Operations.model
{
    internal class GrognoOblAvtoTrans: OblAvtoTrans
    {
        public GrognoOblAvtoTrans(string _parkName = "ГродноОблАвтоТранс", int _busCount = 15)
        {
            BaseConstructor(_parkName, _busCount);
        }
    }
}
