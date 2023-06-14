/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.*/


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


