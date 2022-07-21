/*
 * Task 7) Использовать либо оператор do-while, либо оператор while
 * 
 * Игровые правила
 *
 * Изначально герой и монстр имеют 10 очков здоровья.
 * При атаке наносится урон от 1 до 10.
 * Первым атакует герой.
 * На экран выводится урон, нанесенный монстру, и оставшееся количество его очков здоровья.
 * Если уровень здоровья монстра больше нуля, он может атаковать героя.
 * На экран выводится урон, нанесенный герою, и оставшееся количество его очков здоровья.
 * Последовательность атак продолжается до тех пор, пока уровень здоровья либо монстра, либо героя не станет меньше нуля или равен ему.
 * На экран выводится победитель.
 * 
 */

int hero = 10;
int monster = 10;

Random dice = new Random();

while (hero > 0 && monster > 0)
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
}

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");