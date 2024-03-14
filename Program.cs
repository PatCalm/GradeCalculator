using System;

namespace Program
{
    class GradeCalculator
    {
        double avg;

        //function to enter and calculate the average grade
        double Calc ()
        {
            Console.Write("Enter grade for Math: ");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter grade for Physics: ");
            double physics = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter grade for Chemistry: ");
            double chem = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter grade for Computer Science: ");
            double compSci = Convert.ToDouble(Console.ReadLine());

            //formula to get the average grade
            avg = ((math + physics + chem + compSci)/4);
            Console.WriteLine();
            Console.WriteLine("Total average grade: " + avg);   //display the average grade
            Console.WriteLine();
            return avg;
        }

        //fuction to find out the average mark base on the total average
        void Marks()
        {
            try
            {
                GradeCalculator mark = new GradeCalculator(); //use to call the object calc

                double average = avg;
                int avgMark = 0;
                
                //conditional statement to determine the average mark based on average grade
                if (average >= 80)
                {
                    Console.Write("Grade A");
                    avgMark = 1;
                }
                else if (average >= 70 && average < 80)
                {
                    Console.Write("Grade B");
                    avgMark = 2;
                }
                else if (average >= 60 && average < 70)
                {
                    Console.Write("Grade C");
                    avgMark = 3;
                }
                else if (average >= 50 && average < 60)
                {
                    Console.Write("Grade D");
                    avgMark = 4;
                }
                else if (average < 50)
                {
                    Console.Write("Grade F");
                    avgMark = 5;
                }
                mark.switchstatement(avgMark); //calling the object switchstatement

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //function for the conditional statement switch to determine the average mark
        void switchstatement(int avgMark)
        {
            switch (avgMark)
            {
                case 1:
                    Console.WriteLine(" - 'Excellent! Your grade is A'");
                    break;
                case 2:
                    Console.WriteLine(" - 'Good! Your grade is B'");
                    break;
                case 3:
                    Console.WriteLine(" - 'Satisfactory. Your grade is C'");
                    break;
                case 4:
                    Console.WriteLine(" - 'Pass. Your grade is D'");
                    break;
                case 5:
                    Console.WriteLine(" - 'Fail. Your grade is F'");
                    break;
            }
        }
        static void Main(string[] args)
        {
            GradeCalculator gradeCalculator = new GradeCalculator(); 
            gradeCalculator.Calc();     //to call the object Calc
            gradeCalculator.Marks();       //to call the object Marks
            Console.WriteLine();
        }
    }
}