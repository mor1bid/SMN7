void DZ1()
{
Console.WriteLine("48. Введите значения ширины и длины: ");
int bnum = Convert.ToInt32(Console.ReadLine());
int cnum = Convert.ToInt32(Console.ReadLine());
Random ra = new Random();
int si = ra.Next(2, 11);
int [,] table = new int[bnum, cnum];
double [] ray = new double[si]; 
for (int bar = 0; bar < bnum; bar++) 
{
    for (int i=0, col = 0; col<cnum; col++, i++) 
    {
        //int numa = ra.Next(-10, 11);
        double numb = Math.Round (ra.NextDouble() * (-10.5-11)+11, 1);
        ray[i] = numb;
        Console.Write(ray[i] + "\t");
        // ray[i] = numa;
        // Console.Write(ray[i] + "\t");
    }
    Console.WriteLine("");
}
}


DZ1();