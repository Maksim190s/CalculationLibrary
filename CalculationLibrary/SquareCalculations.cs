using System;

namespace CalculationLibrary
{
    public class SquareCalculations
    {
        Utils utils = new Utils();

        public double CalcCircleSquareByR(double r)
        {
            return 3.1415 * r * r;
        }


        public double CalcSquareTriangleBySides(int a, int b, int c)
        {
            if (utils.isRightTriangle(a, b, c))
            {
                var arr = new int[] { a, b, c };

                var maxNumber = utils.GetMaxNumber(arr);
                var array = utils.GetArrayWithOtherSides(arr, maxNumber);
                return CalcRightTriangle(array);
            }
            else
            {
                var semiprimeter = a + b + c / 2;
                return Math.Sqrt(semiprimeter * (semiprimeter - a) * (semiprimeter - b) * (semiprimeter - c));
            }
        }

        public double CalcSquareOfUnknownFigure()
        {
            //Requests for parameters
            Console.WriteLine("Введите известные переменные. Если переменная не известна, введите 0!");
            var r = utils.GetNumberFor("Радиус: ");
            var s1 = utils.GetNumberFor("Сторона 1: ");
            var s2 = utils.GetNumberFor("Сторона 2: ");
            var s3 = utils.GetNumberFor("Сторона 3: ");

            var result = CalcOptions(r, s1, s2, s3);
            if (result == 0)
            {
                Console.WriteLine("Для данных параметров невозможно определить площадь фигуры.");
            }
            return result;
        }

        public double CalcOptions(int radius, int side1, int side2, int side3)
        {
            if (radius != 0 && side1 == 0 && side2 == 0 && side3 == 0)
            {
                return CalcCircleSquareByR(radius);
            }
            if (radius == 0 && side1 != 0 && side2 != 0 && side3 != 0)
            {
                return CalcSquareTriangleBySides(side1, side2, side3);
            }
            else
            {
                return 0;
            }

        }

        public double CalcRightTriangle(int[] array)
        {
            var sum = 1;
            for (var i = 0; i < array.Length; i++)
            {
                sum = sum * array[i];
            }
            return sum / 2;
        }
    }

}

