using C_Sharp_Module2_Exercise2A_SumOfNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Module2_Exercise2A_SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputs = new double[10];
            double sum = 0;
            for (int i=0; i<10; i++)
            {
                do
                {
                    inputs[i] = UserInput.UserInputScore();
                    if (inputs[i] < 0 || inputs[i] > 100)
                        Console.WriteLine("Invalid Input. Re-Enter data");
                } while (inputs[i] < 0 || inputs[i] > 100);
            sum = sum + inputs[i];
            }
            Console.WriteLine("");
            Console.WriteLine("Sum of the scores is {0}", UserInput.sumArray(inputs));
        }
    }
}


