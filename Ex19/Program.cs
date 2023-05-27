//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите 5-ти значное число, программа проверит, является ли оно палиндромом");
void CheckPalindrom(int digit)
{
    int First2 = digit % 100;
    int Sec2 = digit / 1000;
    Sec2 = ((Sec2 % 10)*10) + (Sec2 / 10);
    if (First2 == Sec2)
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}
int Num = int.Parse(Console.ReadLine());
if (Num < 1000 || Num > 99999)
{
    Console.WriteLine("Это не пятизначное число");
}
else
{
    CheckPalindrom(Num);
}
