using System;

namespace interface_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Calculator\n");

            Calculator ModernCalculator = new Calculator();

            IBasic NormalCalculator = new Calculator();

            Console.WriteLine(" Calculator Types\n\n1.Normal Calculator\n2.Scientific Calculator");
            Console.WriteLine("\nSelect your Calculator Type ? ");
            int CalculatorType = int.Parse(Console.ReadLine());
            switch (CalculatorType)
            {
                case 2:

                    ModernCalculator.TakeUserInput();

                    Console.WriteLine($"1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
                    Console.WriteLine($"5.Matrix Operation\n6.Log Operations\n7.Exponential");
                    Console.WriteLine("\nEnter your choice");
                    int FirstChoice = int.Parse(Console.ReadLine());

                    switch (FirstChoice)
                    {
                        case 1:
                            ModernCalculator.Addition();
                            break;
                        case 2:
                            ModernCalculator.Substraction();
                            break;
                        case 3:
                            ModernCalculator.Multiplication();
                            break;
                        case 4:
                            ModernCalculator.Division();
                            break;
                        case 5:
                            ModernCalculator.MatrixOperation();
                            break;
                        case 6:
                            ModernCalculator.LogOperations();
                            break;
                        case 7:
                            ModernCalculator.Exponential();
                            break;
                        default:
                            Console.WriteLine("Enter a valid choice");
                            break;
                    }
                    break;
                case 1:

                    NormalCalculator.TakeUserInput();

                    Console.WriteLine($"1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n");
                    Console.WriteLine("\nEnter your choice");
                    int SecondChoice = int.Parse(Console.ReadLine());

                    switch (SecondChoice)
                    {
                        case 1:
                            NormalCalculator.Addition();
                            break;
                        case 2:
                            NormalCalculator.Substraction();
                            break;
                        case 3:
                            NormalCalculator.Multiplication();
                            break;
                        case 4:
                            NormalCalculator.Division();
                            break;
                        default:
                            Console.WriteLine("Enter a valid choice");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Enter a valid type");
                    break;
            }
        }
    }
}
