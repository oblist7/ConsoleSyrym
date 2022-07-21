/*
 * Task 2
 * 
 * string[] values = { "12.3", "45", "ABC", "11", "DEF" };
 * 
 * Правило 1. Если значение является буквенно-цифровым, выполните его объединение, чтобы сформировать сообщение.
 * Правило 2. Если значение является числовым, прибавьте его, чтобы получить сумму.
 * Правило 3. Результат должен быть следующим:
 *   Message: ABCDEF
 *   Total: 68.3
 *   
 */

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");