using System;
using System.Collections;
using System.Collections.Generic;


namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);

            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Godfred");
            intList.Remove("Godfred");

            Console.WriteLine(intList[0]);
            Console.ReadLine();



            ////int[] numArray = new int[5];
            ////numArray[0] = 5;
            ////numArray[1] = 2;
            ////numArray[2] = 10;
            ////numArray[3] = 200;
            ////numArray[4] = 5000;

            //int[] numArray1 = { 5, 2, 10, 200, 5000 };

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();
        }
    }
}
