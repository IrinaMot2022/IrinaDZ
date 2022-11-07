

// Задача 26. - HARD необязательная Напишите программу, 
// которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4



int f_digit_length(double v_d)
{   
    if(v_d<9) v_d = v_d+1;
    int v_n = (int)Math.Truncate(v_d);
    while((v_d-v_n)>0.000000000001){
        v_d = v_d*10;
        v_n = (int)Math.Truncate(v_d);
    }
    return (int)Math.Log10(v_n) + 1;
}

Console.Write("Число: ");
double v_d = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Разрядность: " + f_digit_length(v_d));
