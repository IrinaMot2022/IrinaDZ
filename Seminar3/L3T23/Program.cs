// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Число: ");
// int v_int = Convert.ToInt32(Console.ReadLine());
// for (int v_i = 1; v_i <= v_int; v_i++)
// {
//     Console.Write($"{Math.Pow(v_i,3)}");
//     if(v_i<v_int) Console.Write(", ");
// }

Console.Write("Число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица чисел в кубе до " +a +",  " );
for (int i = 1; i <= a; i++)
{
    Console.WriteLine($"{i} в кубе= {Math.Pow(i,3)}");
    
}