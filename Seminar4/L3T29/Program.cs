

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// с клавиатуры и выводит массив на экран.

int[] f_get_array(){
    Console.Write("Введите массив в формате v1,v2,..vN: ");
    string v_str = Console.ReadLine();
    string[] v_str_arr = v_str.Split(",");
    Console.WriteLine($"{v_str_arr.Length} элементов получено");
    int[] v_arr = new int[v_str_arr.Length];
    for(int v_i=0;v_i<v_str_arr.Length;v_i++){
        v_arr[v_i] = Convert.ToInt32(v_str_arr[v_i]);
    }
    return v_arr;
}

void f_print_array(int[] v_arr){
    Console.Write("[");
    for(int v_i=0;v_i<v_arr.Length;v_i++){
        Console.Write(v_arr[v_i]);
        if(v_i<v_arr.Length-1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] v_i_arr = f_get_array();
f_print_array(v_i_arr);
