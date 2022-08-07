using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 190, 510, 389 };
            Console.WriteLine(count);
            
        }

    }
    static int NumLength(int num, int temp, int count)
    {
        count = 1;
        temp = num;
        {
            if (temp > 9 || temp < -9)
            {
                temp = temp / 10;
                count++;

               
               
            }
            return (count);
            {

            } 
        }


    }
     


    }
    






