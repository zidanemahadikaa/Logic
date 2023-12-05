// See https://aka.ms/new-console-template for more information
namespace Logic_329
{
    public class Program
    {
        static void Main()
        {
            Menu();
        }
        private static void PilihanMenu()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("1. Day 1");
            Console.WriteLine("2. Day 2");
            Console.WriteLine("3. Day 3");
            Console.WriteLine("4. Day 4");
            Console.WriteLine("5. Day 5");
            Console.WriteLine("6. Tugas");
            Console.WriteLine("7. PR");
            Console.WriteLine("Press any key to Exit");
        }
        private static void PilihanMenuTugas()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("1. Tugas Day 1");
            Console.WriteLine("2. Tugas Day 2");
            Console.WriteLine("3. Tugas Day 3");
            Console.WriteLine("4. Tugas Day 4");
            Console.WriteLine("5. Tugas Day 5");
            Console.WriteLine("6. Tugas Day 6");
            Console.WriteLine("7. Tugas Day 7");
            Console.WriteLine("..............");
            Console.WriteLine("Press any key to Main Menu");
        }
        private static void PilihanMenuPr()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("1. PR Day 1");
            Console.WriteLine("2. PR Day 2");
            Console.WriteLine("3. PR Day 3");
            Console.WriteLine("4. PR Day 4");
            Console.WriteLine("5. PR Day 5");
            Console.WriteLine("6. PR Day 6");
            Console.WriteLine("7. PR Day 7");
            Console.WriteLine("...........");
            Console.WriteLine("Press any key to Main Menu");
        }
        static public void Menu()
        {
            ConsoleKey key;
            Console.WriteLine("=== MENU ===");
            PilihanMenu();
            key = Console.ReadKey(true).Key;
            Console.Clear();
            switch (key)
            {
                case ConsoleKey.D1:
                    Day_01 d1 = new Day_01();
                    d1.Menu();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("==== Day 2 ===");
                    Day_02 d2 = new Day_02();
                    d2.Menu();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("==== Day 3 ===");
                    Day_03 d3 = new Day_03();
                    d3.Menu();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("==== Day 4 ===");
                    Day_04 d4 = new Day_04();
                    d4.Menu();
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("==== Day 5 ===");
                    Day_05 d5 = new Day_05();
                    d5.AbstrakVirtual();
                    //d4.Array2D();
                    //d4.ListCollection();
                    //d5.DateTimeVar();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("==== Menu Tugas ===");
                    MenuTugas();
                    Program.Pause();
                    break;
                case ConsoleKey.D7:
                    Console.WriteLine("=== Menu PR ===");
                    MenuPr();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D8:
                    Console.WriteLine("==== SIMULASI LOGIC===");
                    Simulasi_Logic sl = new Simulasi_Logic();
                    sl.Menu();
                    break;
                case ConsoleKey.D9:                    
                    HackerRank hr = new HackerRank();
                    hr.MiniMax();
                    break;
                default:
                    break;
            }
        }
        static public void MenuTugas()
        {
            PilihanMenuTugas();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Tugas_Day01 tugasD1 = new Tugas_Day01();
                    tugasD1.LuasKelilingLingkaran();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Tugas_Day02 tugasD2 = new Tugas_Day02();
                    tugasD2.Menu();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Tugas_Day03 tugasD3 = new Tugas_Day03();
                    tugasD3.PohonFaktor();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Tugas_Day05 tugasD5 = new Tugas_Day05();
                    tugasD5.Menu();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D6:
                    Tugas_Day06 tugasD6 = new Tugas_Day06();
                    //tugasD6.LembahGunung();
                    tugasD6.PasswordEncryption();
                    //tugasD6.VokalKonsonan();
                    //tugasD6.ElementTinggi();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    Tugas_Day07 tugasD7 = new Tugas_Day07();
                    tugasD7.Menu();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D8:
                    Console.Clear();
                    Tugas_Day08 tugasD8 = new Tugas_Day08();
                    tugasD8.Menu();
                    Program.Pause();
                    Menu();
                    break;
                
                //case ConsoleKey.D4:
                //    Console.Clear();
                //    BreakContinue();
                //    Program.Pause();
                //    Menu();
                //    break;
                //case ConsoleKey.D5:
                //    Console.Clear();
                //    PerulanganBersarang();
                //    Program.Pause();
                //    Menu();
                //    break;
                //case ConsoleKey.D6:
                //    Console.Clear();
                //    PerulanganForeach();
                //    Program.Pause();
                //    Menu();
                //    break;
                //case ConsoleKey.D7:
                //    Console.Clear();
                //    LengthToUpper();
                //    Program.Pause();
                //    Menu();
                //    break;
                //case ConsoleKey.D8:
                //    Console.Clear();
                //    Substring();
                //    Program.Pause();
                //    Menu();
                //    break;
                //case ConsoleKey.D9:
                //    Console.Clear();
                //    AngkaGanjil();
                //    Program.Pause();
                //    Menu();
                //    break;
                default:
                    Console.Clear();
                    Program.Menu();
                    break;
            }
        }
        public static void MenuPr()
        {
            PilihanMenuPr();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("==== Day 1 ===");
                    Pr_Day01 pr1 = new Pr_Day01();
                    pr1.Menu();
                    Program.Pause();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("==== Day 2 ===");
                    Pr_Day02 pr2 = new Pr_Day02();
                    pr2.Menu();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("==== Day 3 ===");
                    Pr_Day03 pr3 = new Pr_Day03();
                    pr3.Menu();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("==== Day 4 ===");
                    Pr_Day04 pr4 = new Pr_Day04();
                    pr4.Palindrome();
                    //pr4.Belanja();
                    break;               
                case ConsoleKey.D5:
                    Console.WriteLine("==== Day 5 ===");
                    Pr_Day05 pr5 = new Pr_Day05();
                    pr5.Menu();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("==== Day  ===");
                    Pr_Day06 pr6 = new Pr_Day06();
                    pr6.Menu();
                    Program.Pause();
                    break;
                case ConsoleKey.D8:
                    Console.WriteLine("==== Day  ===");
                    Pr_Day08 pr8 = new Pr_Day08();
                    pr8.BeautifulDay();
                    Program.Pause();
                    break;
                default:
                    break;
            }
        }
        static public void Pause()
        {
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
    