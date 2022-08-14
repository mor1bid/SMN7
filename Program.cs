void DZ1()
{
Console.WriteLine("48. Введите значения ширины и длины: ");
int bnum = Convert.ToInt32(Console.ReadLine());
int cnum = Convert.ToInt32(Console.ReadLine());
Random ra = new Random();
int si = bnum*cnum;
int [,] table = new int[bnum, cnum];
double [] ray = new double[si]; 
for (int bar = 0; bar < bnum; bar++) 
{
    for (int i=0, col = 0; col<cnum; i++, col++) 
    {
        double numb = Math.Round (ra.NextDouble() * (-10.5-11)+11, 1);
        ray[i] = numb;
        Console.Write(ray[i] + "\t");
    }
    Console.WriteLine("");
}
}

void DZ2()
{
Console.WriteLine("48. Введите значения ширины и длины: ");
int bnum = Convert.ToInt32(Console.ReadLine());
int cnum = Convert.ToInt32(Console.ReadLine());
Random ra = new Random();
int si = bnum*cnum;
int [,] table = new int[bnum, cnum];
double [] ray = new double[si]; 
for (int bar = 0; bar < bnum; bar++) 
{
    for (int i=0, col = 0; col<cnum; i++, col++)
    {
        if(i<si) 
        {
            int num = ra.Next(-10, 11);
            ray[i] = num;
            Console.Write(ray[i] + "\t");
        }
    }
    Console.WriteLine("");
}
Console.WriteLine("Введите желаемые значения строки и столбца: ");
int mybar = Convert.ToInt32(Console.ReadLine());
int mycol = Convert.ToInt32(Console.ReadLine());
for (int bar = 1; bar <= bnum;)
{
    if (mybar == bar) 
    {
        for (int i=11, col = 1; col<=cnum; i++, col++)
        {
            if (mycol == col) { Console.WriteLine(ray[i]); break; }
            else if (mycol>cnum || mycol<=0) { Console.WriteLine("Такого элемента нет."); break; }
        }
    break;
    }
    else if (mybar>bnum || mybar<=0) { Console.WriteLine("Такого элемента нет."); break; }
    else bar++;
}
}

//DZ1();
DZ2();