void DZ()
{
Console.WriteLine("47. Введите значения ширины и длины: ");
int bnum = Convert.ToInt32(Console.ReadLine());
int cnum = Convert.ToInt32(Console.ReadLine());
Random ra = new Random();
int si = bnum*cnum;
double [] ray = new double[si];
int [,] table = new int[bnum, cnum];
for (int i = 0, bar = 0; bar<bnum; bar++) 
{
    for (int col = 0; col<cnum; i++, col++)
    {
        double num = Math.Round (ra.NextDouble() * (-10.5-11)+11, 1);
        ray[i] = num;
        Console.Write(ray[i] + "\t");
    }
    Console.WriteLine("");
}
Console.WriteLine("50. Введите желаемые значения строки и столбца: ");
int mybar = Convert.ToInt32(Console.ReadLine());
int mycol = Convert.ToInt32(Console.ReadLine());
for (int i = 0, bar = 1; bar<=bnum; bar++)
{
        for (int col = 1; col<=cnum; i++, col++)
        {
            if (mybar == bar && mycol == col) { Console.WriteLine(ray[i]); break; }
            else if (mycol>cnum || mycol<=0) { Console.WriteLine("Такого элемента нет."); break; }
            else if (mybar>bnum || mybar<=0) { Console.WriteLine("Такого элемента нет."); break; }
        }
}
for (int i = 0, bar = 0; bar<bnum; bar++) 
{
    for (int col = 0; col<cnum; i++, col++)
    {
        int num = ra.Next(-10, 11);
        ray[i] = num;
        Console.Write(ray[i] + "\t");
    }
    Console.WriteLine("");
}
Console.Write("52. Среднее арифметическое каждого столбца: ");
for (int i = 0, col = 0; col<cnum; col++, i++) 
{
    double sum = 0;
    for (int bar = 0; bar<bnum; bar++)
    {
        Console.Write("(" + ray[i] + ", ");
        sum += ray[i];
    }
    Console.Write(") - ");
    Console.Write($"{sum*cnum}" + ", ");
}
Console.Write("\b\b");
}
DZ();