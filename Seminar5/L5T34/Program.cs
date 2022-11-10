// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] IrinaFullArray(int array1)
{
    int[] arrayFind = new int[array1];
    for (int index = 0; index < arrayFind.Length; index++)
    {
        arrayFind[index] = new Random().Next(0, 1000);
    }
    return arrayFind;
}

void f_print_array(int[] arrayFind)
{
    Console.Write("Печать сучайного массива IrinaFullArray [");
    for (int index = 0; index < arrayFind.Length; index++)
    {
        Console.Write(arrayFind[index]);
        if (index < arrayFind.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int Irina_count_even(int[] v_arr)
{
    int index = 0;
    foreach(int v_el in v_arr)
    {
        if(v_el%2==0) index++;
    }
    return index;
}

int[] v_arr = IrinaFullArray(5);
f_print_array(v_arr);
Console.WriteLine($"Количество четных цифр в случайном массиве: {Irina_count_even(v_arr)}");