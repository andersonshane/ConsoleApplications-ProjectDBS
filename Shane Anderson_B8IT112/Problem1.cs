using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int info;
            Console.WriteLine("People pay no tax if they earn up to £10,000.\nThey pay tax at the rate of 20% on the amount\nthey earn over £10,000 but up to £50,000.");
            Console.WriteLine("They pay tax at 40% on any money they earn over £50,000."); //Used '£' symbol as '€' does not display on the Console
            Console.WriteLine();
            Console.WriteLine("Press \"1\" to CONTINUE or Press \"0\" to QUIT");
            Console.WriteLine();
            info = Convert.ToInt32(Console.ReadLine());
            if (info == 1) //Description for the program
            {
                start:
                //Prompt the user for GrossPay
                Console.WriteLine("Please enter Gross Pay: ");
                decimal grossPay = decimal.Parse(Console.ReadLine());
                decimal taxRate = 0, tax = 0;
                decimal mNetPay = grossPay - tax;


                //taxRate Determination
                if (grossPay <= 10000)
                {
                    taxRate = 0;
                    tax = grossPay * taxRate;
                    mNetPay = 0;

                }
                else if (grossPay <= 50000)
                {
                    taxRate = 0.20M;
                    tax = (grossPay - 10000) * taxRate;
                    mNetPay = grossPay - tax;
                }
                else
                {
                    taxRate = 0.40M;
                    tax = (40000) * 0.20M + (grossPay - 50000) * taxRate;
                    mNetPay = grossPay - tax;

                }
                //Display user input on Console
                Console.WriteLine("The tax on £{0} is {1:C2} & The NetPay = " + mNetPay.ToString("C2"), grossPay, tax);
                Console.WriteLine();


                goto start; //Loops back to the begining of the program in order to test the different tax rates.
            }
        }
    }
}
