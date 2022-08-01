﻿/*
 * New C# 9
 * 
 * 1) Операторы верхнего уровня (без метода Main и класса)
 * 
 * 2) Средства доступа только для инициализации (init)
 *      class Foo { public int ID { get; init; } }
 *      
 * 3) Записи (with)
 *      Point pi = new Point (2, 3);
 *      Point p2 = pi with { Y = 4 };
 *      
 * 4) Улучшения в сопоставлении с образцом
 *      Реляционный шаблон
 *      комбинаторов шаблонов (or >= 'A' and <= 'Z')
 *      шаблоном типа (not string)
 *      
 * 5) Выражения new целевого типа
 *      удобно, когда объявление и инициализация переменной находятся в разных частях кода
 *      
 * 6) Улучшения в возможностях взаимодействия
 *      -указатели на функции
 *      nint (System.IntPtr), unint (System.UIntPtr)
 * ..)
 *    Ковариантные возвращаемые типы
 *    применять атрибуты к локальным функциям
 *    Статические лямбда-выражения
 *    заставлять любой тип работать с оператором foreach (GetEnumerator)
 *    определять метод инициализатора модуля Modulelnitializer к void
 *    использовать _ в качестве аргумента лямбда-выражения
 */

//4 Реляционный шаблон
string GetWeightCategory(decimal bmi) => bmi switch
{
    < 18.5m => "underweight",
    < 25m => "normal",
    < 30m => "overweight",
    _ => "obese"
};

Console.WriteLine(GetWeightCategory(24m));
