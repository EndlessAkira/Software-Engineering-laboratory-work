using OOP_Passenger_Operations.model;

namespace OOP_Passenger_Operations
{
    internal class TransportParks
    {
        public static readonly int _numberOfRegions = 7;
        public List<OblAvtoTrans> _parks = new List<OblAvtoTrans>();
        internal enum TransportParkList
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
        public TransportParks()
        {
            for(int i = 0; i < _numberOfRegions; i++)
            {
                _parks.Add(null);
            }
            Console.WriteLine("Отработал конструктор объекта класса TransportParks");
        }
        public bool AddBusPark(TransportParkList _index)
        {
            if (_parks[(int)_index] == null)
            {
                switch (_index)
                {
                    case TransportParkList.BrestOblAvtoTrans:
                        _parks[(int)_index] = new BrestOblAvtoTrans();
                        break;
                    case TransportParkList.VitebskOblAvtoTrans:
                        _parks[(int)_index] = new VitebskOblAvtoTrans();
                        break;
                    case TransportParkList.GomelOblAvoTrans:
                        _parks[(int)_index] = new GomelOblAvtoTrans();
                        break;
                    case TransportParkList.GrodnoOblAvtoTrans:
                        _parks[(int)_index] = new GrognoOblAvtoTrans();
                        break;
                    case TransportParkList.MinskOblAvtoTrans:
                        _parks[(int)_index] = new MinskOblAvtoTrans();
                        break;
                    case TransportParkList.MogilevOblAvtoTrans:
                        _parks[(int)_index] = new MogilevOblAvtoTrans();
                        break;
                    case TransportParkList.MinskTrans:
                        _parks[(int)_index] = new MinskTrans();
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
        ~TransportParks()
        {
            Console.WriteLine("Отработал деструктор объекта класса TransportParks");
        }
    }
}

