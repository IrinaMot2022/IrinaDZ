// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

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

void ConvertArray2to1(int[,] varr, int[] varr1){
    for(int j=0;j<varr.GetLength(0);j++){
        for(int i=0;i<varr.GetLength(1);i++){
            varr1[j*varr.GetLength(1)+i] = varr[j,i];
        }
    }
}

void ConvertArray1to2(int[] varr1,int[,] varr){
    for(int j=0;j<varr.GetLength(0);j++){
        for(int i=0;i<varr.GetLength(1);i++){
            varr[j,i] = varr1[j*varr.GetLength(1)+i];
        }
    }
}

void SortArray(int[,] varr){
    int[] varr1 = new int[varr.GetLength(0)*varr.GetLength(1)];
    ConvertArray2to1(varr, varr1);
    Array.Sort(varr1);
    ConvertArray1to2(varr1, varr);
}

int[] vsizeArr = { 2, 3 };
//int[] vsizeArr = GetArrayInt(2, "размерность массива m*n");
Console.Write("Размерность массива: "); PrintArray(vsizeArr, "{0,0:D0}");
int[,] varr = new int[vsizeArr[0], vsizeArr[1]];
FillArrayInt(varr);
Console.WriteLine("Исходный массив");
PrintArray(varr, "{0,5:D0}");
SortArray(varr);
Console.WriteLine("Сортированный массив");
PrintArray(varr, "{0,5:D0}");
