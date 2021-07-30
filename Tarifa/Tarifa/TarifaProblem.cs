using System;
using System.Collections.Generic;

namespace Tarifa
{
    /**
     * The solution to Tarifa problem from Kattis
     */
    public class TarifaProblem
    {
        static void Main(string[] args)
        {
            int provided_data = int.Parse(Console.ReadLine()); // the first data from the input is the total provided data each month.
            int months = int.Parse(Console.ReadLine()); // this is the number of months that has past minus the current one.
            int sum = 0;
            List<int> total_data_left = new List<int>();
            
            //gets the used data minus the provided data to see whats left from the period.
            for(int i = 0; i < months; i++) 
            {
                int data_used = int.Parse(Console.ReadLine());
                int result = provided_data - data_used;
                total_data_left.Add(result);
            }
            total_data_left.Add(provided_data);

            foreach(var num in total_data_left)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
