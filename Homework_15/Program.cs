/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

int N = 7;
switch(N)
{
    case "1":  printf("не является выходным")
    break;
    case "2":  printf("I am One\n");

    case "3": Console.WriteLine("не является выходным");
    case "4": Console.WriteLine("не является выходным");
    case "5": Console.WriteLine("не является выходным");
    case "6": Console.WriteLine("является выходным");
    case "7": Console.WriteLine("является выходным");
    break;
}
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(switch(Num));*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
DayOfWeek(number);



int DayOfWeek(int Number)
{
  switch (number) 
{
    case 1: Console.WriteLine("Не выходной - пн");
         break;
    case 2: Console.WriteLine("Не выходной - вт");
         break;
    case 3: Console.WriteLine("Не выходной - ср");
         break;
    case 4: Console.WriteLine("Не выходной - чт");
         break;
    case 5: Console.WriteLine("Не выходной - пт");
         break;
    case 6: Console.WriteLine("Выходной - сб");
         break;
    case 7: Console.WriteLine("Выходной - вс");
         break;
    default: Console.WriteLine("Введите число от 1 до 7");
        break;
}  
return(number);
}


