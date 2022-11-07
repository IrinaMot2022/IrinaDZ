
// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Через строку решать нельзя.14212 -> нет 12821 -> да 23432 -> да

// Console.Write("Число: ");
// int v_int = Convert.ToInt32(Console.ReadLine());
// int v_digits = (int)Math.Log10(v_int);
// Console.WriteLine("Digits:" + v_digits);
// bool v_is_p = true;
// for (int v_i = 0; v_i < v_digits / 2; v_i++)
// {
//     int v_d1 = (int)Math.Truncate((v_int % Math.Pow(10, v_i + 1)) / (Math.Pow(10, v_i)));
//     int v_d2 = (int)Math.Truncate((v_int % Math.Pow(10, v_digits - v_i + 1)) / (Math.Pow(10, v_digits - v_i)));
//     Console.WriteLine($"Compare: {v_d1} - {v_d2}");
//     if (v_d1 != v_d2)
//     {
//         v_is_p = false;
//         break;
//     }
// }
// if (v_is_p)
// {
//     Console.WriteLine($"Число {v_int} является палиндромом");
// }
// else
// {
//     Console.WriteLine($"Число {v_int} не является палиндромом");
// }

// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. (Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Через строку решать нельзя.14212 -> нет 12821 -> да 23432 -> да)

Console.Write("Число: ");
int a = Convert.ToInt32(Console.ReadLine());
int St = (int)Math.Log10(a);
Console.WriteLine("Степень числа 10= " + St);
bool v_is_p = true;
for (int a_i = 0; a_i < St / 2; a_i++)
{
    int v_d1 = (int)Math.Truncate((a % Math.Pow(10, a_i + 1)) / (Math.Pow(10, a_i)));
    int v_d2 = (int)Math.Truncate((a % Math.Pow(10, St - a_i + 1)) / (Math.Pow(10, St - a_i)));
    Console.WriteLine($"Compare: {v_d1} =? {v_d2}");
    if (v_d1 != v_d2)
    {
        v_is_p = false;
        break;
    }
}
if (v_is_p)
{
    Console.WriteLine($"Число {a} является палиндромом");
}
else
{
    Console.WriteLine($"Число {a} не является палиндромом");
}