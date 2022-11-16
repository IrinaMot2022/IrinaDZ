// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int fSum(int m, int n){
    if(m==n) return n;
    return m+fSum(m+1,n);
}

Console.WriteLine(fSum(1,15));
Console.WriteLine(fSum(4,8));