using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt5_Erdniev
{
    class Array
    {

        public static int[] getArray(int amount, bool random)
        {
            int[] array = new int[amount];

            if(random == true)
            {
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(1, 10);
                }
            }
            return array;
        }
        public static int[] getNewArray(int[] arr, int amount, int numforcalcs) // aray from datagridview and amount of elements in new array needed
        {
            int j = 0;
            int[] newarr = new int[amount];
            for (int i = 0; i < newarr.Length; i++)
            {
                    newarr[i] = arr[j];
                    if(j % numforcalcs == 0 )
                    {
                        newarr[i + 1] = 1;
                        i++;
                    }
                    if (j < arr.Length)
                {
                    j++;
                }
                //в двойном цикле вводить в новый массив значения со старого, но если индекс кратен, то j=j-- или типа того
            }

            return newarr;
        }
    }
}
