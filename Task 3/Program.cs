﻿/*
 * Task 3.1) Изменению порядка букв в слове
 * 
 * Pangram: 
 *          The quick brown fox jumps over the lazy dog
 *          
 * Result: 
 *          ehT kciuq nworb xof spmuj revo eht yzal god
 * 
*/

string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);