namespace OOP_Passenger_Operations
{
    abstract internal class OblAvtoTrans
    {
        // Поле автобусов компании
        protected Bus[] buses = new Bus[5];

        // Дефолтные переменные для каждого типа данных
        public const int _defaultInt = -1;
        public const string _defaultString = null;

        // Общая вместительность автобусов компании
        public int _totalCapacityForCategory;

        // Вместительность и название самого вместительного автобуса компании
        //public int _mostCapacity = -1;
        public Bus _mostCapaciousBus = null;

        // Кол-во шт. и название самого популярного автобуса компании
        // public int _maxCount = -1;
        public Bus _mostPopularBus = null;
        //public string? _modelNameMostPopularBus = null;

        // Проценты самого изношенного и самого целого автобусов компании
        public Bus _maxConditionBus = null;
        public Bus _minConditionBus = null;

        //public int _maxCondition = -1;
        //public int _minCondition = -1;



        // Метод возврата текстовой информации об автобусах компании
        public abstract string ReturnTransportInfo();

        // Метод возврата общей вместительности автобусов компании (кол-во чел.)
        public abstract int ReturnTotalCapacityForCategory();



        // Метод возврата самого вместительного автобуса компании
        public abstract Bus ReturnMostCapacityBusForCategory();

        // Метод возврата самого популярного автобуса компании
        public abstract Bus ReturnMostPopularBusForCategory();



        // Метод возврата самого изношенного автобуса компании
        public abstract Bus ReturnMaxConditionBusForCategory();

        // Метод возврата самого целого автобуса компании
        public abstract Bus ReturnMinConditionBusForCategory();
    }
}
