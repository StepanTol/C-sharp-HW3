//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine()!);
if (a>9999 & a<100000)
{
    if (a/10000 == a%10)
    {
        if ((a/1000)%10 == (a%100/10))
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число!!!");
}