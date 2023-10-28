using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint3.Task7.V6.Lib;

namespace Tyuiu.MusaevRS.Sprint3.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Console.Title = "Спринт #3 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание №7                                                              *");
            Console.WriteLine("* Вариант №6                                                              *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Написать программу, которая вычислит таблицу значений функций            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue                                                 );
            Console.WriteLine("Конец шага = " + stopValue                                                  );
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            DataService ds = new DataService();

            int len = ds.GetMassFunction(startValue,stopValue).Length;

            double[] res;
            res = new double[len];

            res = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+---------+----------------+");
            Console.WriteLine("|   X     |     f(x)       |");
            Console.WriteLine("+---------+----------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}    |   {1,8:f2}     |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+---------+----------------+");
            Console.ReadKey();

        }
    }
}
