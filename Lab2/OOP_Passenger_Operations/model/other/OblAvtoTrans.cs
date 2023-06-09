﻿using OOP_Passenger_Operations.controller;

namespace OOP_Passenger_Operations.model.other
{
    abstract internal class OblAvtoTrans
    {
        protected string _busParkName = null;
        private int _defaultInt = 0;

        // Поле автобусов компании
        protected Bus[] buses;

        // Общая вместительность автобусов компании
        public int _totalCapacityForCategory;

        // Название самого вместительного автобуса компании
        public Bus _mostCapaciousBus = null;

        // Название самого популярного автобуса компании
        public Bus _mostPopularBus = null;

        // Проценты самого изношенного и самого целого автобусов компании
        public Bus _maxConditionBus = null;
        public Bus _minConditionBus = null;

        protected void BaseConstructor(string _name, int busCount = 5)
        {
            _busParkName = _name;
            buses = new Bus[busCount];
            for (int i = 0; i < busCount; i++)
            {

                string _modelName = MinskAutomobileFactory.GenerateBusModel();
                string _garageNuber = MinskAutomobileFactory.GenerateGarageNumber();
                int _capacity = MinskAutomobileFactory.GenerateBusCapacity(_modelName);
                int _condition = MinskAutomobileFactory.GenerateBusCondition();
                buses[i] = new Bus(_modelName, _garageNuber, _capacity, _condition);
            }
        }
        public int GetSizeBusPark() => buses.Length;
        public string GetBusParkName() => _busParkName;
        public Bus GetBus(int id) => buses[id]; 



        // Метод возврата текстовой информации об автобусах компании
        public string ReturnTransportInfo()
        {
            string message = "";
            for (int i = 0; i < buses.Length; i++)
            {
                message += $"            Автобус {_busParkName} #{i + 1} : модель - {buses[i].GetModelName()}, ГН {buses[i].GetGarageNumber()}, вместимость == {buses[i].GetModelCapacity()}, изношенность == {buses[i].GetModelCondition()} %\r\n";
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
                    _totalCapacityForCategory += bus.GetModelCapacity();
                }
            }
            return _totalCapacityForCategory;
        }
        // Метод возврата самого вместительного автобуса компании
        public Bus ReturnMostCapacityBusForCategory()
        {
            if (_mostCapaciousBus == null)
            {
                _mostCapaciousBus = StateBusInspection.ReturnMostCapaciousBus(buses);
            }
            return _mostCapaciousBus;
        }

        // Метод возврата самого популярного автобуса компании
        public Bus ReturnMostPopularBusForCategory()
        {
            if (_mostPopularBus == null)
            {
                _mostPopularBus = StateBusInspection.ReturnMostPopularBus(buses);
            }
            return _mostPopularBus;
        }

        // Метод возврата самого изношенного автобуса компании
        public Bus ReturnMaxConditionBusForCategory()
        {
            if (_maxConditionBus == null)
            {
                _maxConditionBus = StateBusInspection.ReturnMaxConditionBus(buses);
            }
            return _maxConditionBus;
        }

        // Метод возврата самого целого автобуса компании
        public Bus ReturnMinConditionBusForCategory()
        {
            if (_minConditionBus == null)
            {
                _minConditionBus = StateBusInspection.ReturnMinConditionBus(buses);
            }
            return _minConditionBus;
        }
    }
}
