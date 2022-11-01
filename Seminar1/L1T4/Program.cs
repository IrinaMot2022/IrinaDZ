int max_n = 3;
int v_max = -999999;
int[] v_array = new int[max_n];
for (int i = 0; i < max_n; i++)
{
    Console.Write("Введите элемент " + (i + 1) + ": ");
    v_array[i] = Convert.ToInt32(Console.ReadLine());
    if (v_array[i] > v_max)
    {
        v_max = v_array[i];
    }
}
Console.WriteLine("max = " + v_max);
