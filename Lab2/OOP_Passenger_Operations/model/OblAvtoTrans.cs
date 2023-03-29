namespace OOP_Passenger_Operations
{
    abstract internal class OblAvtoTrans
    {
        // Поле автобусов компании
        protected Bus[] buses = new Bus[5];

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



        // Метод возврата текстовой информации об автобусах компании
        public abstract string ReturnTransportInfo();

        // Метод возврата общей вместительности автобусов компании (кол-во чел.)
        public abstract int ReturnTotalCapacityForCategory();

        // Метод возврата названия модели самого вместительного автобуса компании
        public abstract string ReturnCapacityModelForCategory();

        // Метод возврата количества мест шт. самого вместительного автобуса
        public abstract int ReturnMaxNumberCapacityBusesForCategory();

        // Метод возврата количества шт. самого популярного автобуса
        public abstract int ReturnMaxNumberIdenticalBusesForCategory();

        // Метод возврата названия самой популярной модели автобуса компании
        public abstract string ReturnPopularModelForCategory();

        // Метод возврата маскимального процента изношенности из всех автобусов компании
        public abstract int ReturnMaxConditionForCategory();

        // Метод возврата минимального процента изношенности из всех автобусов компании
        public abstract int ReturnMinConditionForCategory();
    }
}
