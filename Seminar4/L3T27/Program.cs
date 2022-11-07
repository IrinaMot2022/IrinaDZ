// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int f_digit_length(int v_int)
{
    return (int)Math.Log10(v_int) + 1;
}

int f_digit(int v_int, int v_d)
{
    return (int)Math.Truncate((v_int % Math.Pow(10, v_d + 1)) / (Math.Pow(10, v_d)));
}

Console.Write("Число: ");
int v_int = Convert.ToInt32(Console.ReadLine());
int v_sum = 0;
Console.WriteLine("Разрядность: " + f_digit_length(v_int));
for (int v_i = 0; v_i < f_digit_length(v_int); v_i++)
{
    v_sum = v_sum + f_digit(v_int, v_i);
}
    Console.WriteLine($"Сумма: {v_sum}");
