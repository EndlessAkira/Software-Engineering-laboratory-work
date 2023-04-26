namespace OOP_Passenger_Operations.user
{
    public class NationalBusParkApplication
    {
        private static NationalBusPark _nationalBusPark;
        private static StateBusInspection _stateBusInspection;

        private static Action performAction;
        private static Action<NationalBusPark.TransportParkList> action;

        private static bool _exit = false;
        private static bool _localExit = false;

        public void Start()
        {
            Console.WriteLine("Добро пожаловать в приложение управления Национального Автопарка!");
            MainMenu();
        }
        private static void MainMenu()
        {
            MenuItem[] _menuItems =
            {
                new MenuItem("Основать Национальный Автопарк", DepartamentIsExist() == false, CreateNationalBusPark),
                new MenuItem("Изменить Национальный Автопарк", DepartamentIsExist(), ChangeNationalBusPark),
                new MenuItem("Получить статистическую инфо", DepartamentIsExist() && (_nationalBusPark.IsEmpty() == false), GetStatisticalInfo),
                new MenuItem("Упразднить Национальный Автопарк", DepartamentIsExist() == true, DeleteNationalBusPark),
                new MenuItem("Завершить работу", true, Exit),
            };
            _localExit = false;
            StartLocalMenu(_menuItems);
        }


        private static void ChangeNationalBusPark()
        {
            MenuItem[] _menuItems =
            {
                new MenuItem($"Основать новый областной автопарк", _nationalBusPark.IsFill() == false , AddBusPark),
                new MenuItem($"Упразднить существующий областной автопарк", _nationalBusPark.IsEmpty() == false, DeleteBusPark),
                new MenuItem($"Выйти в главное меню", true, LocalExit),
            };
            StartLocalMenu(_menuItems);
        }
        private static void AddBusPark()
        {
            ModMenuItem[] _menuItems =
            {
                new ModMenuItem("БрестОблАвтоТранс", _nationalBusPark._parks[0] == null , AddOblAvtoTrans, NationalBusPark.TransportParkList.BrestOblAvtoTrans),
                new ModMenuItem("ВитебскОблАвтоТранс", _nationalBusPark._parks[1] == null, AddOblAvtoTrans, NationalBusPark.TransportParkList.VitebskOblAvtoTrans),
                new ModMenuItem("ГомельОблАвтоТранс", _nationalBusPark._parks[2] == null, AddOblAvtoTrans, NationalBusPark.TransportParkList.GomelOblAvoTrans),
                new ModMenuItem("ГродноОблАвтоТранс", _nationalBusPark._parks[3] == null, AddOblAvtoTrans, NationalBusPark.TransportParkList.GrodnoOblAvtoTrans),
                new ModMenuItem("МинскОблАвтоТранс", _nationalBusPark._parks[4] == null, AddOblAvtoTrans, NationalBusPark.TransportParkList.MinskOblAvtoTrans),
                new ModMenuItem("МогилёвОблАвтоТранс", _nationalBusPark._parks[5] == null, AddOblAvtoTrans, NationalBusPark.TransportParkList.MogilevOblAvtoTrans),
                new ModMenuItem("МинскТранс", _nationalBusPark._parks[6] == null, AddOblAvtoTrans, NationalBusPark.TransportParkList.MinskTrans),
            };
            StartLocalMenu(_menuItems);
        }
        private static void DeleteBusPark()
        {
            ModMenuItem[] _menuItems =
            {
                new ModMenuItem("БрестОблАвтоТранс", _nationalBusPark._parks[0] != null , DeleteOblAvtoTrans, NationalBusPark.TransportParkList.BrestOblAvtoTrans),
                new ModMenuItem("ВитебскОблАвтоТранс", _nationalBusPark._parks[1] != null, DeleteOblAvtoTrans, NationalBusPark.TransportParkList.VitebskOblAvtoTrans),
                new ModMenuItem("ГомельОблАвтоТранс", _nationalBusPark._parks[2] != null, DeleteOblAvtoTrans, NationalBusPark.TransportParkList.GomelOblAvoTrans),
                new ModMenuItem("ГродноОблАвтоТранс", _nationalBusPark._parks[3] != null, DeleteOblAvtoTrans, NationalBusPark.TransportParkList.GrodnoOblAvtoTrans),
                new ModMenuItem("МинскОблАвтоТранс", _nationalBusPark._parks[4] != null, DeleteOblAvtoTrans, NationalBusPark.TransportParkList.MinskOblAvtoTrans),
                new ModMenuItem("МогилёвОблАвтоТранс", _nationalBusPark._parks[5] != null, DeleteOblAvtoTrans, NationalBusPark.TransportParkList.MogilevOblAvtoTrans),
                new ModMenuItem("МинскТранс", _nationalBusPark._parks[6] != null, DeleteOblAvtoTrans, NationalBusPark.TransportParkList.MinskTrans)
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
                new ModMenuItem("БрестОблАвтоТранс", _nationalBusPark._parks[0] != null , PrintOblAvtoTransInfo, NationalBusPark.TransportParkList.BrestOblAvtoTrans),
                new ModMenuItem("ВитебскОблАвтоТранс", _nationalBusPark._parks[1] != null, PrintOblAvtoTransInfo, NationalBusPark.TransportParkList.VitebskOblAvtoTrans),
                new ModMenuItem("ГомельОблАвтоТранс", _nationalBusPark._parks[2] != null, PrintOblAvtoTransInfo, NationalBusPark.TransportParkList.GomelOblAvoTrans),
                new ModMenuItem("ГродноОблАвтоТранс", _nationalBusPark._parks[3] != null, PrintOblAvtoTransInfo, NationalBusPark.TransportParkList.GrodnoOblAvtoTrans),
                new ModMenuItem("МинскОблАвтоТранс", _nationalBusPark._parks[4] != null, PrintOblAvtoTransInfo, NationalBusPark.TransportParkList.MinskOblAvtoTrans),
                new ModMenuItem("МогилёвОблАвтоТранс", _nationalBusPark._parks[5] != null, PrintOblAvtoTransInfo, NationalBusPark.TransportParkList.MogilevOblAvtoTrans),
                new ModMenuItem("МинскТранс", _nationalBusPark._parks[6] != null, PrintOblAvtoTransInfo, NationalBusPark.TransportParkList.MinskTrans)
            };
            StartLocalMenu(_menuItems);

        }


        private static void CreateNationalBusPark()
        {
            if (_nationalBusPark == null && _stateBusInspection == null)
            {
                _nationalBusPark = new NationalBusPark();
                _stateBusInspection = new StateBusInspection();
                Console.WriteLine("\r\nВы основали Национальный Автопарк!");
            }
            else
                Console.WriteLine("\r\nОснование невозможно - Национальный Автопарк уже создан!");
        }
        private static void DeleteNationalBusPark()
        {
            if (_nationalBusPark != null && _stateBusInspection != null)
            {
                _nationalBusPark = null;
                _stateBusInspection = null;
                Console.WriteLine("\r\nНациональный Автопарк был упразднён.");
            }
            else
                Console.WriteLine("\r\nНевозможно упразднить Национальный Автопарк.");
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
                        Console.WriteLine("\r\nДанное действие недоступно. Попробуйте снова");
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
                        NationalBusPark.TransportParkList park = _menuItems[_action].Park;
                        action.Invoke(park);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\r\nДанное действие недоступно. Попробуйте снова");
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
            PrintOblAvtoTransInfo(NationalBusPark.TransportParkList.AllParks);
        }
        private static void AddOblAvtoTrans(NationalBusPark.TransportParkList park)
        {
            if (_nationalBusPark._parks[(int)park] == null)
            {
                Console.WriteLine("\r\nВведите название автопарка (либо оставьте поле пустым для использования стандартного названия):\r\n");
                string _parkName = Console.ReadLine();
                Console.WriteLine("\r\nВведите кол-во автобусов, которое будет использовать данный автопарк(>0 и <1000):");
                int _busCount = Convert.ToInt32(Console.ReadLine());
                if (_nationalBusPark.AddBusPark(park, _parkName, _busCount))
                {
                    Console.WriteLine("\r\nВыбранный ОблАвтоТранс был успешно основан!");
                }
                else
                {
                    Console.WriteLine("\r\nОшибка создания.");
                }
            }
            else
                Console.WriteLine("Данный ОблАвтоТранс уже был создан.");
        }
        private static void DeleteOblAvtoTrans(NationalBusPark.TransportParkList park)
        {
            if (_nationalBusPark.DeleteBusPark(park))
            {
                Console.WriteLine("\r\nВыбранный ОблАвтоТранс был успешно упразднён.");
            }
            else
            {
                Console.WriteLine("\r\nНевозможно упразднить выбранный ОблАвтоТранс.");
            }
        }
        private static void PrintOblAvtoTransInfo(NationalBusPark.TransportParkList park)
        {
            Console.WriteLine(_stateBusInspection.ReturnTotalTransportInfo(_nationalBusPark, park));
        }


        private static bool DepartamentIsExist()
        {
            if (_nationalBusPark == null && _stateBusInspection == null)
            {
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
            Console.WriteLine("\r\nЗавершение работы с приложением.");
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
        internal string Text { get; }
        internal bool IsAvailable { get; }
        internal Action<NationalBusPark.TransportParkList> Delegate { get; }
        internal NationalBusPark.TransportParkList Park { get; }
        internal ModMenuItem(string text, bool isAvailable, Action<NationalBusPark.TransportParkList> @delegate, NationalBusPark.TransportParkList park)
        {
            Text = text;
            IsAvailable = isAvailable;
            Delegate = @delegate;
            Park = park;
        }
    }
}

