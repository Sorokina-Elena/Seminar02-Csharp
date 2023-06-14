/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
int Decrease(int Number)
{
    Console.WriteLine(Number + "=> ");

    int firstNum = Number/100;
    int secondNum = Number%10;
    int thirdNum = firstNum*10 + secondNum;
    return(thirdNum);
}
int NumberRand = new Random().Next(100,1000);
int result = Decrease(NumberRand);
Console.WriteLine(result);

