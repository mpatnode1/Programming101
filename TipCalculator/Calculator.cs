using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml;
using static System.Console;

namespace TipCalculatorProgram
{
    class Calculator
    {
        string ProgramTitle = "Tip Calculator";

        public Calculator(string title)
        {
            ProgramTitle = title;
        }

        public void Start()
        {
            Console.WriteLine($"Your tip is ${CalculateTip(GetTotal(), GetTip()):F2}");
        }

        public double GetTotal()
        {
            Console.WriteLine("What was your total?");

            while (true)
            {
                string BillInput = Console.ReadLine();
                try
                {
                    return double.Parse(BillInput);
                }
                catch
                {
                    Console.WriteLine("Please enter a number value.");
                    continue;
                }

            }
        }
        public double GetTip()
        {

            Console.WriteLine("How much would you like to tip?");
            Console.WriteLine("Type in the number. Example: 20");
            while (true)
            {
                string TipInput = Console.ReadLine();
                try
                {
                    // you could just parse this as a double to start with, but this was to demonstrate casting
                    return (double)int.Parse(TipInput) / 100;
                
                }
                catch
                {
                    Console.WriteLine("Please enter a number value.");
                    continue;
                }

            }

        }

        public double CalculateTip(double TipAmount, double BillAmount)
        {
            return BillAmount * TipAmount;
        }


    }
}