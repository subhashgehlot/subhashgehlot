using System;
using System.Linq;

namespace subhashgehlot
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creates a new instance so that static method can access non static members or methods in the main
            //To call the method here without creating the object you will have to declare the methods as static
            Program prog = new Program();

            if (args.Length > 1)
            {
                if (args[1].Contains("\\\\"))
                {
                    string[] numbersArray = args[1].Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] delimeter = new string[] { numbersArray[0] };//Stores the splitting delimeter entered by the user
                    string data = numbersArray[1];//Stores the data
                    prog.Calculate(data, delimeter, args[0]);

                }
                else
                {
                    string[] delimeter = new string[] { ",", "\\n" };//Stores the splitting delimeter entered by the user
                    prog.Calculate(args[1], delimeter, args[0]);
                }
            }
            else
            {
                Console.Write("0");
                Console.Read();
            }

        }

        public void Calculate(string numbers, string[] splitter,string type)
        {
            
            int result; // Keeps the result of the calculations
            if (numbers != null && splitter!=null && type!=null)
            {
                string[] numbersArray = numbers.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

                //Gets in the "if" clause if any of the number is negative in the list
                if (checkNegative(numbers))
                {
                    var negativeNumbers = numbersArray.Where(num => Convert.ToInt16(num) < 0);
                    Console.Write("Negative numbers(" + string.Join(",", negativeNumbers) + ") not allowed");
                    Console.Read();
                }
                //Goes through this clause if no negative number is present
                else
                {
                    //Switch is used to go to the appropriate operation specified
                    switch (type.ToLower())
                    {
                        //This case will be selected for multiplication operation
                        case "multiply":
                            result = 1;
                            for (int counter = 0; counter < numbersArray.Count(); counter++)
                            {
                                int num = Convert.ToInt16(numbersArray[counter]);
                                result *= num <= 1000 ? num : 1;
                            }
                            Console.Write(result);
                            Console.Read();
                            break;

                        //This case will be selected for addition operation
                        case "add": case"sum":
                            result = 0;
                            for (int counter = 0; counter < numbersArray.Count(); counter++)
                            {
                                int num = Convert.ToInt16(numbersArray[counter]);
                                result += num <= 1000 ? num : 0;
                            }
                            Console.Write(result);
                            Console.Read();
                            break;
                    }
                }
            }
        }
        
        //checks whether the data provided contains any negative values
        bool checkNegative(string data)
        {
            if (data.Contains('-'))
                return true;
            else
                return false;
        }
        
    }
}
