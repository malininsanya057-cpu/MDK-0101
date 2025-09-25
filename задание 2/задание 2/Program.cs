using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    public class Program
    {
        static void Main()
        {
           
            Random random = new Random();  
           
            int[] numbers = new int[1500];
            for (int i = 0; i < 1500; i++)  
            {
                numbers[i] = random.Next(1, 201);  
            }


        }
    }
}
