

List<int> ls = new List<int>()
{
    1,2,3,4,5,6,7,8,9,10,11,12,13 
};
var sonlar = new int[]{ 1000000000,0000000,2222222,3333333 };
ls.Add(0);
ls.AddRange(sonlar);

foreach (var item in ls)
{
    Console.WriteLine(item);
}