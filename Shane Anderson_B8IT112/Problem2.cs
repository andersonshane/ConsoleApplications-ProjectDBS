using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int info;
            Console.WriteLine("This program will accept a range of INTEGER values from you, e.g \"1 to 100\"");
            Console.WriteLine("and output\na) No of even numbers entered\nb) Sum of even numbers entered.\nc) Average of even numbers entered\n(Average must be a real number formatted to display 2 decimal places).\nd) Highest and lowest even numbers entered. \nThe prime number(s), even number(s) and odd number(s) in the range");
            Console.WriteLine();
            Console.WriteLine("Press \"1\" to CONTINUE or Press \"0\" to QUIT");
            Console.WriteLine();
            info = Convert.ToInt32(Console.ReadLine());
            if (info == 1) //Description for the program
            { //Declare variables
                int count;
                int max;
                int min;
                double sum;
                double avg;
                min = 101;
                max = 0;
                count = 0;
                sum = 0;

                do //"Do While" - Loop, reads user input in the range of 1 - 100
                {
                    int x;
                    Console.Write("Input next value (1-100): ");
                    // Reads text for user
                    string value = Console.ReadLine();
                    // Must convert to number if possible. 
                    // defaults to x=0 if conversion isn't valid
                    int.TryParse(value, out x);
                    // if out of range break out of loop
                    if (x < 1 || x > 100)
                    {
                        Console.WriteLine("Done entering values.");
                        break;

                    }

                    if (x % 2 == 0) //Adds values into data if it is even.
                    {
                        Console.WriteLine("value {0} accepted.", x);

                        count = count + 1; //count is incremented
                        if (count == 0)
                        {
                            avg = 0.0; //Default Average value
                            return;

                        }
                        sum = sum + x;//Entry is added to the sum

                        if (x > max)//Guaranteed to be greater on firstrun as max is set to 0 which is out range for the loop
                        {
                            max = x;
                        }
                        if (x < min)//Guaranteed to be greater on firstrun as max is set to 0 which is out range for the loop
                        {
                            min = x;
                        }
                    }


                } while (true); //loop runs while x is less than or equal to 100 and greater than or equal to 1


                //Diplays data on Console
                avg = Math.Round((double)sum / count);
                Console.WriteLine("number of evens: " + count);
                Console.WriteLine("sum of evens: " + sum);
                Console.WriteLine("average of evens= {0:F2} ", avg);
                Console.WriteLine("highest even: " + max);
                Console.WriteLine("lowest even: " + min);
                Console.WriteLine("Press anykey to quit");
                Console.ReadKey();
            }


        }
    }
}
