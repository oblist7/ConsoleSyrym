/*
 * Task 3.2)
 * 
 * Выведете каждый идентификатор заказа, который начинается с буквы "B"
 * 
 * orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
 * 
 * Result: 
 *      B123
 *      B177
 *      B179
 */
using System;

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');

foreach (var item in items)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}