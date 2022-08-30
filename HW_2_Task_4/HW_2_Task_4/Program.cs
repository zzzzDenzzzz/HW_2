using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 4
Создайте приложение, которое производит операции над матрицами:
-Умножение матрицы на число;
-Сложение матриц;
-Произведение матриц.
*/

namespace HW_2_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitMenu = true;
            string menuItem = null;
            int size = 3;
            int[,] matrixA = new int[size, size];
            Random random = new Random();
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = random.Next(-3, 10);
                }
            }

            int[,] matrixB = new int[size, size];
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixB[i, j] = random.Next(-10, 3);
                }
            }
            do
            {
                Console.WriteLine("Выбирите пункт меню");
                Console.WriteLine("1. Умножение матрицы на число");
                Console.WriteLine("2. Сложение матриц");
                Console.WriteLine("3. Произведение матриц");
                Console.WriteLine("4. Выход");
                menuItem = Console.ReadLine();
                switch (menuItem)
                {
                    case "1":
                        Console.WriteLine("Исходная матрица:");
                        for (int i = 0; i < matrixA.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixA.GetLength(1); j++)
                            {
                                if (matrixA[i, j] >= 0)
                                {
                                    Console.Write($" {matrixA[i, j]} ");
                                }
                                else
                                {
                                    Console.Write($"{matrixA[i, j]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Введите число: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Результат:");
                        for (int i = 0; i < matrixA.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixA.GetLength(1); j++)
                            {
                                if (matrixA[i, j] * number >= 0)
                                {
                                    Console.Write($" {matrixA[i, j] * number} ");
                                }
                                else
                                {
                                    Console.Write($"{matrixA[i, j] * number} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Исходная матрица A:");
                        for (int i = 0; i < matrixA.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixA.GetLength(1); j++)
                            {
                                if (matrixA[i, j] >= 0)
                                {
                                    Console.Write($" {matrixA[i, j]} ");
                                }
                                else
                                {
                                    Console.Write($"{matrixA[i, j]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Исходная матрица B:");
                        for (int i = 0; i < matrixB.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixB.GetLength(1); j++)
                            {
                                if (matrixB[i, j] >= 0)
                                {
                                    Console.Write($" {matrixB[i, j]} ");
                                }
                                else
                                {
                                    Console.Write($"{matrixB[i, j]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Результат A + B =");
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                if (matrixA[i, j] + matrixB[i, j] >= 0)
                                {
                                    Console.Write($" {matrixA[i, j] + matrixB[i, j]} ");
                                }
                                else
                                {
                                    Console.Write($"{matrixA[i, j] + matrixB[i, j]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Исходная матрица A:");
                        for (int i = 0; i < matrixA.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixA.GetLength(1); j++)
                            {
                                if (matrixA[i, j] >= 0)
                                {
                                    Console.Write($" {matrixA[i, j]} ");
                                }
                                else
                                {
                                    Console.Write($"{matrixA[i, j]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Исходная матрица B:");
                        for (int i = 0; i < matrixB.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixB.GetLength(1); j++)
                            {
                                if (matrixB[i, j] >= 0)
                                {
                                    Console.Write($" {matrixB[i, j]} ");
                                }
                                else
                                {
                                    Console.Write($"{matrixB[i, j]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Результат A * B =");
                        int rows = matrixA.GetUpperBound(0) + 1;
                        int columns = matrixB.GetUpperBound(1) + 1;
                        int[,] matrixR = new int[rows, columns];

                        for (var i = 0; i < rows; i++)
                        {
                            for (var j = 0; j < columns; j++)
                            {
                                matrixR[i, j] = 0;

                                for (var k = 0; k < columns; k++)
                                {
                                    matrixR[i, j] += matrixA[i, k] * matrixB[k, j];
                                }
                            }
                        }
                        for (int i = 0; i < matrixR.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixR.GetLength(1); j++)
                            {
                                if (matrixR[i, j] >= 0)
                                {
                                    Console.Write($" {matrixR[i, j]} ");
                                }
                                else
                                {
                                    Console.Write($"{matrixR[i, j]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "4":
                        exitMenu = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
            } while (exitMenu);
        }
    }
}
