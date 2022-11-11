// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 // 1, -7, 567, 89, 223-> 3
void f_print_array(Array v_arr, string v_f)
{
    Console.Write("[");
    for (int v_i = 0; v_i < v_arr.GetLength(0); v_i++)
    {
        string v_str = String.Format(v_f, v_arr.GetValue(v_i));
        Console.Write(v_str);
         // Console.Write($"{v_arr[v_i],9:F2}");
        if (v_i < v_arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}
int f_count_positiv(int[] v_arr)
{
    int v_count = 0;
    foreach (int v_el in v_arr)
    {
        if (v_el > 0) v_count++;
    }
    return v_count;
}
Console.Write("Сколько чисел вводить будем?: ");
int v_m = Convert.ToInt32(Console.ReadLine());
if (v_m > 5)
{
    Console.WriteLine("Думаю ты можешь устать, введи лучше 5 чисел.");
    v_m = 5;
}
int[] v_arr = new int[v_m];
for (int v_i = 0; v_i < v_arr.Length; v_i++)
{
    Console.Write($"Число {v_i}: ");
    v_arr[v_i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Итого ввели: ");
f_print_array(v_arr, "{0,9}");
Console.WriteLine($"Итого > 0 {f_count_positiv(v_arr)} числа, то есть {f_count_positiv(v_arr)} числа явялются положительными");