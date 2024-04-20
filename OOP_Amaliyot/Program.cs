

using System.Text;

string s = "salom";
s = s + " dunyo";

StringBuilder strbuilder= new StringBuilder();
strbuilder.Append("Salom");
strbuilder.Append("Dunyo");

Console.WriteLine(s);
Console.WriteLine(strbuilder);