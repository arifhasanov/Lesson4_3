using System;

namespace Lesson_4_3
{
    class Program
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static void Main(string[] args)
        {
            bool exit = true;
            while(exit)
            {
                Console.WriteLine("Введите пожалуйста число от 1 до 12 и нажмите ВВОД:");
                int monthNumber;
                string enteredData = Console.ReadLine();
                if (int.TryParse(enteredData, out monthNumber))
                {
                    if (monthNumber >= 1 && monthNumber <= 12)
                    {
                        Console.WriteLine($"Сейчас {SeasonName(monthNumber)}. Если хотите выйти из программы введите 'EXIT' (без ковычек) и нажмите ВВОД");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: введите число от 1 до 12");
                    }
                }
                else
                {
                    if(enteredData == "EXIT")
                    {
                        exit = false;
                        Console.WriteLine("Вы вышли из программы. Пока!");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: введите число от 1 до 12");
                    }
                }
            }
            
            
        }

        static string SeasonName(int monthNumber)
        {
            string season = "";
            if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
            {
                season = getSeasonName(Seasons.Winter);
            }
            if (monthNumber >= 3 && monthNumber <= 5)
            {
                season = getSeasonName(Seasons.Spring);
            }
            if (monthNumber >= 6 && monthNumber <= 8)
            {
                season = getSeasonName(Seasons.Summer);
            }
            if (monthNumber >= 9 && monthNumber <= 11)
            {
                season = getSeasonName(Seasons.Autumn);
            }
            return season;
        }

        static string getSeasonName(Seasons s)
        {
            string name = "";
            if (s == Seasons.Winter) name = "Зима";
            if (s == Seasons.Spring) name = "Весна";
            if (s == Seasons.Summer) name = "Лето";
            if (s == Seasons.Autumn) name = "Осень";
            return name;
        }



    }
}
