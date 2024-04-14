// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());


void PrintNaturalNumbers(int num1, int num2)
{
    if (num1 < num2) // Условие для проверки с какого числа начать отчет, от малого или большего
    {
        if (num1 == num2) // Условие остановки рекурсии
        {
            Console.Write($"{num2} "); // Для того чтобы вызвать первую цифру
            return;
        }
        // Console.Write($"{num} ");  //Выводит 5 4 3 2 1
        PrintNaturalNumbers( num1, num2 - 1);
        Console.Write($"{num2} ");     //Выводит 1 2 3 4 5
    }
    else
    {
        if (num2 == num1) // Условие остановки рекурсии
        {
            Console.Write($"{num2} "); // Для того чтобы вызвать первую цифру
            return;
        }
        Console.Write($"{num1} ");  //Выводит 5 4 3 2 1
        PrintNaturalNumbers(num1 - 1, num2);
        // Console.Write($"{num1} ");     //Выводит 1 2 3 4 5
    }
}

PrintNaturalNumbers(numberM, numberN);