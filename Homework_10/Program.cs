/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int Decrease(int Number)
{
    int num1 = Number/100;
    int num2 = Number%10;
    int num3 = (Number - (num1*100+num2))/10;
    return(num3);
}
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Decrease(Num));
