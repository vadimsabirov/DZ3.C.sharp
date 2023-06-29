// Задача 1. Console.WriteLine("Введите число:");
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
int number = Convert.ToInt32(Console.ReadLine());

if (number % 100 == ((number /1000)+9))
{
 Console.WriteLine("{0} Палиндром" , number);
}
else 
{
 Console.WriteLine("{0} Не палиндром", number);
}
Console.ReadLine();
*/
// Задача 2. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A(3,6,8);B(2,1,-7),-> 15.84
// A(7,-5,0);B(1,-1,9),-> 11.53
/*
double LonglineAB (int xA, int xB, int yA, int yB, int zA, int zB)
{
        double longLine = Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA) + (zB-zA)*(zB-zA));
        longLine = Math.Round(longLine, 2);
        return longLine; 
}

Console.WriteLine("Input X coord of A: "); // Write команда цифры в строчку// Writeline - в столбик
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coord of A: "); // Write команда цифры в строчку// Writeline - в столбик
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coord of A: "); // Write команда цифры в строчку// Writeline - в столбик
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X coord of B: "); // Write команда цифры в строчку// Writeline - в столбик
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coord of B: "); // Write команда цифры в строчку// Writeline - в столбик
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coord of B: "); // Write команда цифры в строчку// Writeline - в столбик
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LonglineAB(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distance between A({xCoordA},{yCoordA},{zCoordA}) and B({xCoordB},{yCoordB},{zCoordB} ) is {dist:f3}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.
/*
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов:\n");
for (int i=1;i<=n;i++)
{
int k = i*i*i;
Console.Write($"{k}, ");
}
*/