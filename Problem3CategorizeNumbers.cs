using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem3CategorizeNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        double[] arrNum = new double[input.Length];

        List<double> furstList = new List<double>();
        List<double> secondList = new List<double>();

        for (int i = 0; i < input.Length; i++)
        {
            arrNum[i] = double.Parse(input[i]);
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (arrNum[i] % 1 == 0)
            {
                furstList.Add(arrNum[i]);
            }
            else
            {
                secondList.Add(arrNum[i]);
            }
        }
        Console.Write("[");
        secondList.ForEach(a => Console.Write(a + " "));
        Console.Write("] ->");
        Console.WriteLine(" min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
            secondList.Min(), secondList.Max(), secondList.Sum(), secondList.Average());
        Console.Write("[");
        furstList.ForEach(a => Console.Write(a + " "));
        Console.Write("] ->");
        Console.WriteLine(" min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
            furstList.Min(),furstList.Max(), furstList.Sum(), furstList.Average());
        
    }
}

