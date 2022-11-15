// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArrayRow(int[,] varr, int rowNum)
{
    int[] varr1 = new int[varr.GetLength(1)];
    for (int i = 0; i < varr.GetLength(1); i++) varr1[i] = varr[rowNum, i];
    Array.Sort(varr1);
    for (int i = 0; i < varr.GetLength(1); i++) varr[rowNum, i] = varr1[varr.GetLength(1)-i-1];
}

int[,] varr = new int[3, 4];
FillArrayInt(varr);
Console.WriteLine("Исходный массив");
PrintArray(varr, "{0,2:D0}");
for(int i=0;i<varr.GetLength(0);i++) SortArrayRow(varr, i);
Console.WriteLine("Сортированный массив");
PrintArray(varr, "{0,2:D0}");
