// Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

void Dist (int x, int x1, int y, int y1, int z, int z1){
    double d = Math.Sqrt(Math.Pow((x1 - x),2) + Math.Pow((y1 - y),2) + Math.Pow((z1 - z),2));
    Console.WriteLine($"Расстояние: {Math.Round(d,2)}");
}
Console.Write("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z ");
int z = Convert.ToInt32(Console.ReadLine());

Dist(x, x1, y, y1, z, z1);