// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int f_my_pow(int a, int b)
{
    int v_res = a;
    for(int v_i=1;v_i<b;v_i++){
        v_res = v_res * a;
    }
    return v_res;    
}

Console.Write("Число: ");
int v_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Степень: ");
int v_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f_my_pow(v_a,v_b));