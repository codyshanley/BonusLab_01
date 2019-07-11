using System;

namespace BonusLab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isUsing = false;
            do
            {
                Console.WriteLine("Welcome to the Letter Grade Converter!");
                Console.Write("Enter a numberical grade: ");
                int numGrade = int.Parse(Console.ReadLine());

                char grade = ' ';

                if (numGrade < 60)
                {
                    grade = 'F';
                }
                else if (numGrade < 67)
                {
                    grade = 'D';
                }
                else if (numGrade < 80)
                {
                    grade = 'C';
                }
                else if (numGrade < 88)
                {
                    grade = 'B';
                }
                else if (numGrade <= 100)
                {
                    grade = 'A';
                }

                Console.WriteLine("Letter grade: " + grade);

                Console.Write("Continue? (y/n)");
                string strContinue = Console.ReadLine();

                if (strContinue == "y")
                {
                    isUsing = true;
                }
                else
                {
                    isUsing = false;
                }

            } while (isUsing == true);

        }
    }
}
