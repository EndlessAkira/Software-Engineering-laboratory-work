namespace OOP_Passenger_Operations
{
    internal class TransportManager
    {
        
        private static List<string> _busModels = new List<string> ()
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
        // Метод генерации модели автобуса
        public static string GenerateBusModel()
        {
            return _busModels[new Random().Next(_busModels.Count - 1)];
        }
        
        // Метод генерации вместительности автобуса
        public static int GenerateBusCapacity(string _busModel)
        {
            return _busCapacity[_busModel];
        }

        // Метод генерации процента изношенности автобуса
        public static int GenerateBusCondition()
        {
            return new Random().Next(0,100);
        }



        // Метод поиска самого вместительного автобуса компании
        public static Bus ReturnMostCapaciousBus(Bus[] _buses)
        {
            Bus _mostCapaciousBus = _buses[0];
            int _maxCapacity = _buses[0]._capacity;
            for(int i = 1; i < _buses.Length; i++)
            {
                if (_buses[i]._capacity > _maxCapacity)
                {
                    _mostCapaciousBus = _buses[i];
                    _maxCapacity = _buses[i]._capacity;
                }
            }
            return _mostCapaciousBus;
        }

        // Метод поиска самого популярного автобуса компании
        public static Bus ReturnMostPopularBus(Bus[] _buses)
        {
            int _maxCount = -1;
            Bus _mostPopularBus = _buses[0];

            foreach(Bus _hauptBus in _buses)
            {
                int _localCount = 0;
                foreach(Bus _bus in _buses)
                {
                    if(_hauptBus._modelName == _bus._modelName)
                    {
                        _localCount++;
                    }
                }
                if(_localCount > _maxCount)
                {
                    _mostPopularBus = _hauptBus;
                    _maxCount = _localCount;
                }
            }
            return _mostPopularBus;
        }

        // Метод поиска самого потрепанного автобуса
        public static Bus ReturnMaxConditionBus(Bus[] _buses)
        {
            int _maxCondition = -1;
            Bus _maxConditionBus = _buses[0];
            foreach(Bus _bus in _buses)
            {
                if(_bus._condition > _maxCondition)
                {
                    _maxConditionBus = _bus;
                    _maxCondition = _bus._condition;
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
                if (_bus._condition < _minCondition)
                {
                    _minConditionBus = _bus;
                    _minCondition = _bus._condition;
                }
            }
            return _minConditionBus;
        }









        // Метод возврата общей вместительности автобусов всех компаний
        public int ReturnTotalCapacity(TransportParks transportParks)
        {
            return transportParks._brestOblAvtoTrans._totalCapacityForCategory;
        }

        // Метод возврата самой вместительной модели автобуса из всех компаний
        public string ReturnCapacityModel(TransportParks transportParks)
        {
            return "";
        }

        // Метод возврата самой популярной модели автобуса из всех компаний
        public string ReturnPopularModel(TransportParks transportParks)
        {
            return "";
        }

        // Метод возврата маскимального процента изношенности автобуса из всех компаний
        public int ReturnMaxCondition(TransportParks transportParks)
        {
            return 0;
        }

        // Метод возврата минимального процента изношенности автобуса из всех компаний
        public int ReturnMinCondition(TransportParks transportParks)
        {
            return 0;
        }

        // Метод вывода данных об автобусах для каждой компании
        public string ReturnTotalTransportInfo(TransportParks _transportParks ,string _category)
        {
            return "";
        }
    }
}
