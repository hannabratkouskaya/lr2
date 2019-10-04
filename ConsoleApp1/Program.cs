using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine($" задание 1. типы переменных");
            bool myBoolean = true;
            byte myByte = 10; //целое число от 0 до 255 и занимает 1 байт, если есть s спереди то это от -128 до 128
            short myShort = 100; //хранит целое число от -32768 до 32767 и занимает 2 байта
            ushort myUshort = 13; //хранит целое число от 0 до 65535 и занимает 2 байта
            uint myUint = 10; // беззнаковое
            long myLong = -10; //хранит целое число от –9223372036854775808 до 9223372036854775807 занимает 8 байт
            ulong myUlong = 10; // беззнаковое
            float myFloat = 100.56f; //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта
            double myDouble = 3.888; //хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта
            decimal myDecimal = 7.999m; //от ±1.0*10-28 до ±7.9228*1028 16 байт
            char myChar = 'A';
            string myString = "Hello";
            object myObject = 3.14;
            Console.WriteLine($"Boolean: {myBoolean}");
            Console.WriteLine($"байт: {myByte}");
            Console.WriteLine($"шорт: {myShort}");
            Console.WriteLine($"ушорт: {myUshort}");
            Console.WriteLine($"уинт: {myUint}");
            Console.WriteLine($"лонг: {myLong}");
            Console.WriteLine($"улонг: {myUlong}");
            Console.WriteLine($"флоат: {myFloat}");
            Console.WriteLine($"дабл: {myDouble}");
            Console.WriteLine($"децимал: {myDecimal}");
            Console.WriteLine($"чар: {myChar}");
            Console.WriteLine($"стринг: {myString}");
            Console.WriteLine($"обьект: {myObject}");
            Console.WriteLine($"явное и неявное преобразование типов.");
            decimal nyaDecimal = myShort;
            Console.WriteLine($"неявное преобразование short {myShort} = 2 байта в decimal = 8 байт: {nyaDecimal}");
            long nyaLong = myByte;
            Console.WriteLine($"неявное преобразование byte {myByte} = 1 байт в long = 8 байт: {nyaLong}");
            double nyaDouble = myFloat;
            Console.WriteLine($"неявное преобразование float {myFloat} = 4 байта в double = 8 байт: {nyaDouble}");
            float nyaFloat = myShort;
            Console.WriteLine($"неявное преобразование short {myShort} = 2 байта в float = 4 байт: {nyaFloat}");
            short nyaShort = myByte;
            Console.WriteLine($"неявное преобразование byte {myByte} = 1 байт в short = 2 байт: {nyaShort}");
            Console.WriteLine($" // byte yaPr = myShort; - ТАК НЕЛЬЗЯ");

            byte yaByte = (byte)myShort;
            Console.WriteLine($"явное преобразование short= 2 байта {myShort} в byte 1 байт: {yaByte}");
            double yaDouble = (double)myLong;
            Console.WriteLine($"явное преобразование long= 8 байта {myLong} в double= 8 байт: {yaDouble}");
            float yaFloat = (float)myDouble;
            Console.WriteLine($"явное преобразование double= 8 байта {myDouble} в float= 4 байт: {yaFloat}");
            short yaShort = (short)myDecimal;
            Console.WriteLine($"явное преобразование decimal= 8 байт {myDecimal} в short= 2 байт: {yaShort}");
            uint yaUint = (uint)myLong;
            Console.WriteLine($"явное преобразование long= 8 байт {myLong} в uint= 2 байт: {yaUint}");
            Console.WriteLine($"упаковка-распаковка:");
            int i = 200;
            object o = i;
            int j = (int)o;
            Console.WriteLine($"значимая переменная i {i}, объект о {o}, распаковываем о в  переменнаю j {j}");
            Console.WriteLine($"работа с неявно типизированной переменной:");
            var vari = 5;
            var vars = "ssss";
            Console.WriteLine($"d. неявно типизированная в виде int : {vari}, string {vars} ");
            int? Nullable = null;
            Console.WriteLine($"e.присвоили null числовой переменной при помощи nullable: {Nullable}");
            Console.WriteLine($"задание 2.");

            Console.WriteLine($"а. создайте строковые литералы. объявите их.");
            string number2 = "kkkkkkq";
            string number1 = "rrrrrr";
            Console.WriteLine($"сравнение строк.");
            var zad2a = String.Compare(number1, number2);
            Console.WriteLine($" Compare: {zad2a}");
            string s1 = "hello ";
            string s2 = "it's";
            string s3 = " me";
            string cont = s1 + s2 + s3;
            Console.WriteLine($"сцепление строк: {cont}");
            string s1Copy = String.Copy(s1);
            Console.WriteLine($"копирование строки s1: {s1Copy}");
            string s2Substring = s2.Substring(2);
            Console.WriteLine($"выделение подстроки s2: {s2Substring}");
            string Split = "котики песики собачки";
            string[] Razd = Split.Split(new char[] { ' ' });
            foreach (string s in Razd)
            {
                Console.WriteLine(s);
            }
            string Vstavka = Split.Insert(7, s1);
            Console.WriteLine($"вставка на опр место {Vstavka}");
            string Delete = Split.Remove(Split.Length - 8);
            Console.WriteLine($"удаление {Delete}");
            Console.WriteLine($"null и empty");
            string Nul = null;
            string Empty = "";
            Console.WriteLine($"null: {Nul}, empty: {Empty}");
            var pr1 = String.IsNullOrEmpty(Nul);
            var pr2 = String.IsNullOrEmpty(Empty);
            Console.WriteLine($"Nul: {pr1}, Empty: {pr2}");
            StringBuilder sb = new StringBuilder("я  хочу спать ");
            Console.WriteLine("Длина строки: {0}", sb.Length);

            Console.WriteLine("вставка подстроки: {0}", sb.Insert(2, "очень"));
            Console.WriteLine("удаление символа: {0}", sb.Remove(0, 2));
            Console.WriteLine($"задание 3. массивы");
            Console.WriteLine($"a.	Создайте целый двумерный массив");

            int[,] mas = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 9, 10, 11 } };

            //!
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int ii = 0; ii < rows; ii++)
            {
                for (int jj = 0; jj < columns; jj++)
                {
                    Console.Write($"{mas[ii, jj]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("одномерный массив строк. содержимое, длина, смена жлемента");
            string[] masS = { "ооп - ", "это", " прекрасно" };
            var length = masS.Length;
            Console.WriteLine(length);
            for (int p = 0; p < length; p++)
            {
                Console.Write($"{masS[p]}");
            }
            Console.WriteLine();
            Console.WriteLine("введите номер для замены");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите слово для замены");
            masS[k] = Console.ReadLine();

            for (int l = 0; l < length; l++)
            {
                Console.Write($"{masS[l]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно.Значения массива введите с консоли.");
            int[][] numbers = new int[3][];
            numbers[0] = new int[2];
            numbers[1] = new int[3];
            numbers[2] = new int[4];
            Console.WriteLine("Введите числа массива");
            for (int counter = 0; counter < numbers[0].Length; counter++)
            {
                numbers[0][counter] = Convert.ToInt32(Console.ReadLine());
            }
            for (int counter = 0; counter < numbers[1].Length; counter++)
            {
                numbers[1][counter] = Convert.ToInt32(Console.ReadLine());
            }
            for (int counter = 0; counter < numbers[2].Length; counter++)
            {
                numbers[2][counter] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int counter = 0; counter < numbers[0].Length; counter++)
            {
                Console.Write("{0}\t", numbers[0][counter]);
            }
            Console.WriteLine();
            for (int counter = 0; counter < numbers[1].Length; counter++)
            {
                Console.Write("{0}\t", numbers[1][counter]);
            }
            Console.WriteLine();
            for (int counter = 0; counter < numbers[2].Length; counter++)
            {
                Console.Write("{0}\t", numbers[2][counter]);
            }

            Console.WriteLine();
            Console.WriteLine($"Создайте неявно типизированные переменные для хранения массива и строки");
            var var_str = "";
            var var_mass = new object[0];
            Console.WriteLine($"задание 4. кортежи.");
            Console.WriteLine($"Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.");
            (int, string, char, string, ulong) kortej = (10, "Karl", 'a', "programmer", 1234567);
            Console.WriteLine($"второй элемент: { kortej.Item2}");
            Console.WriteLine($"третий элемент: { kortej.Item3}");
            Console.WriteLine($"четвертый элемент: { kortej.Item4}");
            Console.WriteLine($"пятый элемент: { kortej.Item5}");
            var Item1 = kortej.Item1;
            var Item2 = kortej.Item2;
            var Item3 = kortej.Item3;
            var Item4 = kortej.Item4;
            var Item5 = kortej.Item5;
            Console.WriteLine($"распаковка кортежа в переменные: {Item1}\n {Item2}\n {Item3}\n {Item4}\n {Item5}\n ");
            Console.WriteLine($"сравните кортежи.");
            var leftTuple = (a: 5, b: 10);
            var rightTuple = (a: 5, b: 10);
            Console.WriteLine($"Создайте локальную функцию в main и вызовите ее. Формальные параметры функции – массив целых chisel и стр Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива, сумму элементов массива и первую букву строки.");
            int[] myArr = new int[] { 7, 28, 4, 13, 5, 6, 10 };
            string strFunc = "kakyahochuspat";
            (int, int, int, char) LocalFunc(int[] array, string strMod) // Локальная функция
            {

                int numToCompare = 1;
                int[] localArray = array;
                int numToCompare1 = localArray[0];

                for (int counter = 0; counter < localArray.Length; counter++)
                {

                    if (localArray[counter] > numToCompare)
                    {
                        numToCompare = localArray[counter];
                    }
                }


                for (int counter = 0; counter < localArray.Length; counter++)
                {

                    if (localArray[counter] < numToCompare1)
                    {
                        numToCompare1 = localArray[counter];

                    }
                }

                int Sum = 0;
                for (int counter = 0; counter < localArray.Length; counter++)
                {

                    Sum += localArray[counter];

                }
                string locStr = strMod;
                char myChar2 = locStr[0];
                (int, int, int, char) myTupleLocal = (numToCompare, numToCompare1, Sum, myChar2);
                return myTupleLocal;

            }
            Console.WriteLine($"{LocalFunc(myArr, strFunc)}");
        





        /////кортеж
        (int, string, char, string, long) myTuple = (11, "я строка", 'ы', "я тоже строка", 1037582983658);
            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item2);
            Console.WriteLine(myTuple.Item3);
            Console.WriteLine(myTuple.Item4);
            Console.WriteLine(myTuple.Item5);
            ///распаковка
            (var int1, var string1, var char1, var string2, var long1) = myTuple;
            Console.WriteLine(int1);

            Console.ReadLine();

        }
        

    }
}