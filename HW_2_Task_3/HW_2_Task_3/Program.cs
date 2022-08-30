using System;

/*Задание 3
 * Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. */

namespace Module_2_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            char[] line = Console.ReadLine().ToCharArray();
            char c = '@';
            for (int i = 0; i < line.Length; i++)
            {
                line[i] += c;
            }
            Console.Write("Зашифрованная строка: ");
            Console.WriteLine(line);
            for (int i = 0; i < line.Length; i++)
            {
                line[i] -= c;
            }
            Console.Write("Расшифрованная строка: ");
            Console.WriteLine(line);
        }
    }
}