using System;
using System.Collections.Generic;
using System.Text;

namespace interface_calculator
{
    interface IBasic
    {
        void TakeUserInput();

        void Addition();

        void Substraction();

        void Multiplication();

        void Division();
    }

    interface IScientific
    {
        void MatrixOperation();

        void LogOperations();

        void Exponential();
    }

    class Calculator : IBasic, IScientific
    {

        public float FirstNumber;
        public float SecondNumber;

        public void TakeUserInput()
        {
            Console.WriteLine("Enter the First Number:");
            FirstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            SecondNumber = float.Parse(Console.ReadLine());
        }
        
        public void Addition()
        {
            Console.WriteLine($"The sum is {FirstNumber + SecondNumber}");
        }

        public void Division()
        {
            Console.WriteLine($"The Quotient is {FirstNumber / SecondNumber}");
        }

        public void Exponential()
        {
            Console.WriteLine("The Exponential Operation in Scientific is done");
        }

        public void LogOperations()
        {
            Console.WriteLine("The Log Operation in Scientific is done");
        }

        public void MatrixOperation()
        {
            Console.WriteLine("The Matrix Operation in Scientific is done");
        }

        public void Multiplication()
        {
            Console.WriteLine($"The Product is {FirstNumber * SecondNumber}");
        }

        public void Substraction()
        {
            Console.WriteLine($"The Difference is {FirstNumber - SecondNumber}");
        }
    }
}
