using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            ////ARRYS
            ////first way
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //Console.WriteLine(numArray[1]);
            //Console.ReadLine();

            ////easier way

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000,600,2300 };

            ////another way 

            //int[] numArray2 = { 1, 4, 6, 19, 20,60,90 };


            ////changing
            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();

            ////LISTS
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            byte[] byteArray = new byte[5000];



        }
    }
}   

