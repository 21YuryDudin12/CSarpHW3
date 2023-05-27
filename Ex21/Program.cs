//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату х первой точки");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
double z2 = double.Parse(Console.ReadLine());
void CheckDotsDistance (double kx1, double ky1, double kz1, double kx2, double ky2, double kz2)
{
    double ftionx = kx2 - kx1;
    double ftiony = ky2 - ky1;
    double ftionz = kz2 - kz1;
    double ftionrez = (ftionx * ftionx) + (ftiony * ftiony) + (ftionz * ftionz);
    double distance = Math.Sqrt(ftionrez);
    Console.WriteLine(Math.Round(distance, 2));
}
CheckDotsDistance(x1, y1, z1, x2, y2, z2 );