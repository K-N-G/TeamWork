using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem4SequencesEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Console.Write("{0} ",input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            
            if (input[i - 1] == input[i])
            {
                Console.Write("{0} ", input[i]);
            }
            else
            {
                Console.WriteLine();
                Console.Write("{0} ", input[i]);
            }
        }
    }
}

