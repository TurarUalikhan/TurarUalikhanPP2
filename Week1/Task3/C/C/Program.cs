using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine(); //create line1 (number of elements in the array)
            string line2 = Console.ReadLine(); //create line2 (elements in the arra)s
            string[] parts = line2.Split(); //assign splited element of line2 to the array parts
            int[] arr = new int[int.Parse(line1) * 2]; // create an array that has 2x elements 
            int cnt = -1; //create cnt with value -1, so when we will increase it, it will start at 0
            for(int i = 0; i< parts.Length; i++) //cycle 
            {
                cnt++; //increase cnt by 1 
                arr[cnt] = int.Parse(parts[i]); //parse i and assign it value to cnt's element of arr array
                cnt++; //increase by 1
                arr[cnt] = int.Parse(parts[i]);//parse i and assign it value to cnt's element of arr array
                //we do it 2 times so there would be 2 same elements standing to each other and it will continue until cycle will reach its end

            }
            for (int i = 0; i < arr.Length; i++)//cycle for listing elements
            {
                Console.Write(arr[i]);//write an element i
                Console.Write(' ');//add space to make all elements seperate
            }
        }

        
    }
}
