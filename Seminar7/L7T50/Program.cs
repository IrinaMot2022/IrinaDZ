// Задача 50. Напишите программу, 
// которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

Array FindIntInArray(Array varr, int fint)
{
    int[] vidxArr = new int[varr.Rank];
    for (int i = 0; i < vidxArr.Length; i++) vidxArr[i] = 0;
    int vcurRank = varr.Rank - 1; ;
    while (vcurRank >= 0)
    {
        // PrintArray(vidxArr, "{0,5:D0}");
        if((int)varr.GetValue(vidxArr)==fint){
            return vidxArr;
        }
        vcurRank = varr.Rank - 1;
        if (vidxArr[vcurRank] < varr.GetLength(vcurRank) - 1) vidxArr[vcurRank]++;
        else
        {
            for (int i = vcurRank; i < varr.Rank; i++) vidxArr[i] = 0;
            vcurRank--;
            if (vcurRank >= 0)
            {
                if (vidxArr[vcurRank] < varr.GetLength(vcurRank) - 1) vidxArr[vcurRank]++; else break;
            }
            else break;
        }
    }
    vidxArr[0]=-1; vidxArr[1]=-1;
    return vidxArr;
}

int[] vsizeArr = { 4, 5 };
Console.Write("Мы задали следущую размерность массива: "); PrintArray(vsizeArr, "{0,0:D0}");
int[,] varr = new int[vsizeArr[0], vsizeArr[1]];
FillArrayInt(varr);
PrintArray(varr, "{0,5:D0}");
Array vcoordArr = FindIntInArray(varr, 5);
Console.WriteLine("Мы ищем в заданном массиве число: 5");
if((int)vcoordArr.GetValue(0)>=0){
Console.Write("Найденные координаты: "); PrintArray(vcoordArr, "{0,5:D0}");
} else {
    Console.WriteLine("такого числа в массиве нет");
}