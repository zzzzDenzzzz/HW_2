using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Пользователь с клавиатуры вводит некоторый текст. Приложение должно изменять регистр первой буквы
каждого предложения на букву в верхнем регистре.*/

namespace HW_2_Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст.");
            string text = Console.ReadLine();
            text = text.TrimStart(' ');
            text =" " + text.First().ToString().ToUpper() + text.Substring(1);
            var s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                {
                    if (s[i + 1] == ' ')
                    {
                        s[i + 2] = char.ToUpper(s[i + 2]);
                    }
                    else
                    {
                        s[i + 1] = char.ToUpper(s[i + 1]);
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
