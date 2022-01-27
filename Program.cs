using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take the Maths Quiz Below!");

            //creating my answers to verify later

            const int addition = 20;
            const int subtraction = 10;
            const int multiplication = 20;
            const int division = 10;
            const int secondAddition = 100;

            // setting my correct and wrong count


            int correctAnswers = 0;
            int wrongAnswers = 0;


            //asking user questions and answers

            Console.Write("10+10=: ");
            int firstQuestion = Convert.ToInt32(Console.ReadLine());

            if (firstQuestion == addition)
            {
                correctAnswers = correctAnswers + 1;
                Console.WriteLine("Correct answer!");
            }

            else
            {
                wrongAnswers = wrongAnswers + 1;
                Console.WriteLine("Wrong answer!");
            }

            //second question and counting right and wrong answers

            Console.Write("20-10=: ");
            int secondQuestion = Convert.ToInt32(Console.ReadLine());

            if (secondQuestion == subtraction)
            {
                correctAnswers = correctAnswers + 1;
                Console.WriteLine("Correct answer!");
            }

            else
            {
                wrongAnswers = wrongAnswers + 1;
                Console.WriteLine("Wrong answer!");
            }


            //third question and counting right and wrong answers

            Console.Write("2 x 10=: ");
            int thirdQuestion = Convert.ToInt32(Console.ReadLine());

            if (thirdQuestion == multiplication)
            {
                correctAnswers = correctAnswers + 1;
                Console.WriteLine("Correct answer!");
            }

            else
            {
                wrongAnswers = wrongAnswers + 1;
                Console.WriteLine("Wrong answer!");
            }


            //fourth question and counting right and wrong answers

            Console.Write("20-10=: ");
            int fourthQuestion = Convert.ToInt32(Console.ReadLine());

            if (fourthQuestion == division)
            {
                correctAnswers = correctAnswers + 1;
                Console.WriteLine("Correct answer!");
            }

            else
            {
                wrongAnswers = wrongAnswers + 1;
                Console.WriteLine("Wrong answer!");
            }

            //fifth question and counting right and wrong answers

            Console.Write("50+50=: ");
            int fifthQuestion = Convert.ToInt32(Console.ReadLine());

            if (fifthQuestion == secondAddition)
            {
                correctAnswers = correctAnswers + 1;
                Console.WriteLine("Correct answer!");
            }

            else
            {
                wrongAnswers = wrongAnswers + 1;
                Console.WriteLine("Wrong answer!");
            }


            Console.WriteLine($"Your Total Correct Answers= {correctAnswers}");
            Console.WriteLine($"Your Total Wrong Answers= {wrongAnswers}");

            Console.ReadKey();






        }
    }
}
