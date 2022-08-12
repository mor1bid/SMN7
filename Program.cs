void Z1()
{
Console.WriteLine("48. Введите значения ширины и длины: ");
int bnum = Convert.ToInt32(Console.ReadLine()), 
    cnum = Convert.ToInt32(Console.ReadLine());
int [,] table = new int[bnum, cnum];
for (int bar = 0; bar < bnum; bar++) 
{
    for (int col = 0; col < cnum; col++) 
    {
        Console.Write($"{bar + col}");
    }
    Console.WriteLine("");
}
}

void Z2()
{
Console.WriteLine("48. Введите значения ширины и длины: ");
int bnum = Convert.ToInt32(Console.ReadLine()), 
    cnum = Convert.ToInt32(Console.ReadLine());
int [,] table = new int[bnum, cnum];
for (int bar = 0; bar < bnum; bar++) 
{
    for (int col = 0; col < cnum; col++) 
    {
        if (col % 2 == 0) { Console.Write($"{Math.Pow(bar + col, 2)}" + " "); }
        else Console.Write($"{bar + col}" + " ");
    }
    Console.WriteLine("");
}
}

void Z3()
{

}

//Z1();
Z2();
Z3();