Console.Write("Число: ");
int v_int = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= v_int; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

