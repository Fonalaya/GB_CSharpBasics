using System;

namespace lesson_2

{
    internal class Program
    {
        static void Main(string[] args)

        //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

        /*{
            Console.WriteLine("Введите миниммальную температуру за сутки.");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Теперь введите максимальную температуру за сутки.");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((max + min) / 2 + " - среднесуточная температура за сутки.");
            Console.ReadLine();
        }*/

        //Запросить у пользователя порядковый номер текущего месяца и вывести его название.

        /*       {
                   Console.WriteLine("Введите порядковый номер текущего месяца.");
                   switch (Console.ReadLine())
                   {
                       case "01":
                       case "1":
                           Console.WriteLine("January");
                           break;

                       case "02":
                       case "2":
                           Console.WriteLine("February");
                           break;
                       case "03":
                       case "3":
                           Console.WriteLine("March");
                           break;
                       case "04":
                       case "4":
                           Console.WriteLine("April");
                           break;

                       case "05":
                       case "5":
                           Console.WriteLine("May");
                           break;
                       case "06":
                       case "6":
                           Console.WriteLine("June");
                           break;
                       case "07":
                       case "7":
                           Console.WriteLine("July ");
                           break;
                       case "08":
                       case "8":
                           Console.WriteLine("August");
                           break;
                       case "09":
                       case "9":
                           Console.WriteLine("September");
                           break;
                       case "10":
                           Console.WriteLine("October");
                           break;
                       case "11":
                           Console.WriteLine("November");
                           break;
                       case "12":
                           Console.WriteLine("December");
                           break;
                   }
                   Console.ReadLine();
               }
       */


        //Определить, является ли введённое пользователем число чётным.


        /*        {
                    Console.WriteLine("Введите любое целое число.");
                    int number = Convert.ToInt32(Console.ReadLine());
                    number %= 2;
                    if (number == 0)
                    {
                        Console.WriteLine("Четное");
                    }
                    else
                    {
                        Console.WriteLine("Нечетное");
                    }
                    Console.ReadLine();
                }
        */
        //1.	Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, только
        //      за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были заранее
        //      заготовлены до вывода на консоль.

        /*        {
                    string time = "13:12";
                    string Date = "13/012/2023";
                    int price = 1260;
                    int promotion = 18;
                    int c = price * promotion / 100;
                    int result = price - c;

                    int nal = 1500;
                    int res = nal - result;

                    Console.WriteLine("                 ЧЕК");
                    Console.WriteLine("              КУБАПРИНТ");
                    Console.WriteLine("      ИП Широков Станислав Юрьевич");
                    Console.WriteLine("ИНН ОРГ.-ПРОДАВЦА     7700000000");
                    Console.WriteLine("ДТ           N 23: 2516           " + price);
                    Console.WriteLine("RBL      19,50 X 70,000");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("ИТОГО                             " + result);
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Рубль России                      " + result);
                    Console.WriteLine("Наличными                         " + nal);
                    Console.WriteLine("СДАЧА                              " + res + "-");
                    Console.WriteLine("ЭКЛЗ 2323236787");
                    Console.WriteLine("               СПАСИБО");
                    Console.WriteLine("              ЗА ПОКУПКУ");
                    Console.WriteLine("ЧЕК 0924 "   + Date + "  " + time + " 0231");
                    Console.ReadLine();
                }*/
        // (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».

        /*        {
                    Console.WriteLine("Напишете месяц");
                    string month = Console.ReadLine();
                    Console.WriteLine("Введите миниммальную температуру за сутки.");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Теперь введите максимальную температуру за сутки.");
                    int max = Convert.ToInt32(Console.ReadLine());
                    int res = (max + min) / 2;

                    switch (month)
                    {
                        case "Декабрь":
                        case "декабрь":
                        case "Январь":
                        case "январь":
                        case "Февраль":
                        case "февраль":

                            if (res > 0)
                                {
                                    Console.WriteLine("Дождливая зима");
                                    Console.ReadLine();
                                }
                            break;
                    }

                }*/

        // (*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, к примеру,
        // чтобы описать работу какого либо офиса. Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает
        // с понедельника до воскресенья и выведите его на экран консоли.

        {


        }

        //Написать программу, которая определяет является ли год високосным, и выводит сообщение в консоль.
        //Каждый 4-й год является високосным, кроме каждого 100-го, при этом каждый 400-й – високосный.

/*        {
            Console.WriteLine("Напишите год");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x;
            int b = x;
            int c = x;
            a %= 4;
            b %= 100;
            c %= 400;
            if (a == 0 && b != 0)
            {
                Console.WriteLine("Високосный");
            }
            else if (b == 0 && c != 0)
            {
                Console.WriteLine("Невисокосный");
            }
            else if (c == 0)
            {
                Console.WriteLine("Високосный");
            }
            else
            {
                Console.WriteLine("Невисокосный");
            }
            Console.ReadLine();
        }*/
    }
}
