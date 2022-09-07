using System;

namespace Prakt3
{
    public class CountSysConverter
    {
        
        private int a;

        public CountSysConverter(int a_u)
        {
            a = a_u;
        }
        /// <summary>
        /// Перевод натурального десятичного числа в натуральное h-ричное
        /// </summary>
        /// <param name="a">Натуральное десятичное число</param>
        /// <returns>Натуральное h-ричное число</returns>

        public long Convertnum(int system)
        {
            long num = 0;
            long promezhutocha = a;

            for (int i = 0; promezhutocha >= 1; i++)
            {
                num += Convert.ToInt64((promezhutocha % system) * Math.Pow(10, i));
                promezhutocha /= system;
            }

            return num;
        }

    }
}
