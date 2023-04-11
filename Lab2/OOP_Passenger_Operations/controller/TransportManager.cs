using OOP_Passenger_Operations.model;

namespace OOP_Passenger_Operations
{
    internal class TransportManager
    {

        private static List<string> _busModels = new List<string>()
        {
            "МАЗ-241",
            "МАЗ-103",
            "МАЗ-251",
            "МАЗ-107",
            "МАЗ-152",
            "МАЗ-216",
        };
        private static Dictionary<string, int> _busCapacity = new Dictionary<string, int>()
        {
            ["МАЗ-241"] = 20,
            ["МАЗ-103"] = 100,
            ["МАЗ-251"] = 125,
            ["МАЗ-107"] = 45,
            ["МАЗ-152"] = 45,
            ["МАЗ-216"] = 190
        };
        private int _currentParkIndex;



        // Метод генерации модели автобуса
        public static string GenerateBusModel()
        {
            return _busModels[new Random().Next(_busModels.Count - 1)];
        }
        // Метод генерации гаражного номера
        public static string GenerateGarageNumber()
        {
            string number = "";
            for (int i = 0; i < 7; i++)
                number += Convert.ToString(new Random().Next(0, 100));
            return number;
        }
        // Метод генерации вместительности автобуса
        public static int GenerateBusCapacity(string _busModel)
        {
            return _busCapacity[_busModel];
        }
        // Метод генерации процента изношенности автобуса
        public static int GenerateBusCondition()
        {
            return new Random().Next(0, 100);
        }



        // Метод поиска самого вместительного автобуса компании
        public static Bus ReturnMostCapaciousBus(Bus[] _buses)
        {
            Bus _mostCapaciousBus = _buses[0];
            int _maxCapacity = _buses[0].GetModelCapacity();
            for (int i = 1; i < _buses.Length; i++)
            {
                if (_buses[i].GetModelCapacity() > _maxCapacity)
                {
                    _mostCapaciousBus = _buses[i];
                    _maxCapacity = _buses[i].GetModelCapacity();
                }
            }
            return _mostCapaciousBus;
        }
        // Метод поиска самого популярного автобуса компании
        public static Bus ReturnMostPopularBus(Bus[] _buses)
        {
            Bus _mostCapaciousBus = _buses[0];
            int _maxCapacity = _buses[0].GetModelCapacity();
            for (int i = 1; i < _buses.Length; i++)
            {
                if (_buses[i].GetModelCapacity() > _maxCapacity)
                {
                    _mostCapaciousBus = _buses[i];
                    _maxCapacity = _buses[i].GetModelCapacity();
                }
            }
            return _mostCapaciousBus;
        }
        // Метод поиска самого потрепанного автобуса
        public static Bus ReturnMaxConditionBus(Bus[] _buses)
        {
            int _maxCondition = -1;
            Bus _maxConditionBus = _buses[0];
            foreach (Bus _bus in _buses)
            {
                if (_bus.GetModelCondition() > _maxCondition)
                {
                    _maxConditionBus = _bus;
                    _maxCondition = _bus.GetModelCondition();
                }
            }
            return _maxConditionBus;
        }
        // Метод поиска самого целого автобуса
        public static Bus ReturnMinConditionBus(Bus[] _buses)
        {
            int _minCondition = 101;
            Bus _minConditionBus = _buses[0];
            foreach (Bus _bus in _buses)
            {
                if (_bus.GetModelCondition() < _minCondition)
                {
                    _minConditionBus = _bus;
                    _minCondition = _bus.GetModelCondition();
                }
            }
            return _minConditionBus;
        }



        // Метод возврата общей вместительности автобусов всех компаний
        public int ReturnTotalCapacity(TransportParks transportParks)
        {
            return 0;
        }
        // Метод возврата самой вместительной модели автобуса из всех компаний
        public string ReturnCapacityModel(TransportParks transportParks)
        {
            return "хухуй";
        }
        // Метод возврата самой популярной модели автобуса из всех компаний
        public string ReturnPopularModel(TransportParks transportParks)
        {
            return "хуй";
        }
        // Метод возврата маскимального процента изношенности автобуса из всех компаний
        public int ReturnMaxCondition(TransportParks transportParks)
        {
            List<Bus> list = new();
            for (int i = 0; i < transportParks._parks.Length; i++)
            {
                list.Add(transportParks._parks[i]._minConditionBus);
            }
            int _maxCondition = -1;
            foreach (Bus bus in list)
            {
                if (bus.GetModelCondition() > _maxCondition)
                {
                    _maxCondition = bus.GetModelCondition();
                }
            }
            return _maxCondition;
        }
        // Метод возврата минимального процента изношенности автобуса из всех компаний
        public int ReturnMinCondition(TransportParks transportParks)
        {
            List<Bus> list = new();
            for (int i = 0; i < transportParks._parks.Length; i++)
            {
                list.Add(transportParks._parks[i]._minConditionBus);
            }
            int _minCondition = 101;
            foreach(Bus bus in list)
            {
                if(bus.GetModelCondition() < _minCondition)
                {
                    _minCondition = bus.GetModelCondition();
                }
            }
            return _minCondition;
        }
        // Метод вывода данных об автобусах для каждой компании



        public string ReturnTotalTransportInfo(TransportParks _transportParks, TransportParks.TransportPark park)
        {

            _currentParkIndex = (int)park;
            return $"                        Информация об автопарке {_transportParks._parks[_currentParkIndex].GetBusParkName()}\r\n            " +
            $"============================================================================================\r\n" +
            $"{_transportParks._parks[_currentParkIndex].ReturnTransportInfo()}\r\n" +
            $"            Самая вместительная модель автопарка: {_transportParks._parks[_currentParkIndex].ReturnMostCapacityBusForCategory().GetModelName()} - {_transportParks._parks[_currentParkIndex]._mostCapaciousBus.GetModelCapacity()} чел.\r\n" +
            $"            Самая популярная модель автопарка: {_transportParks._parks[_currentParkIndex].ReturnMostPopularBusForCategory().GetModelName()}\r\n" +
            $"            Самый изношенный автобус автопарка: {_transportParks._parks[_currentParkIndex].ReturnMaxConditionBusForCategory().GetModelName()} - {_transportParks._parks[_currentParkIndex].ReturnMaxConditionBusForCategory().GetModelCondition()} %\r\n" +
            $"            Cамый неизношенный автобус автопарка: {_transportParks._parks[_currentParkIndex].ReturnMinConditionBusForCategory().GetModelName()} - {_transportParks._parks[_currentParkIndex].ReturnMinConditionBusForCategory().GetModelCondition()} %\r\n" +
            $"            Общая вместительность автопарка: {_transportParks._parks[_currentParkIndex].ReturnTotalCapacityForCategory()} человек\r\n";
        }
    }
}