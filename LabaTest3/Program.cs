using System;

namespace LabaTest3
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static double funkVar3(int num)
        {

            if (num >= 0)
            {
                return ln(num) * cos(num);
            }
            else return abs(sin(num) - cos(num)) / (ln(Convert.ToInt32(abs(num))) + 1);


        }


        public static double sin(int num)
        {
            int m = 1;
            double sign = 1;
            double sin1 = 0;
            double sin2 = 10;
            double eps = 0.00001;

            while (abs(sin1 - sin2) > eps)
            {
                sin2 = sin1;

                sin1 = sin1 + sign * (pow(m, num) / fakt(m));
                
                m += 2;
                sign = -sign;
            }

            return sin1;
        }

        public static double fakt(int number)
        {
            if (number < 0)
            {
                throw new Exception("число меньше или равно 0");
            }

            double result = 1;
            for (int i = 1; i < number + 1; i++)
            {
                result *= i;
            }

            return result;
        }

        public static int pow(double pow, int number)
        {
            int result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }

            return result;
        }
        public static double abs(double x)
        {
            if (x < 0)
            {
                return -x;
            }
            else return x;
        }

        public static double ln(int num)
        {

            double i = 1.0;
            double sign = 1;
            double ln1 = 0;
            double ln2 = 10;
            double eps = 0.00001;

            while (abs(ln1 - ln2) > eps)
            {
                ln2 = ln1;
                ln1 = ln1 + sign * (pow(i, num - 1) / i);

                sign = -sign;
                i++;
            }

            return ln1;
        }

        public static double cos(int num)
        {
            int m = 2;
            double sign = 1;
            double cos1 = 0;
            double cos2 = 10;
            double eps = 0.00001;

            while (abs(cos1 - cos2) > eps)
            {
                cos2 = cos1;

                cos1 = cos1 + sign * (pow(m, num) / fakt(m));

                m += 2;
                sign = -sign;
            }

            return 1 - cos1;
        }

    }
}
