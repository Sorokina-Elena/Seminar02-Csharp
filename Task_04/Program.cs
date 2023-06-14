/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/

string Decrease(int Number)
{
    int num1 = 23;
    int num2 = 7;
    string answer = Number%num1==0 && Number%num2==0 ? "да" : "нет";
    return(answer);
}
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
string result = Decrease(Num);
Console.WriteLine(Decrease(Num));
