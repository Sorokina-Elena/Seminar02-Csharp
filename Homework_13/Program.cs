/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
string? Number = Console.ReadLine();
int i = Convert.ToInt32(Number);
string? s = Number;

if (Number.Length < 3)
{
    Console.WriteLine("Третьего числа нет");
}
else 
{
     char c = s[2];
     Console.WriteLine(c);
}
  



