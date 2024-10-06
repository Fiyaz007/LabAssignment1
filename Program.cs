using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignments1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------
            //1
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            Console.ReadLine();*/

            //------------------------------------
            //2
            /*Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            string a = Console.ReadLine();
            Console.WriteLine("Your favourite color: ");
            string clr = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! You are {a} years old and your favourite color is {clr}");
            Console.ReadLine();*/

            //------------------------------------
            //3
            //Console.WriteLine("Enter two numbers a and b: ");
            //double a = Convert.ToInt32(Console.ReadLine());
            //double b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Sum is {a + b}");
            //Console.WriteLine($"Difference is {a - b}");
            //Console.WriteLine($"Product is {a * b}");
            //if (b == 0)
            //    Console.WriteLine("Warning! division by zero is not possible");
            //else
            //    Console.WriteLine($"Quotient is {a / b}");
            //Console.ReadLine();

            //------------------------------------
            //4
            //Console.WriteLine("Input a temperature in celcius: ");
            //double c = Convert.ToInt32(Console.ReadLine());
            ////Coverting into Farenheit
            //double f = (c * (9.0 / 5.0)) + 32.0;
            //Console.WriteLine($"The temperature in Farenheit is: {f}");
            //Console.ReadLine();

            //------------------------------------
            //5
            //Console.WriteLine("Enter the Principal Amount:");
            //int P = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Interest Rate:");
            //int R = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Time Period:");
            //int T = Convert.ToInt32(Console.ReadLine());
            ////Calculating Simple Interest
            //Console.WriteLine($"Simple Interest is : {(P * R * T) / 100.0}");
            //Console.ReadLine();

            //------------------------------------
            //6
            //const double PI = 3.14159;
            //Console.WriteLine("Enter the radius: ");
            //double r = Convert.ToDouble(Console.ReadLine());
            ////Calculating and Printing area of Circle
            //Console.WriteLine($"The area of Circle is: {PI * r * r}");
            //Console.ReadLine();

            //------------------------------------
            //7
            //Console.WriteLine("Enter the time in seconds: ");
            //int s = Convert.ToInt32(Console.ReadLine());
            ////Calculating hour
            //int hr = s / 3600;
            //s = s % 3600;
            ////Calculating minutes
            //int min = s / 60;
            //s = s % 60;
            ////Calculating seconds
            //int sec = s % 60;
            //Console.WriteLine($"The time is {hr}hr {min}min {sec}sec");
            //Console.ReadLine();

            //------------------------------------
            //8
            //Console.WriteLine("Enter the String: ");
            //string s = Console.ReadLine();
            //string st = s.Replace(" ", "");
            //int l = st.Length;
            //Console.WriteLine($"The no of characters in String: {l}");
            //Console.ReadLine();

            //------------------------------------
            //9
            //Console.WriteLine("Weight (in kg): ");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Height (in m): ");
            //double height = Convert.ToDouble(Console.ReadLine());
            ////Calculating BMI
            //double BMI = weight / (height * height);
            //Console.WriteLine($"The BMI : {BMI}");
            //Console.ReadLine();

            //------------------------------------
            //10
            //int a = 7;
            //float b = 84.7f;
            //double c = 7.34;
            //char s = 'F';
            //string name = "Fiyaz";
            //bool value = true;
            //Console.WriteLine($"{a} (integer)");
            //Console.WriteLine($"{b} (float)");
            //Console.WriteLine($"{c} (double)");
            //Console.WriteLine($"{s} (char)");
            //Console.WriteLine($"{name} (string)");
            //Console.WriteLine($"{value} (boolean)");
            //Console.ReadLine();

            //------------------------------------
            //11
            //const double PI = 3.14159;
            //Console.WriteLine("Enter the radius of a circle: ");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the lenght and breadth of a rectangle: ");
            //int lenght = Convert.ToInt32(Console.ReadLine());
            //int breadth = Convert.ToInt32(Console.ReadLine());
            ////Calculating and Printing area of Circle
            //Console.WriteLine($"The area of Circle is: {PI * radius * radius}");
            ////Calculating and Printing area of Rectangle
            //Console.WriteLine($"The area of Rectangle is: {lenght * breadth}");
            //Console.ReadLine();

            //------------------------------------
            //12
            //const double PI = 3.14159;
            //const int DAYS_IN_WEEK = 7;
            //Console.WriteLine("Enter the radius of a circle: ");
            //double radius = Convert.ToDouble(Console.ReadLine());
            ////Calculating Circumference of a circle
            //Console.WriteLine($"The Circumference of the Circle is: {2 * PI * radius} and the no of days in a week is: {DAYS_IN_WEEK}");
            //Console.ReadLine();

            //------------------------------------
            //13
            //const double INCH = 2.54;   //1 inch = 2.54 cm
            //Console.WriteLine("Enter the lenght and width of a rectangle in inches: ");
            //double lenght = Convert.ToDouble(Console.ReadLine());
            //double width = Convert.ToDouble(Console.ReadLine());
            ////Calculating and Printing area of Rectangle in square inches
            //Console.WriteLine($"The area of Rectangle (square inches) is: {lenght * width}");
            ////Calculating and Printing area of Rectangle in square centimeters
            //Console.WriteLine($"The area of Rectangle (square centimeters) is: {(lenght * INCH) * (width * INCH)}");
            //Console.ReadLine();

            //------------------------------------
            //14
            //Program to Read and Display details of an Employee 
            //Console.WriteLine("Enter the Employee name: ");
            //string employName = Console.ReadLine();
            //Console.WriteLine("Enter the Age: ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Monthly Salary: ");
            //int monthlySalary = int.Parse(Console.ReadLine());
            ////Displaying Employee Details
            //Console.WriteLine("Employee Details:");
            //Console.WriteLine($"Name : {employName}");
            //Console.WriteLine($"Age : {Age}");
            //Console.WriteLine($"Monthy Salary : {monthlySalary}");
            //Console.ReadLine();

            //------------------------------------
            //15
            //int firstNumber = 5;
            //int secondNumber = 3;
            ////Calculating Sum
            //int Sum = firstNumber + secondNumber;
            //Console.WriteLine($"The sum of the two numbers is {Sum}");
            //Console.ReadLine();

            //------------------------------------
            //16
            ////Program to show use of assignment operator
            //int a = 7;
            //int b = 0;
            //b = a;
            //Console.WriteLine($"A: {a} and B: {b}");
            //Console.ReadLine();

            //------------------------------------
            //17
            //Console.WriteLine("Enter the base value: ");
            //double baseValue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the exponential value: ");
            //double exponentValue = Convert.ToInt32(Console.ReadLine());
            ////Calculating power of the number
            //double answer = Math.Pow(baseValue, exponentValue);
            //Console.WriteLine($"The answer is {answer}");
            //Console.ReadLine();

            //------------------------------------
            //18
            //Console.WriteLine("Enter the age of the person: ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Nationality: ");
            //string Citizenship = Console.ReadLine();
            //if (Age >= 18 && Citizenship.ToLower() == "indian")
            //    Console.WriteLine("The person is Eligible for voting");
            //else
            //    Console.WriteLine("The person is not Eligible for voting");
            //Console.ReadLine();

            //------------------------------------
            //19
            //Console.WriteLine("Enter the Age of the person: ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Income of the person: ");
            //int Income = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the outstanding Loan Status(Yes/No) of the person: ");
            //string loanStatus = Console.ReadLine();
            //if (Age >= 21 && Income >= 30000 && loanStatus.ToLower() == "no")
            //    Console.WriteLine("The person is Eligible for Loan");
            //else
            //    Console.WriteLine("The person is not Eligible for Loan");
            //Console.ReadLine();

            //------------------------------------
            //20
            //Console.WriteLine("Enter the Age of the person: ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Work Experience of the person: ");
            //int workExperience = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Whether the person have college degree (Yes/No): ");
            //string degreeStatus = Console.ReadLine();
            //if (Age >= 18 && Age <= 35 && workExperience >= 2 && (degreeStatus.ToLower() == "yes" || workExperience >= 5))
            //    Console.WriteLine("The person is Eligible for the Job");
            //else
            //    Console.WriteLine("The person is not Eligible for the Job");
            //Console.ReadLine();

            //------------------------------------
            //21
        }
    }
}
