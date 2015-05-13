using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem5LongestIncreasingSequence
{
    static void Main(string[] args)
    {

        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        List<int> sequence = new List<int>();
        List<int> longest = new List<int>();

        for (int i = 0; i < num.Length-1; i++)
        {
            if (num[i] < num[i + 1])
            {
                sequence.Add(num[i]);
                Console.Write("{0} ",num[i]);
            }            
            else
            {
                sequence.Add(num[i]);
                Console.WriteLine("{0} ", num[i]);
                if (sequence.Count > longest.Count)
                {

                    longest.Clear();
                    longest = sequence.ToList();

                }
               
                sequence.Clear();            
            }
            if (i + 1 == num.Length - 1)
            {
                sequence.Add(num[i+1]);
                Console.WriteLine("{0} ", num[i+1]);
                if (sequence.Count > longest.Count)
                {

                    longest.Clear();
                    longest = sequence.ToList();

                }
            }
            
            
            

        }
        Console.WriteLine(string.Join(" ", longest));
    }
}
