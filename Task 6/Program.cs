/*
 * Task 6) FizzBuzz:
 * 
 * Необходимо вывести значения от 1 до 100, по одному в каждой строке.
 *  Если текущее значение делится на 3, рядом с числом выводится слово Fizz.
 *  Если текущее значение делится на 5, рядом с числом выводится слово Buzz.
 *  Если текущее значение делится как на 3, так и на 5, рядом с числом выводится слово FizzBuzz.
 *  
 */


for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine(i + " - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine(i + " - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine(i + " - Buzz");
    else
        Console.WriteLine(i);
}