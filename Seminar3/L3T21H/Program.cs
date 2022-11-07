
// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координаты 2х точек в формате C1_1,C1_2..C1_N;C2_1,C2_2,C2_N: ");
string v_str = Console.ReadLine();
string[] v_str_arr = v_str.Split(";");
Console.WriteLine($"{v_str_arr.Length} points detected");
if (v_str_arr.Length != 2)
{
    Console.WriteLine("Wrong points number");
    Environment.Exit(-1);
}
string[] v_p1_str = v_str_arr[0].Split(",");
string[] v_p2_str = v_str_arr[1].Split(",");
if (v_p1_str.Length != v_p2_str.Length)
{
    Console.WriteLine($"Points dimensions must be equal (p1 - {v_p1_str.Length}D, p2 - {v_p2_str.Length}D)");
    Environment.Exit(-1);
}
double v_dist = 0;
for (int v_i = 0; v_i<v_p1_str.Length;v_i++)
{
    double v_c1 = Convert.ToDouble(v_p1_str[v_i].Trim());
    double v_c2 = Convert.ToDouble(v_p2_str[v_i].Trim());
    v_dist = v_dist + Math.Pow(v_c2 - v_c1, 2);
}
Console.WriteLine($"Dist = {Math.Sqrt(v_dist)}");
