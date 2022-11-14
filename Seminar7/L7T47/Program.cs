// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void PrintArray(Array varr, string v_f)
{
    int[] vidxArr = new int[varr.Rank];
    for (int i = 0; i < vidxArr.Length; i++) vidxArr[i] = 0;

    while (vidxArr[0] < varr.GetLength(0))
    {
        for (int i = 0; i < varr.Rank - 1; i++)
        {
            Console.Write($"({vidxArr[i],3})");
            if (i < varr.Rank - 2) Console.Write(",");
        }
        Console.Write("[");
        for (int i = 0; i < varr.GetLength(varr.Rank - 1); i++)
        {
            vidxArr[vidxArr.Length - 1] = i;
            string v_str = String.Format(v_f, varr.GetValue(vidxArr));
            Console.Write(v_str);
            if (vidxArr[vidxArr.Length - 1] < varr.GetLength(vidxArr.Length - 1) - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
        int vcurRank = varr.Rank - 2;
        if (vcurRank >= 0)
        {
            while (vidxArr[vcurRank] >= varr.GetLength(vcurRank)) vcurRank--;

            if (vidxArr[vcurRank] < varr.GetLength(vcurRank) - 1) vidxArr[vcurRank]++; else
            {
                for (int i = vcurRank; i < varr.Rank - 1; i++) vidxArr[i] = 0;
                vcurRank--;
                if (vcurRank >= 0) vidxArr[vcurRank]++; else break;
            }
        }
        else break;
    }
}

int[] GetArrayInt(int v_n, string v_comment)
{
    Console.Write($"Введите числа ({v_n} шт. {v_comment}) в формате v1;v2;..vN: ");
    string vstr = Console.ReadLine();
    string[] vstrArr = vstr.Split(";");
    // Console.WriteLine($"{v_str_arr.Length} элементов получено");
    int[] varr = new int[vstrArr.Length];
    for (int i = 0; i < vstrArr.Length; i++)
    {
        varr[i] = Convert.ToInt32(vstrArr[i]);
    }
    return varr;
}

void FillArrayDbl(double[,] varr)
{
    Random rnd = new Random();
    for (int j = 0; j < varr.GetLength(0); j++)
    {
        for (int i = 0; i < varr.GetLength(1); i++)
        {
            varr[j,i] = rnd.NextDouble()*10-5;
        }
    }
}

int[] vsizeArr = GetArrayInt(2, "размерность массива m*n");
Console.Write("Размерность массива: "); PrintArray(vsizeArr, "{0,5:D0}");
double[,] varr = new double[vsizeArr[0],vsizeArr[1]];
FillArrayDbl(varr);
PrintArray(varr, "{0,5:F2}");
