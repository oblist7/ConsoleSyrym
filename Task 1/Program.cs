/*
 * Task 1) Изменение содержимого строк с помощью встроенных методов для строковых типов данных
 * 
 * Работать со строкой, содержащей фрагмент HTML-кода.
 * Вы извлечете данные из фрагмента HTML-кода,
 * замените часть его содержимого и удалите другие части его содержимого
 * 
 * <span>5000</span>
 * 
 */

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string spanTag = "<span>";

// Extract the quantity
int quantityStart = input.IndexOf(spanTag);
int quantityEnd = input.IndexOf("</span>");
quantityStart += spanTag.Length;
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);

// Set output to input, replacing the trademark symbol with the registered trademark symbol
output = input.Replace("&trade;", "&reg;");

// Remove the opening <div> tag
int divStart = input.IndexOf("<div");
int divEnd = input.IndexOf(">");
int divLength = divEnd - divStart;
divLength += 1;
output = output.Remove(divStart, divLength);

// Remove the closing <div> tag
int divCloseStart = output.IndexOf("</div");
int divCloseEnd = output.IndexOf(">", divCloseStart);
int divCloseLength = divCloseEnd - divCloseStart;
divCloseLength += 1;
output = output.Remove(divCloseStart, divCloseLength);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");