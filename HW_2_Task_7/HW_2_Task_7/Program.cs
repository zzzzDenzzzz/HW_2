using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно
должно быть заменено на набор символов*. По итогам работы приложения необходимо показать статистику
действий.*/

namespace HW_2_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = 
                "To be, or not to be, that is the question,\n" +
                "Whether 'tis nobler in the mind to suffer\n" +
                "The slings and arrows of outrageous fortune,\n" +
                "Or to take arms against a sea of troubles,\n" +
                "And by opposing end them? To die: to sleep;\n" +
                "No more; and by a sleep to say we end\n" +
                "The heart-ache and the thousand natural shocks\n" +
                "That flesh is heir to, 'tis a consummation\n" +
                "Devoutly to be wish'd. To die, to sleep\n";

            string invalidWord = "die";

            Console.Write($"Текст:\n {text}");
            Console.WriteLine($"\nНедопустимое слово: {invalidWord}\n");

            string word = "";
            word = word.PadLeft(invalidWord.Length, '*');
            text = text.Replace(invalidWord, word);
            int countReplace = 0;
            foreach (var item in text)
            {
                if (item == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(item);
                    Console.ResetColor();
                    countReplace++;
                }
                else
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine($"\nСтатистика: замен слова {invalidWord} = {countReplace / invalidWord.Length}");
        }
    }
}
