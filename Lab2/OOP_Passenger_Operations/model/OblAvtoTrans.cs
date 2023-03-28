namespace OOP_Passenger_Operations
{
    abstract internal class OblAvtoTrans
    {
        // Поле автобусов каждой компании
        public Bus[] buses = new Bus[5];

        // Метод возврата текстовой информации об автобусах компании
        public abstract string ReturnTransportInfo();

        // Метод возврата общей вместительности автобусов компании (кол-во чел.)
        public abstract int ReturnTotalCapacityForCategory();

        // Метод возврата названия модели самого вместительного автобуса компании
        public abstract string ReturnCapacityModelForCategory();

        // Метод возврата названия самой популярной модели автобуса компании
        public abstract string ReturnPopularModelForCategory();

        // Метод возврата маскимального процента изношенности из всех автобусов компании
        public abstract float ReturnMaxConditionForCategory();

        // Метод возврата минимального процента изношенности из всех автобусов компании
        public abstract float ReturnMinConditionForCategory();
    }
}
