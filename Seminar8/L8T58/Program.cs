// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

            if (vidxArr[vcurRank] < varr.GetLength(vcurRank) - 1) vidxArr[vcurRank]++;
            else
            {
                for (int i = vcurRank; i < varr.Rank - 1; i++) vidxArr[i] = 0;
                vcurRank--;
                if (vcurRank >= 0) vidxArr[vcurRank]++; else break;
            }
        }
        else break;
    }
}

double[,] MatrixMultiply(double[,] varr1, double[,] varr2)
{
    double[,] resArr = new double[varr1.GetLength(0), varr1.GetLength(1)];
    for (int i = 0; i < varr1.GetLength(0); i++)
    {
        for (int j = 0; j < varr1.GetLength(0); j++)
        {
            double vMult = 0;
            for (int k = 0; k < varr1.GetLength(1);k++) vMult += varr1[i, k] * varr2[k, j];
            resArr[i, j] = vMult;
        }
    }
    return resArr;
}

// 2 4 | 3 4
// 3 2 | 3 3
double[,] varr1 = {  {2,4},
    {3,2}
};
double[,] varr2 = {
    {3,4},
    {3,3}
};

PrintArray(varr1, "{0,0:F1}");
Console.WriteLine("X");
PrintArray(varr2, "{0,0:F1}");
double[,] varr3 = MatrixMultiply(varr1, varr2);
Console.WriteLine("=");
PrintArray(varr3, "{0,0:F1}");
