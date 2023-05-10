using OOP_Passenger_Operations.model;
using OOP_Passenger_Operations.model.other;

namespace OOP_Passenger_Operations
{
    public class NationalBusPark
    {
        public static readonly int _numberOfRegions = 7;
        internal List<OblAvtoTrans> _parks = new List<OblAvtoTrans>();
        public enum TransportParkList
        {
            BrestOblAvtoTrans,
            VitebskOblAvtoTrans,
            GomelOblAvoTrans,
            GrodnoOblAvtoTrans,
            MinskOblAvtoTrans,
            MogilevOblAvtoTrans,
            MinskTrans,
            AllParks
        }
        public NationalBusPark()
        {
            for(int i = 0; i < _numberOfRegions; i++)
            {
                _parks.Add(null);
            }
        }
        public bool AddBusPark(TransportParkList _index, string _parkName, int _busCount)
        {
            if (_parks[(int)_index] == null)
            {
                switch (_index)
                {
                    case TransportParkList.BrestOblAvtoTrans:
                        _parks[(int)_index] = new BrestOblAvtoTrans(_parkName, _busCount);
                        break;
                    case TransportParkList.VitebskOblAvtoTrans:
                        _parks[(int)_index] = new VitebskOblAvtoTrans(_parkName, _busCount);
                        break;
                    case TransportParkList.GomelOblAvoTrans:
                        _parks[(int)_index] = new GomelOblAvtoTrans(_parkName, _busCount);
                        break;
                    case TransportParkList.GrodnoOblAvtoTrans:
                        _parks[(int)_index] = new GrognoOblAvtoTrans(_parkName, _busCount);
                        break;
                    case TransportParkList.MinskOblAvtoTrans:
                        _parks[(int)_index] = new MinskOblAvtoTrans(_parkName, _busCount);
                        break;
                    case TransportParkList.MogilevOblAvtoTrans:
                        _parks[(int)_index] = new MogilevOblAvtoTrans(_parkName, _busCount);
                        break;
                    case TransportParkList.MinskTrans:
                        _parks[(int)_index] = new MinskTrans(_parkName, _busCount);
                        break;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteBusPark(TransportParkList _index)
        {
            if (_parks[(int)_index] != null)
            {
                _parks[(int)_index] = null;
                return true;
            }
            else
                return false;
        }
        public bool IsFill()
        {
            bool result = true;
            for (int i = 0; i < _numberOfRegions; i++)
            {
                result = result && (_parks[i] != null);
            }
            return result;
        }
        public bool IsEmpty()
        {
            bool result = true;
            for (int i = 0; i < _numberOfRegions; i++)
            {
                result = result && (_parks[i] == null);
            }
            return result;
        }
    }
}