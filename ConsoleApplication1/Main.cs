﻿/*
 * Немного пояснений:
 * Первым делом, я решил попробовать сразу писать то, что приходит в голову. Был виден возможный успех в написании рабочего кода,
 * но с множеством условных операторов и циклов, что не подходит под описание красивого кода, поэтому данный вариант я оставил.
 * Через какое-то время пришел к двум вариантам:
 *    1. Разбить входную строку на части(числа и операторы), положить их в два отдельных стека и реализовать их взаимодействие.
 *    2. Рассматривать входную строку пошагово, выискивая отрицательные и положительные числа, 
 *       операторы и рассчитывать все это в древовидном порядке. Как пример:
 *       
 *                   +
 *                  / \ 
 *       2+3*6  =  2   * 
 *                    / \   
 *                   3   6
 *                   
 *       Остановился на этом варианте.
 */


using System;

namespace Calculator
{
    using System;
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение");
            string _string = Console.ReadLine();

            Expression _expression = new Expression(_string);
            Console.WriteLine("Результат: "+_expression.Calculation().ToString());
            Console.ReadKey();
        }
    }
}
