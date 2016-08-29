using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                    { prog.Sum(args[1]); }
                    else
                    {
                        Console.Write("Sum of the numbers is : 0");
                        Console.Read();
                    }
                    break;
                    
            }
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
        void Add(string numbers)
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

    }
}
