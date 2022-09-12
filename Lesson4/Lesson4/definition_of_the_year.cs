using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class definition_of_the_year
    {
            enum season
            {
                Winter,
                Spring,
                Summer,
                Autumn,
                Error
            }
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Введите номер месяца: ");
                    Console.WriteLine(Season(month(Convert.ToInt32(Console.ReadLine()))));
                    Console.ReadLine();
                }
            }
            static season month(int number)
            {
                try
                {

                    if (number <= 0 || number > 12)
                        throw new Exception("Ошибка: введите число от 1 до 12");


                    switch ((number % 12) / 3)
                    {
                        case 0:
                            return season.Winter;
                        case 1:
                            return season.Spring;
                        case 2:
                            return season.Summer;
                        default: return season.Autumn;
                    }
                }
                catch (Exception message)
                {
                    Console.WriteLine(message.Message);
                    return season.Error;

                }
            }
            static string Season(season ofmonth)
            {

                switch (ofmonth)
                {
                    case season.Winter:
                        return "Зима";
                    case season.Spring:
                        return "Весна";
                    case season.Summer:
                        return "Лето";
                    case season.Autumn:
                        return "Осень";
                    default: return "";
                }

            }
    }
}
