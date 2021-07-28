using System;
using System.Collections.Generic;

namespace SpeedLimit
{
    /**
     * Answer to the SpeedLimit problem in Kattis.
     * By Oujun Xu
     */
    public class SpeedLimit
    {
        static void Main(string[] args)
        {
            List<int> distances = new List<int>();
            while (true)
            {
                string input = Console.ReadLine(); // stores the total number of data inside every data-sets.
                if(input == "-1")
                {
                    break;
                }
                else
                {
                    int distance = 0; // total distance travelled
                    int previous_time = 0; // previous elapsed time 

                    for(int i = 0; i<int.Parse(input); i++)
                    {
                        string[] speed_time = Console.ReadLine().Split(" ");
                        int speed = int.Parse(speed_time[0]);
                        int elapsed_time = int.Parse(speed_time[1]);

                        int total_elapsed_time = elapsed_time - previous_time;
                        previous_time = elapsed_time;
                        distance += speed * total_elapsed_time;   
                    }
                    distances.Add(distance); 
                }
            }
            
            foreach(var d in distances)
            {
                Console.WriteLine($"{d} miles");
            }
        }
    }
}
