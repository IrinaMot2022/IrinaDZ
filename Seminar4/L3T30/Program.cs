
// Задача 30: - HARD необязательная Напишите программу, 
// которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. 
// Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

void f_print_array(int[] v_arr)
{
    Console.Write("[");
    for (int v_i = 0; v_i < v_arr.Length; v_i++)
    {
        Console.Write(v_arr[v_i]);
        if (v_i < v_arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

bool f_pos_array(int[] v_arr)
{
    int v_sum = 0;
    for (int v_i = 0; v_i < v_arr.Length; v_i++)
    {
        v_sum = v_sum + v_arr[v_i];
    }
    if(v_sum>v_arr.Length/2) return true; else return false;
}

int[] v_arr = new int[8];
for (int v_i = 0; v_i < v_arr.Length; v_i++)
{
    v_arr[v_i] = new Random().Next(0, 2);
}

f_print_array(v_arr);
Console.WriteLine(f_pos_array(v_arr));