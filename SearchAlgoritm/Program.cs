using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgoritm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //Number of elements in the array
        int n;
        // get the number of elements to store in the array
        int i;

        public void input()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Enter the number of elements in the array  ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                {
                    break;
                }
                else
                    Console.WriteLine("\n Array sholud have minimum 1 and maximam 20 elements. \n");
            }

            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter array elements  ");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);

            }
        }
        public void BinarySearch()
        {

            char ch;
            do
            {
                //accept the number to be searched for 
                Console.Write("\n Enter element you want to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                //aplly the Binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the elements in the array
                int mid = (upperbound + lowerbound) / 2;
                int ctr = 1;

                //loop to search for elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (upperbound + lowerbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                {
                    Console.WriteLine("\n" + item.ToString() + "  found at position   " + (mid + 1).ToString());
                }
                else
                {
                    Console.WriteLine("\n" + item.ToString() + "Not found in the array\n");
                }
                    
                Console.WriteLine("\n Number of comparisions  : " + ctr);

                Console.Write("\nContinue search (y|n) ");
                ch = char.Parse(Console.ReadLine());


            } while ((ch == 'Y') || (ch == 'y'));
            
        }
        public void linersearch()
        {

            char ch;
            //Search for number of combarison
            int ctr;
            do
            {
                //accept the number to be searched for 
                Console.Write("\n Enter element you want to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n " + item.ToString() + " found at positon  " + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n " + item.ToString() + " Not Found in the array");
                Console.WriteLine("\n Number of comparison  :" + ctr);
                Console.Write("\nContinue search (y|n) ");
                ch = char.Parse(Console.ReadLine());

            } while ((ch == 'Y') || (ch == 'y'));
        }
        static void Main(string[] args)
        {
           Program se = new Program();
            int choice;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Welcome to array search assistant");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("  choose the searching method    ");
            Console.WriteLine("1. Linear search");
            Console.WriteLine("2. Binary search");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice (1,2,3)  :  ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("===================");
                    Console.WriteLine("   Linear search   ");
                    Console.WriteLine("===================");
                    se.input();
                    se.linersearch();
                    break;
                 case 2:
                    Console.WriteLine("");
                    Console.WriteLine("===================");
                    Console.WriteLine("   Binary search   ");
                    Console.WriteLine("===================");
                    se.input();
                    se.BinarySearch();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("===================");
                    Console.WriteLine("     Thank you     ");
                    Console.WriteLine("===================");
                    break;

                default:
                    Console.WriteLine("Error ");
                    break;
            }





        }
    }
}
