namespace OOP_Passenger_Operations
{
    internal class BrestOblAvtoTrans : OblAvtoTrans
    {
        public BrestOblAvtoTrans()
        {
            for(int i = 0; i < buses.Length; i++) 
            {
                buses[i] = new Bus();
                buses[i]._modelName = TransportManager.GenerateBusModel();
                buses[i]._capacity = TransportManager.GenerateBusCapacity(buses[i]._modelName);
                buses[i]._condition = TransportManager.GenerateBusCondition();
            }
        }
        
        public override string ReturnTransportInfo()
        {
            string message = "";
            for(int i = 0; i < buses.Length; i++)
            {
                message += $"Автобус БрестОблАвтоТранс #{i + 1} : модель - {buses[i]._modelName}, вместимость == {buses[i]._capacity}, изношенность == {buses[i]._condition} %\r\n";
            }
            return message;
        }
        public override int ReturnTotalCapacityForCategory()
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

        public override Bus ReturnMostCapacityBusForCategory()
        {
            if(_mostCapaciousBus == null)
            {
                _mostCapaciousBus = TransportManager.ReturnMostCapaciousBus(buses);
            }
            return _mostCapaciousBus;
        }

        public override Bus ReturnMostPopularBusForCategory()
        {
            if(_mostPopularBus == null)
            {
                _mostPopularBus = TransportManager.ReturnMostPopularBus(buses);
            }
            return _mostPopularBus;
        }

        public override Bus ReturnMaxConditionBusForCategory()
        {
            if(_maxConditionBus == null)
            {
                _maxConditionBus = TransportManager.ReturnMaxConditionBus(buses);
            }
            return _maxConditionBus;
        }

        public override Bus ReturnMinConditionBusForCategory()
        {
            if(_minConditionBus == null)
            {
                _minConditionBus = TransportManager.ReturnMinConditionBus(buses);
            }
            return _minConditionBus;
        }
    }
}
