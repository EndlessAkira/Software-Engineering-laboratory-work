using OOP_Passenger_Operations;

namespace OOP_Passenger_Operations
{
    public class NationalBusPark
    {
        private static TransportParks _transportParks;
        private static TransportManager _transportManager;
        private static Action performAction;
        private static Action<TransportParks.TransportParkList> action;
        private static bool _exit = false;
        private static bool _localExit = false;
        public static void Main(string[] args)
        {
            MainMenu();
        }
        private static void MainMenu()
        {
            MenuItem[] _menuItems =
            {
                new MenuItem("Основать Национальный Автопарк", IsCreated() == false, CreateNationalBusPark),
                new MenuItem("Изменить Национальный Автопарк", IsCreated() == true, ChangeNationalBusPark),
                new MenuItem("Получить статистическую инфо", IsCreated() == true, GetStatisticalInfo),
                new MenuItem("Упразднить Национальный Автопарк", IsCreated() == true, DeleteNationalBusPark),
                new MenuItem("Завершить работу", true, Exit),
            };
            _localExit = false;
            StartLocalMenu(_menuItems);
        }
        
        
        private static void ChangeNationalBusPark()
        {
            MenuItem[] _menuItems =
            {
                new MenuItem($"Основать новый областной автопарк", _transportParks._parks.Count <= TransportParks._numberOfRegions , AddBusPark),
                new MenuItem($"Реформировать существующий областной автопарк", _transportParks._parks.Count > 0, CreateNationalBusPark),
                new MenuItem($"Упразднить существующий областной автопарк", _transportParks._parks.Count > 0, DeleteBusPark),
                new MenuItem($"Выйти в главное меню", true, LocalExit),
            };
            StartLocalMenu(_menuItems);
        }
        private static void AddBusPark()
        {
            ModMenuItem[] _menuItems =
            {
                new ModMenuItem("БрестОблАвтоТранс", _transportParks._parks[0] == null , AddOblAvtoTrans, TransportParks.TransportParkList.BrestOblAvtoTrans),
                new ModMenuItem("ВитебскОблАвтоТранс", _transportParks._parks[1] == null, AddOblAvtoTrans, TransportParks.TransportParkList.VitebskOblAvtoTrans),
                new ModMenuItem("ГомельОблАвтоТранс", _transportParks._parks[2] == null, AddOblAvtoTrans, TransportParks.TransportParkList.GomelOblAvoTrans),
                new ModMenuItem("ГродноОблАвтоТранс", _transportParks._parks[3] == null, AddOblAvtoTrans, TransportParks.TransportParkList.GrodnoOblAvtoTrans),
                new ModMenuItem("МинскОблАвтоТранс", _transportParks._parks[4] == null, AddOblAvtoTrans, TransportParks.TransportParkList.MinskOblAvtoTrans),
                new ModMenuItem("МогилёвОблАвтоТранс", _transportParks._parks[5] == null, AddOblAvtoTrans, TransportParks.TransportParkList.MogilevOblAvtoTrans),
                new ModMenuItem("МинскТранс", _transportParks._parks[6] == null, AddOblAvtoTrans, TransportParks.TransportParkList.MinskTrans),
            };
            StartLocalMenu(_menuItems);
        }
        private static void DeleteBusPark()
        {
            ModMenuItem[] _menuItems =
            {
                new ModMenuItem("БрестОблАвтоТранс", _transportParks._parks[0] != null , DeleteOblAvtoTrans, TransportParks.TransportParkList.BrestOblAvtoTrans),
                new ModMenuItem("ВитебскОблАвтоТранс", _transportParks._parks[1] != null, DeleteOblAvtoTrans, TransportParks.TransportParkList.VitebskOblAvtoTrans),
                new ModMenuItem("ГомельОблАвтоТранс", _transportParks._parks[2] != null, DeleteOblAvtoTrans, TransportParks.TransportParkList.GomelOblAvoTrans),
                new ModMenuItem("ГродноОблАвтоТранс", _transportParks._parks[3] != null, DeleteOblAvtoTrans, TransportParks.TransportParkList.GrodnoOblAvtoTrans),
                new ModMenuItem("МинскОблАвтоТранс", _transportParks._parks[4] != null, DeleteOblAvtoTrans, TransportParks.TransportParkList.MinskOblAvtoTrans),
                new ModMenuItem("МогилёвОблАвтоТранс", _transportParks._parks[5] != null, DeleteOblAvtoTrans, TransportParks.TransportParkList.MogilevOblAvtoTrans),
                new ModMenuItem("МинскТранс", _transportParks._parks[6] != null, DeleteOblAvtoTrans, TransportParks.TransportParkList.MinskTrans)
            };
            StartLocalMenu(_menuItems);
        }
        private static void GetStatisticalInfo()
        {
            MenuItem[] _menuItems =
            {
                new MenuItem("Получить общую инфо о Национальном Автопарке", true , GetInfoAboutNationalBusPark),
                new MenuItem("Получить инфо об отдельном автопарке", true , GetInfoAboutBusPark),
                new MenuItem("Выйти из меню", true, LocalExit),
            };
            StartLocalMenu(_menuItems);

        }
        private static void GetInfoAboutBusPark()
        {

            ModMenuItem[] _menuItems =
            {
                new ModMenuItem("БрестОблАвтоТранс", _transportParks._parks[0] != null , PrintOblAvtoTransInfo, TransportParks.TransportParkList.BrestOblAvtoTrans),
                new ModMenuItem("ВитебскОблАвтоТранс", _transportParks._parks[1] != null, PrintOblAvtoTransInfo, TransportParks.TransportParkList.VitebskOblAvtoTrans),
                new ModMenuItem("ГомельОблАвтоТранс", _transportParks._parks[2] != null, PrintOblAvtoTransInfo, TransportParks.TransportParkList.GomelOblAvoTrans),
                new ModMenuItem("ГродноОблАвтоТранс", _transportParks._parks[3] != null, PrintOblAvtoTransInfo, TransportParks.TransportParkList.GrodnoOblAvtoTrans),
                new ModMenuItem("МинскОблАвтоТранс", _transportParks._parks[4] != null, PrintOblAvtoTransInfo, TransportParks.TransportParkList.MinskOblAvtoTrans),
                new ModMenuItem("МогилёвОблАвтоТранс", _transportParks._parks[5] != null, PrintOblAvtoTransInfo, TransportParks.TransportParkList.MogilevOblAvtoTrans),
                new ModMenuItem("МинскТранс", _transportParks._parks[6] != null, PrintOblAvtoTransInfo, TransportParks.TransportParkList.MinskTrans)
            };
            StartLocalMenu(_menuItems);

        }
        

        private static void CreateNationalBusPark()
        {
            if (_transportParks == null && _transportManager == null)
            {
                _transportParks = new TransportParks();
                _transportManager = new TransportManager();
                Console.WriteLine("Вы основали Национальный Автопарк!");
            }
            else
                Console.WriteLine("Основание невозможно - Национальный Автопарк уже создан!");
        }
        private static void DeleteNationalBusPark()
        {
            if (_transportParks != null && _transportManager != null)
            {
                _transportParks = null;
                _transportManager = null;
                Console.WriteLine("Национальный Автопарк был упразднён.");
            }
            else
                Console.WriteLine("Невозможно упразднить Национальный Автопарк.");
        }


        private static void StartLocalMenu(MenuItem[] _menuItems)
        {
            while (_exit == false && _localExit == false)
            {
                Console.WriteLine("\r\nВыберите действие из доступных, чтобы продолжить:");
                for (int i = 0; i < _menuItems.Length; i++)
                {
                    if (_menuItems[i].IsAvailable)
                    {
                        Console.WriteLine($"[{i + 1}] - {_menuItems[i].Text}");
                    }
                }
                Console.Write("Вы выбрали:");
                int _action;
                Console.WriteLine("\r\n");
                try
                {
                    _action = Convert.ToInt32(Console.ReadLine());
                    _action--;
                    if (_action >= 0 && _action < _menuItems.Length && _menuItems[_action].IsAvailable)
                    {
                        performAction = _menuItems[_action].Delegate;
                        performAction.Invoke();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Данное действие недоступно. Попробуйте снова");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e}, \nОшибка ввода. Попробуйте снова");
                }
            }
            if (_exit == false)
                MainMenu();

        }
        private static void StartLocalMenu(ModMenuItem[] _menuItems)
        {
            while (_exit == false)
            {
                Console.WriteLine("Выберите действие из доступных, чтобы продолжить:");
                for (int i = 0; i < _menuItems.Length; i++)
                {
                    if (_menuItems[i].IsAvailable)
                    {
                        Console.WriteLine($"[{i + 1}] - {_menuItems[i].Text}");
                    }
                }
                Console.Write("Вы выбрали:");
                int _action;
                try
                {
                    _action = Convert.ToInt32(Console.ReadLine());
                    _action--;
                    if (_action >= 0 && _action < _menuItems.Length && _menuItems[_action].IsAvailable)
                    {
                        action = _menuItems[_action].Delegate;
                        TransportParks.TransportParkList park = _menuItems[_action].Park;
                        action.Invoke(park);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Данное действие недоступно. Попробуйте снова");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e}, \nОшибка ввода. Попробуйте снова");
                }
            }
            if (_exit == false)
                MainMenu();

        }


        private static void GetInfoAboutNationalBusPark()
        {
            PrintOblAvtoTransInfo(TransportParks.TransportParkList.AllParks);
        }
        private static void AddOblAvtoTrans(TransportParks.TransportParkList park)
        {
            if (_transportParks.AddBusPark(park))
            {
                Console.WriteLine("Выбранный ОблАвтоТранс был успешно основан!");
            }
            else
            {
                Console.WriteLine("Выбранный ОблАвтоТранс уже был основан.");
            }
        }
        private static void DeleteOblAvtoTrans(TransportParks.TransportParkList park)
        {
            if (_transportParks.DeleteBusPark(park))
            {
                Console.WriteLine("Выбранный ОблАвтоТранс был успешно упразднён.");
            }
            else
            {
                Console.WriteLine("Невозможно упразднить выбранный ОблАвтоТранс.");
            }
        }
        private static void PrintOblAvtoTransInfo(TransportParks.TransportParkList park)
        {
            Console.WriteLine(_transportManager.ReturnTotalTransportInfo(_transportParks, park));
        }


        private static bool IsCreated()
        {
            if (_transportParks == null && _transportManager == null)
            {
                Console.WriteLine("не создан");
                return false;
            }
            else
                return true;
        }
        private static void LocalExit()
        {
            Console.WriteLine("Выход в главное меню.");
            _localExit = true;
        }
        private static void Exit()
        {
            Console.WriteLine("Завершение работы с приложением.");
            _exit = true;
        }
    }

    public class MenuItem
    {
        public string Text { get; }
        public bool IsAvailable { get; }
        public Action Delegate { get; }
        public MenuItem(string text, bool isAvailable, Action @delegate)
        {
            Text = text;
            IsAvailable = isAvailable;
            Delegate = @delegate;
        }
    }
    public class ModMenuItem
    {
        internal string Text { get;}
        internal bool IsAvailable { get; }
        internal Action<TransportParks.TransportParkList> Delegate { get; }
        internal TransportParks.TransportParkList Park { get;}
        internal ModMenuItem(string text, bool isAvailable, Action<TransportParks.TransportParkList> @delegate, TransportParks.TransportParkList park)
        {
            Text = text;
            IsAvailable = isAvailable;
            Delegate = @delegate;
            Park = park;
        }
    }
}

