/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Console.Clear();

// Random rnd = new Random();
// int x1 = rnd.Next(1, 11);
// int y1 = rnd.Next(1, 11);
// int z1 = rnd.Next(1, 11);
// int x2 = rnd.Next(1, 11);
// int y2 = rnd.Next(1, 11);
// int z2 = rnd.Next(1, 11);

// Console.WriteLine($"x1={x1},y1={y1},z1={z2} x2={x2},y2={y2},z2={z2}");

// double result = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2));

// Console.WriteLine(result);

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
double getDistanseFromCoordinate(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return result;
}
int x1 = getUserValue("Введите x1");
int y1 = getUserValue("Введите y1");
int z1 = getUserValue("Введите z1");
int x2 = getUserValue("Введите x2");
int y2 = getUserValue("Введите y2");
int z2 = getUserValue("Введите z2");

double distanse = getDistanseFromCoordinate(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками = {distanse}");