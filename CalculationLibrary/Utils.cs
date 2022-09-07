using System;
using System.Linq;

namespace CalculationLibrary
{
    public class Utils
    {
        public bool isRightTriangle(int a, int b, int c)
        {
            var arr = new int[] { a, b, c };
            var maxNumber = GetMaxNumber(arr);
            var newArray = GetArrayWithOtherSides(arr, maxNumber);

            int index = 0;
            if (newArray[index] * newArray[index] + newArray[index + 1] * newArray[index + 1] == maxNumber * maxNumber)
            {
                return true;
            }
            return false;
        }

        public int GetMaxNumber(int[] array)
        {
            var maxNumber = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > maxNumber) maxNumber = array[i];
            }
            return maxNumber;
        }

        public int[] GetArrayWithOtherSides(int[] array, int numberToExclude)
        {
            array = array.Where(element => element != numberToExclude).ToArray();
            return array;
        }

        public int GetNumberFor(string str)
        {
            Console.WriteLine(str);
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}

