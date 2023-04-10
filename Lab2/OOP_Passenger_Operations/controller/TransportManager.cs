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
            return new Random().Next(0, 100);
        }

        // Метод поиска самого вместительного автобуса компании
        public string ReturnModelNameMostCapaciousBus(Bus[] _buses)
        {
            string _mostCapaciousBus = _buses[0]._modelName;
            int _maxCapacity = _buses[0]._capacity;
            for (int i = 1; i < _buses.Length; i++)
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
<<<<<<< Updated upstream
            string _mostPopularBus = _buses[0]._modelName;
            int _maxCount = 0;
            for(int i = 0; i < _buses.Length - 1; i++)
            {
                int _localCount = 1;
                for(int j = i + 1; j < _buses.Length; j++)
                {
                    if (_buses[i]._modelName == _buses[j]._modelName)
=======
            int _maxCount = -1;
            Bus _mostPopularBus = _buses[0];

            foreach (Bus _hauptBus in _buses)
            {
                int _localCount = 0;
                foreach (Bus _bus in _buses)
                {
                    if (_hauptBus._modelName == _bus._modelName)
>>>>>>> Stashed changes
                    {
                        _localCount++;
                    }
                }
                if (_localCount > _maxCount)
                {
                    _mostPopularBus = _buses[i]._modelName;
                    _maxCount = _localCount;
                }
            }

            return _mostPopularBus;
        }

<<<<<<< Updated upstream
=======
        // Метод поиска самого потрепанного автобуса
        public static Bus ReturnMaxConditionBus(Bus[] _buses)
        {
            int _maxCondition = -1;
            Bus _maxConditionBus = _buses[0];
            foreach (Bus _bus in _buses)
            {
                if (_bus._condition > _maxCondition)
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









>>>>>>> Stashed changes
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
        public string ReturnTotalTransportInfo(TransportParks _transportParks, TransportParks.TransportPark park)
        {
            
            _currentParkIndex = (int)park;
            return $"                        Информация об автопарке {_transportParks._parks[_currentParkIndex].GetCompanyName()}\r\n            " +
            $"============================================================================================\r\n" +
            $"{_transportParks._parks[_currentParkIndex].ReturnTransportInfo()}\r\n" +
            $"            Самая вместительная модель автопарка: {_transportParks._parks[_currentParkIndex].ReturnMostCapacityBusForCategory()._modelName} - {_transportParks._parks[_currentParkIndex]._mostCapaciousBus._capacity} чел.\r\n" +
            $"            Самая популярная модель автопарка: {_transportParks._parks[_currentParkIndex].ReturnMostPopularBusForCategory()._modelName}\r\n" +
            $"            Самый изношенный автобус автопарка: {_transportParks._parks[_currentParkIndex].ReturnMaxConditionBusForCategory()._modelName} - {_transportParks._parks[_currentParkIndex].ReturnMaxConditionBusForCategory()._condition} %\r\n" +
            $"            Cамый неизношенный автобус автопарка: {_transportParks._parks[_currentParkIndex].ReturnMinConditionBusForCategory()._modelName} - {_transportParks._parks[_currentParkIndex].ReturnMinConditionBusForCategory()._condition} %\r\n" +
            $"            Общая вместительность автопарка: {_transportParks._parks[_currentParkIndex].ReturnTotalCapacityForCategory()} человек\r\n";
        }
    }
}
        //else
        //{
        //    return $"                        Информация об автопарке {park.ToString()}\r\n            " +
        //        $"============================================================================================\r\n" +
        //        $"            {_transportParks._brestOblAvtoTrans.ReturnTransportInfo()}\\n\r\n" +
        //        $"            Самая вместительная модель автопарка: {_transportParks._brestOblAvtoTrans.ReturnMostCapacityBusForCategory()} - {_transportParks._brestOblAvtoTrans._mostCapaciousBus._capacity} чел.\r\n" +
        //        $"            Самая популярная модель автопарка: {{user.brest_obl_avto_trans.return_popular_model_for_category()}}\r\n" +
        //        $"            Max condition for category == {{user.brest_obl_avto_trans.return_max_condition_for_category()}} %\r\n" +
        //        $"            Min condition for category == {{user.brest_obl_avto_trans.return_min_condition_for_category()}} %\r\n" +
        //        $"            Total capacity for category == {{user.brest_obl_avto_trans.return_total_capacity_for_category()}} человек\r\n            Total capacity for all == {{self.return_total_capacity(user=user)}} человек"
