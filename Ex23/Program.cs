//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N, программа укажет все кубы от 0 до N");
int n = int.Parse(Console.ReadLine());

void FindQubeDigit (int nf)
{
int i = 0;
for (i=0; i < (nf + 1); i++)
{
    int f = i;
    f = f*f*f;
    if (f == 0)
    {
        
    }
    else
    {
         Console.WriteLine(f);
    }
}
}
FindQubeDigit(n);