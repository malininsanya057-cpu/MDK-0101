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
           
            int[] count = new int[201];  
            foreach (int num in numbers)  
            {
                count[num]++; 
            }

            int uniqueCount = 0;  
            for (int i = 1; i <= 200; i++)  
            {
                if (count[i] == 1)
                    uniqueCount++;   
            }
            
            int[] uniqueNumbers = new int[uniqueCount]; 
            int index = 0; 

           
            for (int i = 1; i <= 200; i++)  
            {
                if (count[i] == 1)  
                {
                    uniqueNumbers[index] = i; 
                    index++;  
                }
            }

            Console.Write("[");
            for (int i = 0; i < uniqueNumbers.Length; i++)  
            {
                Console.Write(uniqueNumbers[i]);  
                if (i < uniqueNumbers.Length - 1) 
                    Console.Write(", ");  
            }
            Console.WriteLine("]");  

        }
    }
}
