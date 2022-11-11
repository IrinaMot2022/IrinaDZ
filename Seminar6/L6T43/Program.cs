// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void f_print_array(Array v_arr, string v_f)
{
    int[] v_idx_arr = new int[v_arr.Rank];
    for (int v_i = 0; v_i < v_idx_arr.Length; v_i++) v_idx_arr[v_i] = 0;

    while (v_idx_arr[0] < v_arr.GetLength(0))
    {
        for (int v_i = 0; v_i < v_arr.Rank - 1; v_i++)
        {
            Console.Write($"({v_idx_arr[v_i]})");
            if (v_i < v_arr.Rank - 2) Console.Write(",");
        }
        Console.Write("[");
        for (int v_i = 0; v_i < v_arr.GetLength(v_arr.Rank - 1); v_i++)
        {
            v_idx_arr[v_idx_arr.Length - 1] = v_i;
            string v_str = String.Format(v_f, v_arr.GetValue(v_idx_arr));
            Console.Write(v_str);
            if (v_idx_arr[v_idx_arr.Length - 1] < v_arr.GetLength(v_idx_arr.Length - 1) - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
        int v_cur_rank = v_arr.Rank - 2;
        if (v_cur_rank >= 0)
        {
            while (v_idx_arr[v_cur_rank] >= v_arr.GetLength(v_cur_rank)) v_cur_rank--;

            if (v_idx_arr[v_cur_rank] < v_arr.GetLength(v_cur_rank) - 1)
            {
                v_idx_arr[v_cur_rank]++;
            }
            else
            {
                for (int v_i = v_cur_rank; v_i < v_arr.Rank - 1; v_i++) v_idx_arr[v_i] = 0;
                v_cur_rank--;
                if (v_cur_rank >= 0)
                {
                    v_idx_arr[v_cur_rank]++;
                }
                else break;
            }
        }
        else
        {
            break;
        }
    }
}
double[] f_get_array_dbl(int v_n, string v_comment)
{
    Console.Write($"Введите числа ({v_n} шт. {v_comment}) в формате v1;v2;..vN: ");
    string v_str = Console.ReadLine();
    string[] v_str_arr = v_str.Split(";");
    // Console.WriteLine($"{v_str_arr.Length} элементов получено");
    double[] v_arr = new double[v_str_arr.Length];
    for (int v_i = 0; v_i < v_str_arr.Length; v_i++)
    {
        v_arr[v_i] = Convert.ToDouble(v_str_arr[v_i]);
    }
    return v_arr;
}
double[] f_intersect(double[] v_line1_arr, double[] v_line2_arr)
{
    double[] res = new double[2];
    //ax+c=bx+d
    //x=(d-c)/(a-b)
    //y=a*((d-c)/(a-b))+c
    double a = v_line1_arr[1];
    double b = v_line2_arr[1];
    double c = v_line1_arr[0];
    double d = v_line2_arr[0];
    if (a == b) Console.WriteLine("Заданы параллельные или совпадающие прямые");
    res[0] = (d - c) / (a - b);
    res[1] = a * ((d - c) / (a - b)) + c;
    return res;
}
double[] v_line1_arr = f_get_array_dbl(2, "задающие линию 1 уравнением y=kx+b, b1;k1");
double[] v_line2_arr = f_get_array_dbl(2, "задающие линию 2 уравнением y=kx+b, b2;k2");
double[] v_point = f_intersect(v_line1_arr, v_line2_arr);
Console.Write("Линия 1 [b,k]: "); f_print_array(v_line1_arr, "{0,9:F2}");
Console.Write("Линия 2 [b,k]: "); f_print_array(v_line2_arr, "{0,9:F2}");
Console.Write("Точка пересечения [x,y]: "); f_print_array(v_point, "{0,9:F5}");


//double[,,] v_arr = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } }, { { 13, 14 }, { 15, 16 } } };
//double[,] v_arr = { { 1, 2, 3, 4 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };
//double[] v_arr = { 1, 2, 3 };
//f_print_array(v_arr, "{0,9:F2}");