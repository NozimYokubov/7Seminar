// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());


void PrintNaturalNumbers(int num)
{
    if ( num == 0) return;
    // Console.Write($"{num} ");  //Выводит 5 4 3 2 1
    PrintNaturalNumbers(num - 1);
    Console.Write($"{num} ");     //Выводит 1 2 3 4 5
}

PrintNaturalNumbers(number);