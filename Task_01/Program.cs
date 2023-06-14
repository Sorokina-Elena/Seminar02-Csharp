/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8
*/

int number = new Random().Next(10,100);

int firstNum = number/10;
int secondNum = number%10;

int max = firstNum;

if(secondNum > firstNum) max = secondNum;

Console.WriteLine($"Our number is => {number}");

Console.WriteLine($"Bigger number is {max}");


