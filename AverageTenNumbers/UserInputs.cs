using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Module2_Exercise2A_SumOfNumbers
{
    class UserInput
    {
        public static double UserInputScore()
        {
            Console.Write("Enter a number between 0 to 100: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double sumArray(double[] array)
        {
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
    }

}
