using System;



namespace GPA_App

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                 WELCOME TO MY GPA CALCULATOR APP");
            Console.WriteLine("How many courses are you offering?");
        
            int noOfCourses = int.Parse(Console.ReadLine());
            string[] courses = new string[noOfCourses];
            Console.WriteLine("Enter the courses");
            int counter = 0;
            while (counter < noOfCourses)
            {
                courses[counter] = Console.ReadLine();
                counter++;
            }
            int[] creditLoads = new int[noOfCourses];

            Console.WriteLine("Please enter their respective credit loads");
            counter = 0;

            while (counter < noOfCourses)
            {
                creditLoads[counter] = int.Parse(Console.ReadLine());
                counter++;
            }

            Console.WriteLine("please enter their respective grades");
            string grade = "";

            int gradeFactor = 0;
            
                              
            
            int[] gradeFactors = new int[noOfCourses];
            counter = 0;
            while (counter < noOfCourses)

            {
                grade = Console.ReadLine();
                switch (grade)
                {
                    case "A":
                        gradeFactor = 5;
                        break;
                    case "B":
                        gradeFactor = 4;
                        break;
                    case "C":
                        gradeFactor = 3;
                        break;
                    case "D":
                        gradeFactor = 2;
                        break;
                    case "F":
                        gradeFactor = 0;
                        break;
                    default:
                        Console.WriteLine("please enter a valid grade");
                        break;
                }

                
                gradeFactors[counter] = gradeFactor;
                counter++;
            }

            double sumOfCreditLoads = 0;

            counter = 0;

            while (counter < noOfCourses)

            {
                sumOfCreditLoads = sumOfCreditLoads + creditLoads[counter];
                counter++;
            }

            double gp_Product = 0;

            counter = 0;

            while (counter < noOfCourses)
            {
                gp_Product = gp_Product + (creditLoads[counter] * gradeFactors[counter]);
                counter++;
            }
            double gpa = gp_Product / sumOfCreditLoads;

            Console.WriteLine("your gpa is " + gpa + "!!!!!!");

            Console.ReadKey();




        }

    }

}
