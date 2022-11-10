// 38 Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива 
// Задайте массив случайных целых чисел. 
// Задача HARD 38STAT необязательная: 
// Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива, 
// возможно придется кое-что для этого дополнительно выполнить.

double[] f_create_fill_array_dbl(int v_arr_l)
{
    double[] v_arr = new double[v_arr_l];
    Random random = new Random();
    for (int v_i = 0; v_i < v_arr.Length; v_i++)
    {
        v_arr[v_i] = random.NextDouble() * 100 - 50;
    }
    return v_arr;
}

void f_print_array(Array v_arr, string v_f)
{
    Console.Write("[");
    for (int v_i = 0; v_i < v_arr.GetLength(0); v_i++)
    {
        string v_str = String.Format(v_f, v_arr.GetValue(v_i));
        Console.Write(v_str);
        // 
        // Console.Write($"{v_arr[v_i],9:F2}");
        if (v_i < v_arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

string[] v_arr_stat_header = { "min", "max", "min_idx", "max_idx", "avg" , "med"};
double[] f_calc_arr_stat(double[] v_arr)
{
    double[] v_stat_arr = new double[6];
    double v_min = 999999999;
    double v_max = -999999999;
    int v_min_idx = -1;
    int v_max_idx = -1;
    double v_sum =0;
    for (int v_i = 0; v_i < v_arr.Length; v_i++)
    {
        if (v_arr[v_i] > v_max)
        {
            v_max = v_arr[v_i];
            v_max_idx = v_i;
        }
        if (v_arr[v_i] < v_min)
        {
            v_min = v_arr[v_i];
            v_min_idx = v_i;
        }
        v_sum = v_sum + v_arr[v_i];
    }
    v_stat_arr[0] = v_min;
    v_stat_arr[1] = v_max;
    v_stat_arr[2] = v_min_idx;
    v_stat_arr[3] = v_max_idx;
    v_stat_arr[4] = v_sum/v_arr.Length;
    double[] v_arr_sorted = v_arr;
    Array.Sort(v_arr_sorted);
    v_stat_arr[5] = v_arr_sorted[v_arr_sorted.Length/2];
    return v_stat_arr;
}

double[] v_arr = f_create_fill_array_dbl(5);
// double[] v_arr = {1,1,3,5,4};

f_print_array(v_arr, "{0,9:F2}");
double[] v_stat_arr = f_calc_arr_stat(v_arr);
f_print_array(v_arr_stat_header, "{0,9}");
f_print_array(v_stat_arr, "{0,9:F2}");
Console.WriteLine("v_max-v_min={0,9:F2}", v_stat_arr[1] - v_stat_arr[0]);
