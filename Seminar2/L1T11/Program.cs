// Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
// числа. И, конечно же, через строку решать нельзя.

// Console.Write("Число: ");
// int v_int = Convert.ToInt32(Console.ReadLine());
// int v_digits = (int)Math.Log10(v_int);
// Console.WriteLine("Digits:"+v_digits);
// int v_res = v_int/((int)Math.Pow(10,v_digits))*((int)Math.Pow(10,v_digits-1)) +
//              v_int%((int)Math.Pow(10,v_digits-1));
// Console.WriteLine(v_res);


Console.Write("Число: ");
int a = Convert.ToInt32(Console.ReadLine());
int st = (int)Math.Log10(a);
Console.WriteLine("Степень в которую надо возвести 10, чтобы получилось число a, с учетом округления до целого="+st);
int aNe = a/((int)Math.Pow(10,st))*((int)Math.Pow(10,st-1));
Console.WriteLine("Это что-то="+aNe);
int aNew=aNe+          a%((int)Math.Pow(10,st-1));
Console.WriteLine(aNew);