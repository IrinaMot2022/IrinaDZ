// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int f_count_odd_pos(int[] v_arr)
{
    int variab = 0;
    for (int index = 0; index < v_arr.Length; index = index + 2) variab = variab + v_arr[index];
    return variab;
}
int[] v_arr = IrinaFullArray(5);
f_print_array(v_arr);
Console.WriteLine($"Сумма на нечетных позициях: {f_count_odd_pos(v_arr)}");