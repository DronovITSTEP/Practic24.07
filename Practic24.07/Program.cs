using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic24._07
{
    internal class Program
    {
        enum Month
        {
            JANUARY = 1,
            FEBRUARY,
            MARCH,
            APRIL,
            MAY,
            JUNE,
            JULE,
            AUGUST,
            SEPTEMBER,
            OCTOBER,
            NOVEMBER,
            DECEMBER
        };
        enum Season
        {
            WINTER,
            SPRING,
            SUMMER,
            AUTUMN
        };

        enum TEMPERATURE_CONVERT { CELSUIS, FAHRENHEIT};
        static void Main(string[] args)
        {
            /*
             Пользователь вводит с клавиатуры дату. 
            Приложение должно отобразить название сезона и дня недели.
                Например, если введено 22.12.2021, приложение должно
                отобразить Winter Wednesday.
             */
            /*string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
            
            Console.Write("Введите дату -> ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToShortDateString());
            int seasonIndex = GetSeason(date.Month);
            Console.WriteLine($"{seasons[seasonIndex]} {date.DayOfWeek}");*/


            /*
             Пользователь вводит с клавиатуры показания температуры. 
            В зависимости от выбора пользователя программа переводит 
            температуру из Фаренгейта в Цельсий или наоборот.
             */
            Console.WriteLine("Выберете конвертор 1-Из C в F 2- Из F в C");
            int choise = int.Parse(Console.ReadLine());
            double temperatureCelsius, temperatureFahrenheit;

            Console.WriteLine(" введите показатель температуры");
            double temperature = double.Parse(Console.ReadLine());
            if (choise == (int)TEMPERATURE_CONVERT.FAHRENHEIT)
            {
                Console.WriteLine(" конвертор 1-Из C в F");
                temperatureFahrenheit = FromFahrenheitToCelsius(temperature);
                Console.WriteLine(temperatureFahrenheit); Console.WriteLine("C");
            }
            else if (choise == (int)TEMPERATURE_CONVERT.CELSUIS)
            {
                Console.WriteLine(" конвертор 2-Из F в C");                         
                temperatureCelsius = FromCelsiusToFahrenheit(temperature);
                Console.WriteLine(temperatureCelsius); Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine(" ошибка");
            }
        }
        static int GetSeason(int month)
        {
            switch (month)
            {
                case (int)Month.JANUARY:
                case (int)Month.FEBRUARY:
                case (int)Month.DECEMBER:
                    return (int)Season.WINTER;
                case (int)Month.MARCH:
                case (int)Month.APRIL:
                case (int)Month.MAY:
                    return (int)Season.SPRING;
                case (int)Month.JUNE:
                case (int)Month.JULE:
                case (int)Month.AUGUST:
                    return (int)Season.SUMMER;
                case (int)Month.OCTOBER:
                case (int)Month.NOVEMBER:
                case (int)Month.SEPTEMBER:
                    return (int)Season.AUTUMN;
                default:
                    return -1;
            }
        }

        static double FromFahrenheitToCelsius(double temperatureFahrenheit)
        {
            return (temperatureFahrenheit * 9 / 5) + 32;
        }
        static double FromCelsiusToFahrenheit (double temperatureCelius)
        {
            return (temperatureCelius + 32) * 5 / 9;
        }
    }
}
