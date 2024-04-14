// Напишите программу, которая будет 
// принимать на вход число и возвращать 
// сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9


// Console.WriteLine("Введите натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int number) // 123 12 1 0
{
	if(number == 0) return 0; // пропускается 
	return number % 10 + SumDigits(number / 10); // 123 12 1 0
    // 1%10 + 12%10 + 123%10 + 0 = 6
}

Console.WriteLine(SumDigits(123)); // 6



// void PrintNaturalNumbers(int num)
// {
//     if ( num == 0) return;
//     // Console.Write($"{num} ");  //Выводит 5 4 3 2 1
//     PrintNaturalNumbers(num - 1);
//     Console.Write($"{num} ");     //Выводит 1 2 3 4 5
// }

// PrintNaturalNumbers(number);