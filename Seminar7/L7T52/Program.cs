// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FillArrayInt(int[,] varr)
{
    Random rnd = new Random();
    for (int j = 0; j < varr.GetLength(0); j++)
    {
        for (int i = 0; i < varr.GetLength(1); i++)
        {
            varr[j, i] = rnd.Next(-10, 10);
        }
    }
}

double ArrayColSum(int[,] varr, int col){
    double sum = 0;
    for(int j=0;j<varr.GetLength(0);j++){
        sum += varr[j,col];  
    }
    return sum/varr.GetLength(0);    
}

int[] vsizeArr = { 3, 5 };
Console.Write("Размерность массива: "); PrintArray(vsizeArr, "{0,7:D1}");
int[,] varr = new int[vsizeArr[0], vsizeArr[1]];
FillArrayInt(varr);
PrintArray(varr, "{0,7:F2}");
double[] vsumArr = new double[varr.GetLength(1)];
for(int i=0;i<varr.GetLength(1);i++) vsumArr[i] = ArrayColSum(varr,i);
Console.Write("AVG, т.е. среднее арифметичкое по столбцам: ");PrintArray(vsumArr, "{0,7:F2}");