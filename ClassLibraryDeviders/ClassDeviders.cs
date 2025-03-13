using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDeviders
{
    public class ClassDeviders
    {
        /// <summary>
        /// Поиск делителей числа
        /// </summary>
        /// <param name="N">целое число</param>
        /// <returns>HashSet из делителей</returns>
        public static HashSet<int> Deviders(int N)
        {
            //проверка числа
            if (N < 1)
                throw new Exception("Число ненатуральное");

            //массив с уникальными делителями
            HashSet<int> devides = new HashSet<int>();

            //ускорение вычислений путём уменьшения границы
            int sqrtN = (int)Math.Floor(Math.Sqrt(N));

            for (int i = 1; i <= sqrtN; i++)
                if (N % i == 0)
                {
                    devides.Add(N / i);
                    devides.Add(i);
                }

            return devides;
        }

        /// <summary>
        /// Поиск чисел с 5-ю делителями на отрезке
        /// </summary>
        /// <param name="m">левый конец отрезка</param>
        /// <param name="n">правый конец отрезка</param>
        /// <returns>список найденных чисел</returns>
        /// <exception cref="Exception"></exception>
        public static List<int> FiveDeviders(int m, int n)
        {
            if (m > n)
                throw new Exception("Левый конец отрезка не может быть больше правого");
            else if (m < 0 && n < 0)
                throw new Exception("Ненатуральное число содержится в отрезке");

            //список чисел с 5 делителями
            List<int> MasD = new List<int>();

            //минимальный корень 4-ой степени числа из отрезка
            int mini = (int)Math.Ceiling(Math.Sqrt(Math.Sqrt(m)));

            int mid = (int)Math.Pow(mini, 4);

            while (mid <= n)
            {
                MasD.Add(mid);
                mini++;
                mid = (int)Math.Pow(mini, 4);
            }

            return MasD;
        }

        /// <summary>
        /// Поиск N-ого простого числа
        /// </summary>
        /// <param name="n">порядковый номер простого числа</param>
        /// <returns>N-ое простое число</returns>
        public static int Prost(int n)
        {
            //проверка входных данных
            if (n < 1)
                throw new Exception("Нахождение простого числа невозможно");

            //объявление переменных
            List<int> prostmas = new List<int>();
            int num = 3, key = 1;
            bool flag;
            prostmas.Add(2);

            while (key < n)
            {
                flag = true;
                foreach (int i in prostmas)
                    if (num % i == 0)
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                {
                    prostmas.Add(num);
                    key++;
                }

                num += 2;
            }

            return prostmas[n-1];
        }

        /// <summary>
        /// Факторизация числа
        /// </summary>
        /// <param name="N">вводимое натуральное число</param>
        /// <returns>список простых делителей</returns>
        public static List<int> Factoria(int N)
        {
            List<int> prostdeviders = new List<int>();
            int num = 1, prdev;

            while (N > 1)
            {
                prdev = Prost(num);

                while (N % prdev == 0)
                {
                    prostdeviders.Add(prdev);
                    N /= prdev;
                }

                num++;
            }

            return prostdeviders;
        }
    }
}
