using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace subhashgehlot
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            switch (args[0])
            {
                //Adds the Numbers specified in the arguments : Task 1
                case "sum":
                    if (args.Length > 1)
                    { prog.Sum(args[1]); }
                    else
                    {
                        Console.Write("Sum of the numbers is : 0");
                        Console.Read();
                    }
                    break;

                //Adds the Numbers specified in the arguments : Task 2
                case "add":
                    if (args.Length > 1)
                    {
                        string[] numbersArray = args[1].Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                        string delimeter = numbersArray[0];//Stores the splitting delimeter entered by the user
                        string data = numbersArray[1];//Stores the data

                        prog.Add(data, delimeter);    

                    }
                    else
                    {
                        Console.Write("Sum of the numbers is : 0");
                        Console.Read();
                    }
                    break;
                    
            }
        }

        //checks whether the data provided contains any negative values
        bool checkNegative(string data)
        {
            if(data.Contains('-'))
                return true;
            else
                return false;
        }


        //Adds the Numbers specified in the arguments
        void Sum(string numbers)
        {
            int sum = 0;

            if (numbers != null)
            {

                char splitter = ',';
                string[] numbersArray = numbers.Split(splitter);

                for (int counter = 0; counter < numbersArray.Count(); counter++)
                {
                    sum += Convert.ToInt16(numbersArray[counter]);
                }

                Console.Write("Sum of the numbers is :" + sum);
                Console.Read();

            }
        }

        //Adds the Numbers specified in the arguments
        void Add(string numbers,string splitter)
        {
            int sum = 0;

            if (numbers != null)
            {
                
                //Spliter is used for splitting comma and new line argument given
               //Commented because implimented Task 4 having user defined delimeter
                //string[] splitter = new string[] { ",", "\\n" };
               
                string[] numbersArray = numbers.Split(new string[] { splitter }, StringSplitOptions.None);
                //Task 6
                if (checkNegative(numbers))
                {
                    var negativeNumbers = numbersArray.Where(num => Convert.ToInt16(num) < 0);
                    Console.Write("Negative numbers(" + string.Join(",", negativeNumbers) + ") not allowed");
                    Console.Read();
                }
                else
                {
                    for (int counter = 0; counter < numbersArray.Count(); counter++)
                    {
                        //Task 7 Check above 1000 and ignore that number in calculation
                        int num = Convert.ToInt16(numbersArray[counter]);
                        sum += num<=1000?num:0;
                    }

                    Console.Write("Sum of the numbers is :" + sum);
                    Console.Read();
                }
            }
        }

    }
}
