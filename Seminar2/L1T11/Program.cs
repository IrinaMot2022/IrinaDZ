// Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
// числа. И, конечно же, через строку решать нельзя.

Console.Write("Число: ");
int v_int = Convert.ToInt32(Console.ReadLine());
int v_digits = (int)Math.Log10(v_int);
Console.WriteLine("Digits:"+v_digits);
int v_res = v_int/((int)Math.Pow(10,v_digits))*((int)Math.Pow(10,v_digits-1)) +
            v_int%((int)Math.Pow(10,v_digits-1));
Console.WriteLine(v_res);
