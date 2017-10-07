using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NumberGame
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            getRandomNumber();
            isNumberСoincidence = false;
            while (!isNumberСoincidence)
            {
                getUserAnswer();
                if (userAnswer == randomNumber) { isNumberСoincidence = true; Console.WriteLine("Верно"); }
                else
                {
                    if (userAnswer > randomNumber) { Console.WriteLine("Меньше" + "\r\n"); }
                    if (userAnswer < randomNumber) { Console.WriteLine("Больше" + "\r\n"); }
                }
            }
            printRandomNumber();
            Console.ReadKey();
        }
        public static int randomNumber;
        public static bool isNumberСoincidence;
        public static int userAnswer;
        public static void getRandomNumber()//генерирует случайное число
        {
            Random rand = new Random();
            randomNumber = rand.Next(0, 100);
        }
        public static void printRandomNumber()//выводит случайное число
        {
            Console.Write("Случайное число: " + randomNumber + "\r\n");
        }
        public static void getUserAnswer()
        {
            bool userAnswerInvalid = true;
            while (userAnswerInvalid == true)
            {
                try
                {
                   userAnswer = Convert.ToInt32(Console.ReadLine());
                    userAnswerInvalid = false;
                    if ((userAnswer > 100) || (userAnswer < 0)) { Console.Write("Число должно быть от 0 до 100" + "\r\n"); userAnswerInvalid = true; }
                }
                catch (FormatException)
                {
                    Console.Write("Неверный символ" + "\r\n"); userAnswerInvalid = true;
                }
            }

        }

    }
}
