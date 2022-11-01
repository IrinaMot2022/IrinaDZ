Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("max: ");
    Console.Write(a);
}
else
if (b > a)
{
    Console.Write("max: ");
    Console.Write(b);
}
else
{
    Console.Write("a=b=");
    Console.Write(b);
}
