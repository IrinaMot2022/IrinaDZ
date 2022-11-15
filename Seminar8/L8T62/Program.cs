// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// UPD: процедура заполняет массив любой размерности))

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

void FillSpiralArray(Array varr)
{
    bool vContinue = true;
    int[,] vdirArr = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
    int vcurDir = 0;
    int vCounter = 1;
    int[] idxArr = { 0, 0 };
    bool incIdx()
    {
        bool res = false;
        int vRotateCount = 0;
        void changeDir()
        {
            vcurDir = (vcurDir + 1) % 4;
            vRotateCount++;
            res = false;
        }
        while (!res)
        {
            res = true;
            int[] newIdxArr = { idxArr[0] + vdirArr[vcurDir, 0], idxArr[1] + vdirArr[vcurDir, 1] };
            if (newIdxArr[0] >= varr.GetLength(0)) changeDir();
            if(!res) if(vRotateCount>1) {res = false; break;} else continue;
            if (newIdxArr[0] < 0) changeDir();
            if(!res) if(vRotateCount>1) {res = false; break;} else continue;
            if (newIdxArr[1] >= varr.GetLength(1)) changeDir();
            if(!res) if(vRotateCount>1) {res = false; break;} else continue;
            if (newIdxArr[1] < 0) changeDir();
            if(!res) if(vRotateCount>1) {res = false; break;} else continue;
//            Console.WriteLine($"i:{newIdxArr[0]} j:{newIdxArr[1]} dir:{vcurDir} vcount:{vRotateCount}");
            if ((int)varr.GetValue(newIdxArr)>0) changeDir();
            if(!res) if(vRotateCount>1) {res = false; break;} else continue;
            idxArr[0] = newIdxArr[0];
            idxArr[1] = newIdxArr[1];
            res = true;
        }
        return res;
    }
    while (vContinue)
    {
        varr.SetValue(vCounter, idxArr);
        vCounter++;
        vContinue = incIdx();
    }
}

int[,] varr = new int[4, 3];
FillSpiralArray(varr);
PrintArray(varr, "{0,2:D2}");
