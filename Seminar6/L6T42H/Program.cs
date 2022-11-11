// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. 
// Найти минимальное число и его индекс, 
// найти максимальное число и его индекс. Вывести эту информацию на экран.
void f_print_array(Array v_arr, string v_f)
{
    int[] v_idx_arr = new int[v_arr.Rank];
    for (int v_i = 0; v_i < v_idx_arr.Length; v_i++) v_idx_arr[v_i] = 0;

    while (v_idx_arr[0] < v_arr.GetLength(0))
    {
        for (int v_i = 0; v_i < v_arr.Rank - 1; v_i++)
        {
            Console.Write($"({v_idx_arr[v_i],3})");
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

int[] f_get_array_int(int v_n, string v_comment)
{
    Console.Write($"Введите числа ({v_n} шт. {v_comment}) в формате v1;v2;..vN: ");
    string v_str = Console.ReadLine();
    string[] v_str_arr = v_str.Split(";");
    // Console.WriteLine($"{v_str_arr.Length} элементов получено");
    int[] v_arr = new int[v_str_arr.Length];
    for (int v_i = 0; v_i < v_str_arr.Length; v_i++)
    {
        v_arr[v_i] = Convert.ToInt32(v_str_arr[v_i]);
    }
    return v_arr;
}

void f_fill_array(int[,] v_arr)
{
    Random rnd = new Random();
    for (int v_j = 0; v_j < v_arr.GetLength(0); v_j++)
    {
        for (int v_i = 0; v_i < v_arr.GetLength(1); v_i++)
        {
            v_arr[v_j,v_i] = rnd.Next(-100, 101);
        }
    }
}

void f_print_arr_stat(int[,] v_arr)
{
    string[] v_h_arr = {"val", "i", "j"};
    int[] v_min_arr = {99999999,-1,-1};
    int[] v_max_arr = {-99999999,-1,-1};
    for (int v_j = 0; v_j < v_arr.GetLength(0); v_j++)
    {
        for (int v_i = 0; v_i < v_arr.GetLength(1); v_i++)
        {
            if(v_arr[v_j,v_i]>v_max_arr[0]){
                v_max_arr[0] = v_arr[v_j,v_i];
                v_max_arr[1] = v_i;
                v_max_arr[2] = v_j;
            }
            if(v_arr[v_j,v_i]<v_min_arr[0]){
                v_min_arr[0] = v_arr[v_j,v_i];
                v_min_arr[1] = v_i;
                v_min_arr[2] = v_j;
            }
        }
    }
    Console.Write("    ");f_print_array(v_h_arr, "{0,9}");
    Console.Write("min:");f_print_array(v_min_arr, "{0,9:D0}");
    Console.Write("max:");f_print_array(v_max_arr, "{0,9:D0}");
}
int[] v_size = f_get_array_int(2, "размерность массива m*n");
Console.Write("Размерность массива: "); f_print_array(v_size, "{0,0:D0}");
int[,] v_arr = new int[v_size[0], v_size[1]];
f_fill_array(v_arr);
Console.WriteLine("Заполненный случайными числами массив");
f_print_array(v_arr, "{0,8:D0}");
Console.WriteLine("Инфо по массиву");
f_print_arr_stat(v_arr);