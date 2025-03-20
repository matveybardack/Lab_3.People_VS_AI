using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDividers
{
    public class ClassDividers
    {
        /// <summary>
        /// Поиск делителей числа
        /// </summary>
        /// <param name="N">целое число</param>
        /// <returns>HashSet из делителей</returns>
        public static HashSet<int> Dividers(int N)
        {
            //массив с уникальными делителями
            HashSet<int> divides = new HashSet<int>();

            //ускорение вычислений путём уменьшения границы
            int sqrtN = (int)Math.Floor(Math.Sqrt(N));

            for (int i = 1; i <= sqrtN; i++)
                if (N % i == 0)
                {
                    divides.Add(N / i);
                    divides.Add(i);
                }

            return divides;
        }

        /// <summary>
        /// Поиск чисел с 5-ю делителями на отрезке
        /// </summary>
        /// <param name="m">левый конец отрезка</param>
        /// <param name="n">правый конец отрезка</param>
        /// <returns>список найденных чисел</returns>
        public static List<int> FiveDividers(int m, int n)
        {
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
            List<int> prostdividers = new List<int>();
            int num = 1, prdiv;

            while (N > 1)
            {
                prdiv = Prost(num);

                while (N % prdiv == 0)
                {
                    prostdividers.Add(prdiv);
                    N /= prdiv;
                }

                num++;
            }

            prostdividers.Sort();

            return prostdividers;
        }

        /// <summary>
        /// Поиск первых N простых чисел
        /// </summary>
        /// <param name="N">кол-во простых чисел</param>
        /// <returns>список простых чисел</returns>
        public static List<int> ProstDiv(int N)
        {
            List <int> prostdiv = new List<int>();
            int num = 3;
            prostdiv.Add(2);

            while (prostdiv.Count < N)
            {
                if (Dividers(num).Count == 2)
                    prostdiv.Add(num);

                num+=2;
            }

            return prostdiv;
        }

        /// <summary>
        /// Поиск первых N простых чисел (алгоритм Решето Эратосфена)
        /// </summary>
        /// <param name="N">кол-во простых чисел</param>
        /// <returns>список простых чисел</returns>
        public static List<int> ProstDivEr(int N)
        {
            //объявление переменных
            List<int> prostmas = new List<int>();
            int num = 3;
            bool flag;
            prostmas.Add(2);

            while (prostmas.Count < N)
            {
                flag = true;

                foreach (int i in prostmas)
                    if (num % i == 0)
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    prostmas.Add(num);

                num += 2;
            }

            return prostmas;
        }

        /// <summary>
        /// Поиск наибольшего общего делителя (алгоритм Евклида)
        /// </summary>
        /// <param name="m">первое число (большее)</param>
        /// <param name="n">второе число (меньшее)</param>
        /// <returns>наибольший общий делитель 2-х чисел</returns>
        public static int NOD(int m, int n)
        {
            if (n > m)
            {
                int temp = m;
                m = n;
                n = temp;
            }

            int nod = n;

            while (m % n != 0)
            {
                m %= n;

                if (n > m)
                {
                    int temper = m;
                    m = n;
                    n = temper;
                }

                nod = n;
            }

            return nod;
        }

        /// <summary>
        /// Наименьшее общее кратное
        /// </summary>
        /// <param name="m">первое число</param>
        /// <param name="n">второе число</param>
        /// <returns>наименьшее общее кратное 2-х чисел</returns>
        public static int NOK(int m, int n)
        {
            int nok = m * n / NOD(m, n);
            return nok;
        }
    }
}
