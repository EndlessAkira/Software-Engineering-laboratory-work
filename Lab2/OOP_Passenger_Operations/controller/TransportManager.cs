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
        public string GenerateBusModel()
        {
            return _busModels[new Random().Next(_busModels.Count - 1)];
        }
        
        // Метод генерации вместительности автобуса
        public int GenerateBusCapacity(string _busModel)
        {
            return _busCapacity[_busModel];
        }

        // Метод генерации процента изношенности автобуса
        public int GenerateBusCondition()
        {
            return new Random().Next(0,100);
        }

        // Метод поиска самого вместительного автобуса компании
        public string ReturnModelNameMostCapaciousBus(Bus[] _buses)
        {
            string _mostCapaciousBus = _buses[0]._modelName;
            int _maxCapacity = _buses[0]._capacity;
            for(int i = 1; i < _buses.Length; i++)
            {
                if (_buses[i]._capacity > _maxCapacity)
                {
                    _mostCapaciousBus = _buses[i]._modelName;
                    _maxCapacity = _buses[i]._capacity;
                }
            }
            return _mostCapaciousBus;
        }

        // Метод поиска самого популярного автобуса компании
        public string ReturnModelNameMostPopularBus(Bus[] _buses)
        {
            string _mostPopularBus = _buses[0]._modelName;
            int _maxCount = 0;
            for(int i = 0; i < _buses.Length - 1; i++)
            {
                int _localCount = 1;
                for(int j = i + 1; j < _buses.Length; j++)
                {
                    if (_buses[i]._modelName == _buses[j]._modelName)
                    {
                        _localCount++;
                    }
                }
                if(_localCount > _maxCount)
                {
                    _mostPopularBus = _buses[i]._modelName;
                    _maxCount = _localCount;
                }
            }

            return _mostPopularBus;
        }

        // Метод возврата общей вместительности автобусов всех компаний
        public int ReturnTotalCapacity(TransportParks transportParks)
        {
            return transportParks._brestOblAvtoTrans._totalCapacityForCategory;
        }

        // Метод возврата самой вместительной модели автобуса из всех компаний
        public string ReturnCapacityModel(TransportParks transportParks)
        {
            int[] _capacity = { transportParks._brestOblAvtoTrans._mostCapacity };
            string[] _models = { transportParks._brestOblAvtoTrans._modelNameMostCapaciousBus };

            int _maxCapacity = _capacity[0];
            string _modelNameMaxCapaciousBus = _models[0];

            for(int i = 1; i < _capacity.Length; i ++)
            {
                if (_capacity[i] > _maxCapacity)
                {
                    _modelNameMaxCapaciousBus = _models[i];
                    _maxCapacity = _capacity[i];
                }
            }
            return _modelNameMaxCapaciousBus;
        }

        // Метод возврата самой популярной модели автобуса из всех компаний
        public string ReturnPopularModel(TransportParks transportParks)
        {
            int[] _popular = { transportParks._brestOblAvtoTrans._maxCount };
            string[] _models = { transportParks._brestOblAvtoTrans._modelNameMostPopularBus };

            int _maxPopular = _popular[0];
            string _modelNameMostPopularBus = _models[0];

            for (int i = 1; i < _popular.Length; i++)
            {
                if (_popular[i] > _maxPopular)
                {
                    _modelNameMostPopularBus = _models[i];
                    _maxPopular = _popular[i];
                }
            }
            return _modelNameMostPopularBus;
        }

        // Метод возврата маскимального процента изношенности автобуса из всех компаний
        public int ReturnMaxCondition(TransportParks transportParks)
        {
            return Math.Max(transportParks._brestOblAvtoTrans._maxCondition, transportParks._brestOblAvtoTrans._maxCondition);
        }

        // Метод возврата минимального процента изношенности автобуса из всех компаний
        public int ReturnMinCondition(TransportParks transportParks)
        {
            return Math.Min(transportParks._brestOblAvtoTrans._minCondition, transportParks._brestOblAvtoTrans._minCondition);
        }

        // Метод вывода данных об автобусах для каждой компании
        public string ReturnTotalTransportInfo(TransportParks _transportParks ,string _category)
        {
            return "";
        }
    }
}
