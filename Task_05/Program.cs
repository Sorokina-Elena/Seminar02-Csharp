/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

bool IsSquareNumber(int num1, int num2)
{
    int degree = 2;
    if(Math.Pow(num1, degree) == num2 || Math.Pow(num2, degree) == num1) return true; return false;
}
Console.WriteLine("Введите 1-е число");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int Num2 = Convert.ToInt32(Console.ReadLine());
bool result = IsSquareNumber(Num1, Num2);
Console.WriteLine(result);