using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input Type (+, -, *, /, %)");
            string inputType = Console.ReadLine();
            String[] inputValues = { "+", "-", "*", "/", "%" };
            if (inputType != inputValues[0])
            {
                if (inputType != inputValues[1])
                {
                    if (inputType != inputValues[2])
                    {
                        if (inputType != inputValues[3])
                        {
                            if (inputType != inputValues[4])
                            {
                                Console.WriteLine("Invalid Input");
                                Main();
                            }
                            else
                            {
                                Num1_Get(1, inputType);
                            }
                        }
                        else
                        {
                            Num1_Get(1, inputType);
                        }
                    }
                    else
                    {
                        Num1_Get(1, inputType);
                    }
                }
                else
                {
                    Num1_Get(0, inputType);
                }
            }
            else
            {
                Num1_Get(0, inputType);
            }
        }
        
        static void Num1_Get(double defaultValues, String inputType)
        {
            Console.WriteLine("            ");
            Console.WriteLine("Please input number 1:");
            String num1txt = Console.ReadLine();
            double num1 = 0;
            if (double.TryParse(num1txt, out num1))
            {
                num1 = Convert.ToDouble(num1txt);
                Console.WriteLine("            ");
                Console.WriteLine("Number 1 is " + num1);
                Num2_Get(defaultValues, num1, inputType);
            }
            else
            {
                Console.WriteLine("            ");
                Console.WriteLine("<Console> " + num1txt + " is not a number");
                Console.WriteLine("            ");
                Num1_Get(defaultValues, inputType);
            }
        }

        static void Num2_Get(double defaultValues, double num1 ,String inputType)
        {
            Console.WriteLine("            ");
            Console.WriteLine("Please input number 2:");
            String num2txt = Console.ReadLine();
            double num2 = 0;
            if (double.TryParse(num2txt, out num2))
            {
                num2 = Convert.ToDouble(num2txt);
                Console.WriteLine("            ");
                Console.WriteLine("Number 2 is " + num2);
                Num3_Get(defaultValues, num1, num2, inputType);
            }
            else
            {
                Console.WriteLine("            ");
                Console.WriteLine("<Console> " + num2txt + " is not a number");
                Console.WriteLine("            ");
                Num2_Get(defaultValues, num1, inputType);
            }
        }

        static void Num3_Get(double defaultValues, double num1, double num2, String inputType)
        {
            Console.WriteLine("            ");
            Console.WriteLine("Please input number 3 (Optional):");
            String num3txt = Console.ReadLine();
            double num3 = 0;
            if (double.TryParse(num3txt, out num3))
            {
                num3 = Convert.ToDouble(num3txt);
                Console.WriteLine("            ");
                Console.WriteLine("Number 3 is " + num3);
                Num4_Get(defaultValues, num1, num2, num3, inputType);
            }
            else if (num3txt.Length == 0)
            {
                num3 = defaultValues;
                Num4_Get(defaultValues, num1, num2, num3, inputType);
            }
            else
            {
                Console.WriteLine("            ");
                Console.WriteLine("<Console> " + num3txt + " is not a number");
                Console.WriteLine("            ");
                Num3_Get(defaultValues, num1, num2, inputType);
            }
        }

        static void Num4_Get(double defaultValues, double num1, double num2, double num3, String inputType)
        {
            Console.WriteLine("            ");
            Console.WriteLine("Please input number 4 (Optional):");
            String num4txt = Console.ReadLine();
            double num4 = 0;
            if (double.TryParse(num4txt, out num4))
            {
                num4 = Convert.ToDouble(num4txt);
                Console.WriteLine("            ");
                Console.WriteLine("Number 4 is " + num4);
                Num5_Get(defaultValues, num1, num2, num3, num4, inputType);
            }
            else if (num4txt.Length == 0)
            {
                num4 = defaultValues;
                Num5_Get(defaultValues, num1, num2, num3, num4, inputType);
            }
            else
            {
                Console.WriteLine("            ");
                Console.WriteLine("<Console> " + num4txt + " is not a number");
                Console.WriteLine("            ");
                Num5_Get(defaultValues, num1, num2, num3, num4, inputType);
            }
        }

        static void Num5_Get(double defaultValues, double num1, double num2, double num3, double num4, String inputType)
        {
            Console.WriteLine("            ");
            Console.WriteLine("Please input number 5 (Optional):");
            String num5txt = Console.ReadLine();
            double num5 = 0;
            if (double.TryParse(num5txt, out num5))
            {
                num5 = Convert.ToDouble(num5txt);
                Console.WriteLine("            ");
                Console.WriteLine("Number 5 is " + num5);
                Calculations(num1, num2, num3, num4, num5, inputType);
            }
            else if (num5txt.Length == 0)
            {
                num5 = defaultValues;
                Calculations(num1, num2, num3, num4, num5, inputType);
            }
            else
            {
                Console.WriteLine("            ");
                Console.WriteLine("<Console> " + num5txt + " is not a number");
                Console.WriteLine("            ");
                Num5_Get(defaultValues, num1, num2, num3, num4, inputType);
            }
        }
        static void Calculations(double Num1, double Num2, double Num3, double Num4, double Num5, String inputType)
        {
            String[] inputValues = { "+", "-", "*", "/", "%" };
            if (inputType != inputValues[0])
            {
                if (inputType != inputValues[1])
                {
                    if (inputType != inputValues[2])
                    {
                        if (inputType != inputValues[3])
                        {
                            if (inputType != inputValues[4])
                            {
                                Console.WriteLine("Calculator v1.0.0 was not able to compute.");
                            }
                            else
                            {
                                double result = Num1 % Num2 % Num3 % Num4 % Num5;
                                Console.WriteLine("The answer is " + result);
                                RunAgain();
                            }
                        }
                        else
                        {
                            double result = Num1 / Num2 / Num3 / Num4 / Num5;
                            Console.WriteLine("The answer is " + result);
                            RunAgain();
                        }
                    }
                    else
                    {
                        double result = Num1 * Num2 * Num3 * Num4 * Num5;
                        Console.WriteLine("The answer is " + result);
                        RunAgain();
                    }
                }
                else
                {
                    double result = Num1 - Num2 - Num3 - Num4 - Num5;
                    Console.WriteLine("The answer is " + result);
                    RunAgain();
                }
            }
            else
            {
                double result = Num1 + Num2 + Num3 + Num4 + Num5;
                Console.WriteLine("The answer is " + result);
                RunAgain();
            }
        }

        static void RunAgain()
        {
            Console.WriteLine("Run another calculation? Y/N");
            String RunAgain = Console.ReadLine();
            if (RunAgain == "N")
            {
                KillApp();
            }
            else if (RunAgain == "n")
            {
                KillApp();
            }
            else if (RunAgain == "Y")
            {
                Console.Clear();
                Main();
            }
            else if (RunAgain == "y")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Answer not recognized. Please respond with Y/N");
            }
        }

        static object KillApp()
        {
            Environment.Exit(1);
            return 1;
        }
    }
}