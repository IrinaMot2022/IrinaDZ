// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(Array varr, string v_f)
{
    int[] vidxArr = new int[varr.Rank];
    for (int i = 0; i < vidxArr.Length; i++) vidxArr[i] = 0;

    while (vidxArr[0] < varr.GetLength(0))
    {
        for (int i = 0; i < varr.GetLength(varr.Rank - 1); i++)
        {
            vidxArr[vidxArr.Length - 1] = i;
            string v_str = String.Format(v_f, varr.GetValue(vidxArr));
            Console.Write($"{v_str}");
            Console.Write($"(");
            for (int i1 = 0; i1 < varr.Rank - 1; i1++)
            {
                Console.Write($"{vidxArr[i1],3},");
            }
            Console.Write($"{i,3})");
        }
        Console.WriteLine();
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

void FillArrayIntUniq3d(int[,,] varr)
{
    int[] vUniqArr = new int[90];
    for(int i=0;i<90;i++) vUniqArr[i] = i+10;
    int vMinIdx = 0;
    int GetNextUniq(){
        int idx = new Random().Next(vMinIdx,vUniqArr.Length);
        int res = vUniqArr[idx];
        if(idx>vMinIdx) (vUniqArr[vMinIdx],vUniqArr[idx]) = (vUniqArr[idx],vUniqArr[vMinIdx]);
        vMinIdx++;
        return res;
    }

    for (int k = 0; k < varr.GetLength(0); k++)
    {
        for (int j = 0; j < varr.GetLength(0); j++)
        {
            for (int i = 0; i < varr.GetLength(1); i++)
            {
                varr[k, j, i] = GetNextUniq();
            }
        }
    }
}

int[,,] varr = new int[2, 2, 2];
FillArrayIntUniq3d(varr);
PrintArray(varr, "{0,4:D0}");