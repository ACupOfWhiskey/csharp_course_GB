// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int x1 = ReadInt("First point X coordinate: ");
int y1 = ReadInt("First point Y coordinate: ");
int z1 = ReadInt("First point Z coordinate: ");
int x2 = ReadInt("Second point X coordinate: ");
int y2 = ReadInt("Second point Y coordinate: ");
int z2 = ReadInt("Second point Z coordinate: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Cut length = {length}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}