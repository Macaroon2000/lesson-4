//Крылов Роман (Попытка pull request 6)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4
{

    internal class Program

    {
        static string pop(int x)  //склонение слова "попытка"
        {
            string slovo = "";
            // 1, 21, 31, 41, 51 попытка и т.д. (кроме 11)
            if (x % 10 == 1 && x != 11) slovo += " попытка";
            // 2, 3, 4, 22, 23, 24 попытки и аналогично
            else if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24)) slovo += " попытки";
            // 11, 5, 6, 7 ... 20, 25, 26 ... 30 попыток и аналогично          
            else if ((x == 11) || (x >= 5 && x <= 20)) slovo += " попыток";
            return slovo;
        }


        static void Main(string[] args)
        {

            /*
            Урок 2, Задача 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу:
            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.

            2.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
            Создайте структуру Account, содержащую Login и Password.
            */




            //логин и пароль возьмем из файла
            StreamReader sr = new StreamReader("login.txt");    //если файл положить в папку Debug, то путь к нему расписывать не нужно
            string LoginFile = sr.ReadLine();    //читаем первую строку файла
            string PasswordFile = sr.ReadLine();     //читаем вторую строку
            sr.Close();    //закрываем файл



            Console.WriteLine("Проверка логина и пароля");
            int pops = 3;

            do
            {

                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();


                //if (login == "root" && password == "GeekBrains")   // это условие из урока 2
                if (login == Convert.ToString(LoginFile) && password == Convert.ToString(PasswordFile))
                {
                    Console.WriteLine("Авторизация успешна!");
                    break;
                }
                else if (pops == 1)
                {

                    Console.WriteLine("Неверный ввод логина или пароля." +
                    Environment.NewLine + "У Вас не осталось попыток.");
                    break;

                }

                else
                {

                    Console.WriteLine("Неверный ввод логина или пароля." +
                    Environment.NewLine + "У Вас осталось " + --pops + pop(pops));
                }

            } while (pops > 0);



            Console.WriteLine("");
            Console.WriteLine("");




            /*а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, 
            * создающий массив определенного размера и заполняющий массив числами от начального значения 
            * с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, 
            * возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), 
            * метод Multi, умножающий каждый элемент массива на определённое число, 
            * свойство MaxCount, возвращающее количество максимальных элементов.
            * б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            */


            int[] array;
            Console.WriteLine("Формирование одномерного массива.");
            Console.Write("Размер (кол-во элементов): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Первое значение: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Шаг+ между элементами: ");
            int step = Convert.ToInt32(Console.ReadLine());
            Console.Write("Коэффициент умножения: ");
            int k = Convert.ToInt32(Console.ReadLine());



            array = new int[n];
            array[0] = first;
            for (int i = 1; i < n; i++)
                array[i] = array[i - 1] + step;

            Console.Write("Результат: ");
            int ii;
            for (ii = 0; ii < n; ii++)
                Console.Write("{0} ", array[ii]);
            Console.WriteLine("");




            int sum = first;
            for (int i = 1; i < n; i++)
                sum = array[i] + sum;

            Console.Write("Сумма элементов массива: " + sum);
            Console.WriteLine("");








            int[] array2;
            array2 = new int[n];
            for (int i = 0; i < n; i++)
                array2[i] = array[i] * -1;

            Console.Write("Инверсия: ");
            int iii;
            for (iii = 0; iii < n; iii++)
                Console.Write("{0} ", array2[iii]);
            Console.WriteLine("");


            int[] array3;
            array3 = new int[n];
            for (int i = 0; i < n; i++)
                array3[i] = array[i] * k;

            Console.Write("Умножить на " + k + ": ");
            int iiii;
            for (iiii = 0; iiii < n; iiii++)
                Console.Write("{0} ", array3[iiii]);
            Console.WriteLine("");


            int max;
            max = array[0];
            for (int i = 1; i < n; i++)
                if (array[i] > max) max = array[i];
            //return;

            Console.Write("Максимум: " + max);
            Console.WriteLine("");


            int count = 0;
            for (int i = 0; i < n; i++)
                if (array[i] == max) count++;
            Console.Write("Кол-во макс. значений: " + count);
            Console.WriteLine("");


            Console.WriteLine("");
            Console.Write("Для завершения нажмите Enter");
            Console.ReadKey();



        }

        struct Account
        {
            static readonly string Login = "root";
            static readonly string Password = "GeekBrains";

            public static string getLogin()
            {
                return Login;
            }

            public static string getPassword()
            {
                return Password;
            }
        }

    }

}
