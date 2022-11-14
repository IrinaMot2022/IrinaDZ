// задача 2 HARD необязательная. За четыре обязательных ) 
// Сгенерировать массив случайных целых чисел размерностью m*n 
// (размерность вводим с клавиатуры) , 
// причем чтоб количество элементов было четное. 
// Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, 
// причем чтобы каждый гарантированно переместился на другое место 
// и выполнить это за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. 
// И далее в конце опять вывести на экран как таблицу.

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

int[] FlatTo2D(int i, int n){
    int[] res = {i / n,i % n};
    return res;
}

void SwapFlat(int[,] varr, int i, int j){
    int[] c1 = FlatTo2D(i,varr.GetLength(1));
    int[] c2 = FlatTo2D(j,varr.GetLength(1));
//    Console.WriteLine($"i:{i} j:{j} c1:({c1[0]},{c1[1]}) c2:({c2[0]},{c2[1]})");
    (varr[c1[0],c1[1]],varr[c2[0],c2[1]])=(varr[c2[0],c2[1]],varr[c1[0],c1[1]]);
}

void ShuffleArray(int[,] varr)
{
    int l1 = varr.GetLength(0);
    int[] idxArr = new int[varr.GetLength(0) * varr.GetLength(1)];
    for (int i = 0; i < idxArr.Length; i++) idxArr[i] = i;

    Random rnd = new Random();
    for (int i = idxArr.Length-2; i>=0; i=i-2)
    {
        int n = rnd.Next(0, i+1);
        if(n<i) (idxArr[n], idxArr[i]) = (idxArr[i], idxArr[n]);
        SwapFlat(varr,idxArr[i],idxArr[i+1]);
        // Console.WriteLine($" rnd limit: {i+1,3:D0} n:{n} idx:({i},{i+1}) swap idx:({idxArr[i]},{idxArr[i+1]})");
    }

    // PrintArray(idxArr, "{0,5:D0}");
}
//ввод размерности вручную и случайное заполнение
//int[] vsizeArr = GetArrayInt(2, "размерность массива m*n");
//Console.Write("Размерность массива: "); PrintArray(vsizeArr, "{0,0:D0}");
//int[,] varr = new int[vsizeArr[0], vsizeArr[1]];
//FillArrayInt(varr);

//тестовый массив, на котором лучше видно что перемещаются все элементы
int[,] varr = {{1,2,3,4},{5,6,7,8},{9,10,11,12}};

Console.WriteLine("Исходный массив");
PrintArray(varr, "{0,5:D0}");
ShuffleArray(varr);
Console.WriteLine("Перемешанный массив");
PrintArray(varr, "{0,5:D0}");
