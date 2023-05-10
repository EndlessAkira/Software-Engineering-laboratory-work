using OOP_Passenger_Operations.model.other;

namespace OOP_Passenger_Operations
{
    public class StateBusInspection
    {
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
            Bus _mostPopularBus = _buses[0];
            int maxCount = 0;
            int count = 1;
            for(int i = 0; i < _buses.Length - 1; i++)
            {
                for(int j = i + 1; j < _buses.Length ; j++)
                {
                    if (_buses[i].GetModelName() == _buses[j].GetModelName())
                    {
                        count++;
                    }
                }
                if(count > maxCount)
                {
                    maxCount = count;
                    _mostPopularBus = _buses[i];
                }
                count = 1;
            }
            return _mostPopularBus;
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
        public int ReturnTotalCapacity(NationalBusPark _nationalBusPark)
        {
            int _totalCapacity = 0;
            foreach(OblAvtoTrans park in _nationalBusPark._parks)
            {
                if(park != null)
                    _totalCapacity += park.ReturnTotalCapacityForCategory();
            }
            return _totalCapacity;
        }
        // Метод возврата самой вместительной модели автобуса из всех компаний
        public Bus ReturnCapacityModel(NationalBusPark _nationalBusPark)
        {
            Bus _bus = new Bus("r", "0", 0, 100);
            foreach (OblAvtoTrans park in _nationalBusPark._parks)
            {
                if(park != null && park.ReturnMostCapacityBusForCategory().GetModelCapacity() > _bus.GetModelCapacity())
                {
                    _bus = park.ReturnMostCapacityBusForCategory();
                }
            }
            return _bus;

        }
        // Метод возврата самой популярной модели автобуса из всех компаний
        public Bus ReturnPopularModel(NationalBusPark _nationalBusPark)
        {
            int countOfBuses = 0;
            foreach(OblAvtoTrans park in _nationalBusPark._parks)
            {
                if(park != null)
                    countOfBuses += park.GetSizeBusPark();
            }

            Bus[] _buses = new Bus[countOfBuses];
            int counter = 0;
            for(int i = 0; i < _nationalBusPark._parks.Count; i++)
            {
                if (_nationalBusPark._parks[i] != null)
                {
                    for (int j = 0; j < _nationalBusPark._parks[i].GetSizeBusPark(); j++)
                    {
                        _buses[counter] = _nationalBusPark._parks[i].GetBus(j);
                        counter++;
                    }
                }
            }
            return ReturnMostPopularBus(_buses);
        }
        // Метод возврата маскимального процента изношенности автобуса из всех компаний
        public Bus ReturnMaxCondition(NationalBusPark _nationalBusPark)
        {
            List<Bus> list = new();
            for (int i = 0; i < _nationalBusPark._parks.Count; i++)
            {
                if (_nationalBusPark._parks[i] != null)
                {
                    list.Add(_nationalBusPark._parks[i].ReturnMinConditionBusForCategory());
                }
            }
            int _maxCondition = -1;
            Bus _bus = list[0];
            foreach (Bus bus in list)
            {
                if (bus.GetModelCondition() > _maxCondition)
                {
                    _bus = bus; 
                }
            }
            return _bus;
        }
        // Метод возврата минимального процента изношенности автобуса из всех компаний
        public Bus ReturnMinCondition(NationalBusPark _nationalBusPark)
        {
            List<Bus> list = new();
            for (int i = 0; i < _nationalBusPark._parks.Count; i++)
            {
                if (_nationalBusPark._parks[i] != null)
                {
                    list.Add(_nationalBusPark._parks[i]._minConditionBus);
                }
            }
            int _minCondition = 101;
            Bus _bus = list[0];
            foreach(Bus bus in list)
            {
                if(bus.GetModelCondition() < _minCondition)
                {
                    _bus = bus;
                }
            }
            return _bus;
        }
        // Метод вывода данных об автобусах для каждой компании



        public string ReturnTotalTransportInfo(NationalBusPark _nationalBusPark, NationalBusPark.TransportParkList park)
        {
            int _currentParkIndex = (int)park;
            if (park != NationalBusPark.TransportParkList.AllParks)
            {
                OblAvtoTrans _currentBusPark = _nationalBusPark._parks[_currentParkIndex];
                if (_currentBusPark != null)
                {
                    Bus _mostCapaciousBus = _currentBusPark.ReturnMostCapacityBusForCategory();
                    Bus _mostPopularBus = _currentBusPark.ReturnMostPopularBusForCategory();
                    Bus _maxConditionBus = _currentBusPark.ReturnMaxConditionBusForCategory();
                    Bus _minConditionBus = _currentBusPark.ReturnMinConditionBusForCategory();

                    string _returnMessage = "";
                    _returnMessage += $"                        Информация об автопарке {_currentBusPark.GetBusParkName()}\r\n            " +
                    $"============================================================================================\r\n" +
                    $"{_currentBusPark.ReturnTransportInfo()}\r\n" +
                    $"            Самая вместительная модель автопарка: {_mostCapaciousBus.GetModelName()} (ГН {_mostCapaciousBus.GetGarageNumber()}) - {_mostCapaciousBus.GetModelCapacity()} чел.\r\n" +
                    $"            Самая популярная модель автопарка: {_mostPopularBus.GetModelName()} (ГН {_mostPopularBus.GetGarageNumber()})\r\n" +
                    $"            Самый изношенный автобус автопарка: {_maxConditionBus.GetModelName()} (ГН {_maxConditionBus.GetGarageNumber()}) - {_maxConditionBus.GetModelCondition()} %\r\n" +
                    $"            Cамый неизношенный автобус автопарка: {_minConditionBus.GetModelName()} (ГН {_minConditionBus.GetGarageNumber()}) - {_minConditionBus.GetModelCondition()} %\r\n" +
                    $"            Общая вместительность автопарка: {_currentBusPark.ReturnTotalCapacityForCategory()} человек\r\n";
                    return _returnMessage;
                }
                else
                    return "Данный парк не существует/упразднён.";
            }
            else
            {
                Bus _mostCapaciousBus = ReturnCapacityModel(_nationalBusPark);
                Bus _mostPopularBus = ReturnPopularModel(_nationalBusPark);
                Bus _maxConditionBus = ReturnMaxCondition(_nationalBusPark);
                Bus _minConditionBus = ReturnMinCondition(_nationalBusPark);

                string _returnMessage = $"                        Информация об Национальном Автопарке\r\n            " +
                $"============================================================================================\r\n";
                for(int i = 0; i < _nationalBusPark._parks.Count; i++)
                {
                    if (i != (int)NationalBusPark.TransportParkList.AllParks && _nationalBusPark._parks[i] != null)
                    {
                        _returnMessage += ReturnTotalTransportInfoAboutPark(_nationalBusPark, _nationalBusPark._parks[i]);
                    }
                }
                _returnMessage += $"            Самая вместительная модель автопарка: {_mostCapaciousBus.GetModelName()} (ГН {_mostCapaciousBus.GetGarageNumber()}) - {_mostCapaciousBus.GetModelCapacity()} чел.\r\n" +
                $"            Самая популярная модель Н.А.: {_mostPopularBus.GetModelName()} (ГН {_mostPopularBus.GetGarageNumber()})\r\n" +
                $"            Самый изношенный автобус Н.А.: {_maxConditionBus.GetModelName()} (ГН {_maxConditionBus.GetGarageNumber()}) - {_maxConditionBus.GetModelCondition()} %\r\n" +
                $"            Cамый неизношенный автобус Н.А.: {_minConditionBus.GetModelName()} (ГН {_minConditionBus.GetGarageNumber()}) - {_minConditionBus.GetModelCondition()} %\r\n" +
                $"            Общая вместительность Н.А.: {ReturnTotalCapacity(_nationalBusPark)} человек\r\n";

                return _returnMessage;
            }
        }
        private string ReturnTotalTransportInfoAboutPark(NationalBusPark _nationalBusPark, OblAvtoTrans _currentBusPark)
        {
            if (_currentBusPark != null)
            {
                Bus _mostCapaciousBus = _currentBusPark.ReturnMostCapacityBusForCategory();
                Bus _mostPopularBus = _currentBusPark.ReturnMostPopularBusForCategory();
                Bus _maxConditionBus = _currentBusPark.ReturnMaxConditionBusForCategory();
                Bus _minConditionBus = _currentBusPark.ReturnMinConditionBusForCategory();

                string _returnMessage = "\r\n";
                _returnMessage += $"                        Информация об автопарке {_currentBusPark.GetBusParkName()}\r\n            " +
                $"============================================================================================\r\n" +
                $"{_currentBusPark.ReturnTransportInfo()}\r\n" +
                $"            Самая вместительная модель автопарка: {_mostCapaciousBus.GetModelName()} (ГН {_mostCapaciousBus.GetGarageNumber()}) - {_mostCapaciousBus.GetModelCapacity()} чел.\r\n" +
                $"            Самая популярная модель автопарка: {_mostPopularBus.GetModelName()} (ГН {_mostPopularBus.GetGarageNumber()})\r\n" +
                $"            Самый изношенный автобус автопарка: {_maxConditionBus.GetModelName()} (ГН {_maxConditionBus.GetGarageNumber()}) - {_maxConditionBus.GetModelCondition()} %\r\n" +
                $"            Cамый неизношенный автобус автопарка: {_minConditionBus.GetModelName()} (ГН {_minConditionBus.GetGarageNumber()}) - {_minConditionBus.GetModelCondition()} %\r\n" +
                $"            Общая вместительность автопарка: {_currentBusPark.ReturnTotalCapacityForCategory()} человек\r\n";
                return _returnMessage;
            }
            else
                return "Данный парк не существует/упразднён.";
        }
    }
}