// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Число: ");
// int v_int = Convert.ToInt32(Console.ReadLine());
// if (v_int / 100 > 0)
// {
//     while(v_int/1000>0)
//     {
//         v_int = v_int/10;
//     }
//     Console.WriteLine(v_int % 10);
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }

Console.Write("Число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a / 100 > 0)
{
    while(a/1000>0)
   
    {
        a = a/10;
        Console.WriteLine("Это число меньше 1000="+(a));
    }
    Console.WriteLine(a % 10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}