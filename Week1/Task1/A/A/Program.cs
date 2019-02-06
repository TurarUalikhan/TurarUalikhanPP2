using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static bool IsPrime(int n) //create bool type
        {
            if (n == 1) return false; //number one is not a prime, so we return false
            for (int i = 2; i < n; i++)//we create a cycle for, and start from 2 (bc 2 is the smallest prime number)
            {
                if (n % i == 0) return false; //If number n can be divided by any other i, return false
            }
            return true; //other cases outside of cycle for is true

        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine(); 
            int s = int.Parse(n); //create n (number of elements in array) and then parse it and assign it's value to s;
            string k = Console.ReadLine();
            string[] arr = k.Split(); // create string k (all numbers in array) split it, so we can have seperate numbers, assign it to the array 

            int cnt = 0; //create int cnt, for numbers of prime elements in array
            for (int i = 0; i < arr.Length; i++) // create cycle for, end it at "arr.length" that stands for length of arr array
            {

                int num = int.Parse(arr[i]); //create int num assign it's value to Parsed i element from arr array
                if (IsPrime(num)) //using prime function 
                {
                    cnt++; //everytime any element will pass this function cnt will be increased by 1, so at the end we will have the number of prime ellements
                }
            }
            Console.WriteLine(cnt); //showing number of prime elements
            for (int i = 0; i < arr.Length; i++) //create cycle, for running through all prime elements and show it
            {

                int num = int.Parse(arr[i]); //again creating int num and parse it, for listing prime elements
                if (IsPrime(num)) //if its prime it will be shown on the screen
                {
                    Console.Write(num); //showing the prime element
                    Console.Write(' '); //add space, so elements would be seperate;
                }
            }
        }
    }
}
