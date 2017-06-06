using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication107
{


    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("");

            bool val = true;

            try
            { //try

                while (val = true)
                {
                    Console.WriteLine("Введите номер задачи от 1-15, либо наберите 0 для выхода: ");

                    int val2;
                    val2 = Convert.ToInt32(Console.ReadLine());


                    if (val2 == 0)
                    {
                        val = false;
                        Console.WriteLine("Закончено, для выхода нажмите Enter");
                        break;
                    }



                    switch (val2)
                    {
                        case 1:
                            Console.WriteLine("Вывод на экран в одну строку трех любых чисел с двумя пробелами между ними:");
                            Random RandNum = new Random();
                            int[] arr = new int[3];
                            for (int i = 0; i < arr.Length; i++)
                            {
                                int num = RandNum.Next(1, 99);
                                arr[i] = num;
                                Console.Write(arr[i] + " " + " ");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Вывод на экран чисел 5, 10 и 21 одно под другим:");
                            int[] arr2 = { 5, 10, 21 };
                            for (int i = 0; i < arr2.Length; i++)
                            {
                                Console.WriteLine(arr2[i]);
                            }
                            break;

                        case 3:
                            Console.WriteLine("Дано расстояние в сантиметрах. Найти число полных метров в нем:");
                            Console.WriteLine("Введите расстояние в сантиметрах");
                            int distance = Convert.ToInt32(Console.ReadLine());
                            int distance_metr = distance / 100;
                            Console.WriteLine("Полных метров в " + distance + " сантиметрах:");
                            Console.WriteLine(distance_metr);
                            break;

                        case 4:
                            Console.WriteLine("С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
                            int a = 234;
                            a = a / 7;
                            Console.WriteLine("С данного момента прошло " + a + " недели.");
                            break;

                        case 5:
                            int chislo;

                            Console.WriteLine("Введите двузначное число");
                            chislo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Результат: число десятков в нем");
                            int chislo_a = chislo / 10;
                            Console.WriteLine(chislo_a);
                            Console.WriteLine("Результат: число единиц в нем");
                            int chislo_1 = 0;
                            int chislo_2 = 0;

                            if (chislo / 10 == 1)
                            {
                                chislo_1 = 1;
                            }
                            if (chislo - (chislo / 10) * 10 == 1)
                            {
                                chislo_2 = 1;
                            }
                            int chislo_b = chislo_1 + chislo_2;

                            Console.WriteLine(chislo_b);

                            Console.WriteLine("Результат: сумму его цифр");
                            int chislo_c = (chislo - ((chislo / 10) * 10)) + (chislo / 10);
                            Console.WriteLine(chislo_c);
                            Console.WriteLine("Результат: произведение его цифр");

                            int chislo_d = (chislo - ((chislo / 10) * 10)) * (chislo / 10);
                            Console.WriteLine(chislo_d);

                            break;

                        case 6:
                            Console.WriteLine("Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:");

                            Console.WriteLine("a. А или В = Истина");
                            Console.WriteLine("b. А и В = Ложь");
                            Console.WriteLine("c. В или С = Ложь");
                            break;

                        case 7:
                            Console.WriteLine("Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");
                            int sideSquare;
                            int radius = 0;
                            Console.WriteLine("Введите сторону квадрата");
                            sideSquare = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите радиус круга");
                            radius = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Площадь круга составляет:");
                            float sCircle = 3.14f * radius * radius;
                            Console.WriteLine(sCircle);

                            Console.WriteLine("Площадь квадрата составляет:");
                            float sSquare = sideSquare * sideSquare;
                            Console.WriteLine(sSquare);

                            if (sCircle < sSquare)
                            {
                                Console.WriteLine("Площадь круга меньше, чем плошадь квадрата");
                            }
                            else if (sCircle > sSquare)
                            {
                                Console.WriteLine("Площадь круга больше, чем плошадь квадрата");
                            }
                            else
                            {
                                Console.WriteLine("Площадь круга равна плошади квадрата");
                            }
                            break;

                        case 8:
                            Console.WriteLine("Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?");
                            Console.WriteLine("Введите объем первого тела");
                            float v1 = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine("Введите массу первого тела");
                            float m1 = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine("Введите объем второго тела");
                            float v2 = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine("Введите массу второго тела");
                            float m2 = Convert.ToSingle(Console.ReadLine());

                            float p1 = m1 / v1;
                            float p2 = m2 / v2;

                            if (p1 > p2)
                            {
                                Console.WriteLine("Материал первого тела имеет большую плотность");
                            }
                            else
                            {
                                Console.WriteLine("Материал первого тела имеет меньшую плотность");
                            }

                            break;

                        case 9:
                            Console.WriteLine("Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?");
                            Console.WriteLine("Введите сопротивление первого участка цепи ");
                            var R1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите напряжение на первом участке цепи ");
                            var U1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Введите сопротивление второго участка цепи ");
                            var R2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите напряжение на втором участке цепи ");
                            var U2 = Convert.ToDouble(Console.ReadLine());

                            double I1 = U1 / R1;
                            double I2 = U2 / R2;

                            Console.WriteLine("Сила тока на первом участке равна " + I1);
                            Console.WriteLine("Сила тока на втором участке равна " + I2);

                            if (I1 < I2)
                                Console.WriteLine("Сила тока на первом участке меньше, чем навтором ");
                            else if (I1 > I2)
                                Console.WriteLine("Сила тока на первом участке больше, чем на втором ");
                            else
                                Console.WriteLine("Сила тока одинакова на обоих участках ");

                            break;

                        case 10:
                            Console.WriteLine("Напечатать столбиком:");
                            Console.WriteLine("Все целые числа от 20 до 35 ");

                            for (int i = 20; i < 35; i++)
                            {
                                Console.WriteLine(i);
                            }

                            Console.WriteLine("Квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10");

                            Console.WriteLine("Ведите число b, больше 10");
                            var b = Convert.ToInt32(Console.ReadLine());

                            for (int i = 10; i < b; i++)
                            {
                                Console.WriteLine(i * i);
                            }
                            Console.WriteLine("Все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a) ");
                            Console.WriteLine("Ведите число a ");
                            var a10 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ведите число b, больше a");
                            var b10 = Convert.ToInt32(Console.ReadLine());


                            for (int i = a10; i < b10; i++)
                            {
                                Console.WriteLine(i);
                            }


                            break;


                        case 11:
                            Console.WriteLine("Вычисления значения функции y=7x^2-3x+4 при любом значении x ");
                            Console.WriteLine("Введите число x");

                            int x = Convert.ToInt32(Console.ReadLine());

                            int y = 7 * (x * x) - 3 * x + 4;

                            Console.WriteLine("y Равен " + y);

                            break;

                        case 12:
                            Console.WriteLine("Найти длину окружности и площадь круга");
                            int radius12;

                            Console.WriteLine("Введите радиус окружности");
                            radius12 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Длина окружности составляет:");
                            float length = 2 * 3.14f * radius12;
                            Console.WriteLine(length);

                            Console.WriteLine("Площадь круга составляет:");
                            float sCircle12 = 3.14f * radius12 * radius12;
                            Console.WriteLine(sCircle12);

                            break;


                        case 13:
                            Console.WriteLine("Найти сумму и произведение цифр четырехзначного числа");
                            int chislo13;

                            Console.WriteLine("Введите четырехзначное число");
                            chislo13 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Сумма цифр ");


                            Console.WriteLine((chislo13 / 1000) + ((chislo13 % 1000) / 100) + ((chislo13 % 1000) % 100) / 10 + ((chislo13 % 1000) % 100) % 10);
                            Console.WriteLine("Произведение цифр ");
                            Console.WriteLine(((chislo13 / 1000)) * (((chislo13 % 1000) / 100)) * (((chislo13 % 1000) % 100) / 10) * (((chislo13 % 1000) % 100) % 10));

                            break;

                        case 14:
                            Console.WriteLine("В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x ");

                            Console.WriteLine("Введите трехзначное число образованное при добавлении к нему второй цифры числа Х, например 465");


                            int a14;
                            a14 = Convert.ToInt32(Console.ReadLine());

                            int b14 = ((a14 / 100) * 100) + ((a14 % 10) * 10) + ((a14 % 100) / 10);

                            Console.WriteLine("Число Х равно: ");
                            Console.WriteLine(b14);

                            break;

                        case 15:
                            Console.WriteLine("Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:");
                            Console.WriteLine("Не X и не Y - Ложь ");
                            Console.WriteLine("X или (не X и Y) - Истина ");
                            Console.WriteLine("(не X и Y) или Y - Истина ");

                            break;


                    }//окончание Switch
                    Console.WriteLine();


                }
            }//try
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод, для выхода нажмите Enter");
            }

            Console.ReadLine();

        }

    }
}