using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Прак_14
{
    internal class Program
    {
        /*
        class N1
        {
            static void Main()
            {
                
                string dateFormat = "dd.MM.yyyy HH:mm";

                
                Console.WriteLine($"Введите первую дату в формате {dateFormat}:");
                string inputDate1 = Console.ReadLine();

                
                Console.WriteLine($"Введите вторую дату в формате {dateFormat}:");
                string inputDate2 = Console.ReadLine();

                DateTime date1, date2;

                
                if (!DateTime.TryParseExact(inputDate1, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date1))
                {
                    Console.WriteLine("Некорректный формат первой даты.");
                    return;
                }

                if (!DateTime.TryParseExact(inputDate2, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date2))
                {
                    Console.WriteLine("Некорректный формат второй даты.");
                    return;
                }

                
                TimeSpan difference = date2 - date1;

                
                if (difference < TimeSpan.Zero)
                {
                    difference = difference.Negate();
                }

                
                Console.WriteLine($"Разница между датами:");
                Console.WriteLine($"{difference.Days} дней");
                Console.WriteLine($"{difference.Hours} часов");
                Console.WriteLine($"{difference.Minutes} минут");

                Console.ReadLine();
            }
        }
        */

        /*
        class N2
        {
            static void Main()
            {
                
                string dateFormat = "dd.MM.yyyy";

                Console.WriteLine($"Введите дату в формате {dateFormat}:");
                string inputDate = Console.ReadLine();

                DateTime date;

                
                if (DateTime.TryParseExact(inputDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                   
                    DayOfWeek dayOfWeek = date.DayOfWeek;

              
                    var russianCulture = new CultureInfo("ru-RU");
                    string dayName = russianCulture.DateTimeFormat.GetDayName(dayOfWeek);

                    Console.WriteLine($"Это {dayName}.");
                }
                else
                {
                    Console.WriteLine("Некорректный формат даты.");
                }

                Console.ReadLine();
            }
        }
        */

        /*
        class N3
        {
            static void Main()
            {
                
                string dateFormat = "dd.MM.yyyy";

                
                Console.WriteLine($"Введите дату в формате {dateFormat}:");
                string inputDate = Console.ReadLine();

                
                Console.WriteLine("Введите количество дней для добавления:");
                string inputDays = Console.ReadLine();

                DateTime date;
                int daysToAdd;

                
                if (!DateTime.TryParseExact(inputDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine("Некорректный формат даты.");
                    return;
                }

                
                if (!int.TryParse(inputDays, out daysToAdd))
                {
                    Console.WriteLine("Некорректное количество дней.");
                    return;
                }

                
                DateTime newDate = date.AddDays(daysToAdd);

                
                Console.WriteLine($"Новая дата после добавления {daysToAdd} дней: {newDate.ToString(dateFormat)}");

                Console.ReadLine();
            }
        }
        */

        /*
        class N4
        {
           
            static bool IsLeapYear(int year)
            {
                
                return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            }

            static void Main()
            {
                Console.WriteLine("Введите год для проверки:");
                string input = Console.ReadLine();
                int year;

                if (int.TryParse(input, out year))
                {
                    bool isLeap = IsLeapYear(year);
                    Console.WriteLine($"Год {year} {(isLeap ? "високосный" : "не високосный")}.");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }

                Console.ReadLine();
            }
        }
        */

        /*
        class N5
        {
            static void Main()
            {
                
                string dateFormat = "dd.MM.yyyy";

                Console.WriteLine($"Введите дату в формате {dateFormat}:");
                string input = Console.ReadLine();

                DateTime date;
                if (!DateTime.TryParseExact(input, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine("Некорректный формат даты.");
                    return;
                }

                
                Console.WriteLine("Форматы даты:");
                Console.WriteLine($"1. dd.MM.yyyy: {date.ToString("dd.MM.yyyy")}");
                Console.WriteLine($"2. MM/dd/yyyy: {date.ToString("MM/dd/yyyy")}");
                Console.WriteLine($"3. yyyy-MM-dd HH:mm:ss: {date.ToString("yyyy-MM-dd HH:mm:ss")}");

                Console.ReadLine();
            }
        }
        */

        /*
        class N6
        {
            static void Main()
            {
                DateTime today = DateTime.Today; 
                int year = today.Year;

                // Определяем дату следующего Нового года
                DateTime newYear = new DateTime(year + 1, 1, 1);

                // Вычисляем разницу в днях
                TimeSpan difference = newYear - today;

                Console.WriteLine($"До следующего Нового года осталось {difference.Days} дней.");

                Console.ReadLine();
            }
        }
        */

        /*
        class N7
        {
            static void Main()
            {
                Console.WriteLine("Введите дату рождения в формате dd.MM.yyyy:");
                string input = Console.ReadLine();

                DateTime birthDate;
                if (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
                {
                    Console.WriteLine("Некорректный формат даты.");
                    return;
                }

                DateTime today = DateTime.Today;

                if (birthDate > today)
                {
                    Console.WriteLine("Дата рождения не может быть в будущем.");
                    return;
                }

               
                int years = today.Year - birthDate.Year;
                int months = today.Month - birthDate.Month;
                int days = today.Day - birthDate.Day;

                
                if (days < 0)
                {
                    months--;
                    days += DateTime.DaysInMonth(today.Year, (today.Month == 1) ? 12 : today.Month - 1);
                }

                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                Console.WriteLine($"Ваш возраст: {years} лет, {months} месяцев и {days} дней.");

                Console.ReadLine();
            }
        }
        */

        /*
        class N8
        {
            static void Main()
            {
                Console.WriteLine("Введите дату в формате dd.MM.yyyy:");
                string input = Console.ReadLine();

                if (IsValidDate(input))
                {
                    Console.WriteLine("Данная дата корректна.");
                }
                else
                {
                    Console.WriteLine("Некорректная дата.");

                    Console.ReadLine();
                }
            }

            static bool IsValidDate(string dateString)
            {
                DateTime tempDate;
                
                return DateTime.TryParseExact(
                    dateString,
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out tempDate
                );
            }
        }
        */

        /*
        class N9
        {
            static void Main()
            {
                
                DateTime utcNow = DateTime.UtcNow;
                Console.WriteLine($"Текущее время в UTC: {utcNow}");

                
                DateTime localTime = utcNow.ToLocalTime();
                Console.WriteLine($"Локальное время: {localTime}");

                
                DateTime utcFromLocal = localTime.ToUniversalTime();
                Console.WriteLine($"Обратная конвертация в UTC: {utcFromLocal}");

                Console.ReadLine();
            }
        }
        */


        class N10
        {
            static void Main()
            {
                Console.WriteLine("Введите количество секунд для обратного отсчёта:");
                if (int.TryParse(Console.ReadLine(), out int seconds) && seconds > 0)
                {
                    for (int i = seconds; i >= 0; i--)
                    {
                        Console.Clear(); 
                        Console.WriteLine($"Обратный отсчёт: {i} секунд");
                        Thread.Sleep(1000); 
                    }
                    Console.WriteLine("Обратный отсчёт завершён!");
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите положительное целое число.");
                }

                Console.ReadLine();
            }
        }
    }
}
