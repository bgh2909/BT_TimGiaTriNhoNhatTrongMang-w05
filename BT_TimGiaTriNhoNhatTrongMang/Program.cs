using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_TimGiaTriNhoNhatTrongMang
{
    internal class Program
    {
        public static int MinValue(int[] array)
        {
            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }

        static void Main(string[] args)
        {
            int[] array = { 24, 76, 4, 24, 20, 67, 49, 81 };
            int index = MinValue(array);
            Console.WriteLine("The smallest element in the array is: " + array[index]);

            Console.ReadKey();
        }
    }
}
