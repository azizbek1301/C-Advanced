

//int a=int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//Swap(ref a, ref b);
//Console.WriteLine($"a = {a} , b = {b}");

//float a = 5;
//kvadrat(a, out float yuza1, out float perimetr1, out float radius1);
//Console.WriteLine(yuza1 + " " + perimetr1 + " " + radius1);
//Console.ReadKey();  

//static void kvadrat(float a, out float yuza, out float perimetr, out float radius)
//{
//    yuza = a * a;
//    perimetr = 4 * a;
//    radius = a / 2;
//}

//static void Swap(ref int a,ref int b)
//{
//    int c= b;
//    b = a;
//    a = c;

//}


int a = int.Parse(Console.ReadLine());
ChekNumber(a);

static void ChekNumber(int a)
{
    if (a > 0)
        Console.WriteLine("bu son musbat");
    else if (a < 0) Console.WriteLine("Bu son manfiy");
    else Console.WriteLine("son 0 ga teng");
}