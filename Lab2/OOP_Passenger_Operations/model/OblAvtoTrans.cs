namespace OOP_Passenger_Operations
{
    abstract internal class OblAvtoTrans
    {
        protected string _companyName = null;

        // Поле автобусов компании
        protected Bus[] buses;

        // Общая вместительность автобусов компании
        public int _totalCapacityForCategory => ReturnTotalCapacityForCategory();

        // Вместительность и название самого вместительного автобуса компании
        public int _mostCapacity => ReturnMaxNumberCapacityBusesForCategory();
        public string _modelNameMostCapaciousBus => ReturnCapacityModelForCategory();

        // Кол-во шт. и название самого популярного автобуса компании
        public int _maxCount => ReturnMaxNumberIdenticalBusesForCategory();
        public string _modelNameMostPopularBus => ReturnPopularModelForCategory();

        // Проценты самого изношенного и самого целого автобусов компании
        public int _maxCondition => ReturnMaxConditionForCategory();
        public int _minCondition => ReturnMinConditionForCategory();

        protected void BaseConstructor(string _name, int busCount = 5)
        {
            _companyName = _name;
            buses = new Bus[busCount];
            for (int i = 0; i < busCount; i++)
            {
                buses[i] = new Bus();
                buses[i]._modelName = TransportManager.GenerateBusModel();
                buses[i]._capacity = TransportManager.GenerateBusCapacity(buses[i]._modelName);
                buses[i]._condition = TransportManager.GenerateBusCondition();
            }
        }

        public string GetCompanyName() => _companyName;

        // Метод возврата текстовой информации об автобусах компании
        public string ReturnTransportInfo()
        {
            string message = "";
            for (int i = 0; i < buses.Length; i++)
            {
                message += $"            Автобус {_companyName} #{i + 1} : модель - {buses[i]._modelName}, вместимость == {buses[i]._capacity}, изношенность == {buses[i]._condition} %\r\n";
            }
            return message;
        }

        // Метод возврата общей вместительности автобусов компании (кол-во чел.)
        public int ReturnTotalCapacityForCategory()
        {
            if (_totalCapacityForCategory == _defaultInt)
            {
                _totalCapacityForCategory = 0;
                foreach (Bus bus in buses)
                {
                    _totalCapacityForCategory += bus._capacity;
                }
            }
            return _totalCapacityForCategory;
        }

        // Метод возврата названия модели самого вместительного автобуса компании
        public abstract string ReturnCapacityModelForCategory();

        // Метод возврата количества мест шт. самого вместительного автобуса
        public abstract int ReturnMaxNumberCapacityBusesForCategory();

<<<<<<< Updated upstream
        // Метод возврата количества шт. самого популярного автобуса
        public abstract int ReturnMaxNumberIdenticalBusesForCategory();

        // Метод возврата названия самой популярной модели автобуса компании
        public abstract string ReturnPopularModelForCategory();
=======
        // Метод возврата самого вместительного автобуса компании
        public Bus ReturnMostCapacityBusForCategory()
        {
            if (_mostCapaciousBus == null)
            {
                _mostCapaciousBus = TransportManager.ReturnMostCapaciousBus(buses);
            }
            return _mostCapaciousBus;
        }

        // Метод возврата самого популярного автобуса компании
        public Bus ReturnMostPopularBusForCategory()
        {
            if (_mostPopularBus == null)
            {
                _mostPopularBus = TransportManager.ReturnMostPopularBus(buses);
            }
            return _mostPopularBus;
        }
>>>>>>> Stashed changes

        // Метод возврата маскимального процента изношенности из всех автобусов компании
        public abstract int ReturnMaxConditionForCategory();

<<<<<<< Updated upstream
        // Метод возврата минимального процента изношенности из всех автобусов компании
        public abstract int ReturnMinConditionForCategory();
=======

        // Метод возврата самого изношенного автобуса компании
        public Bus ReturnMaxConditionBusForCategory()
        {
            if (_maxConditionBus == null)
            {
                _maxConditionBus = TransportManager.ReturnMaxConditionBus(buses);
            }
            return _maxConditionBus;
        }

        // Метод возврата самого целого автобуса компании
        public Bus ReturnMinConditionBusForCategory()
        {
            if (_minConditionBus == null)
            {
                _minConditionBus = TransportManager.ReturnMinConditionBus(buses);
            }
            return _minConditionBus;
        }
>>>>>>> Stashed changes
    }
}
