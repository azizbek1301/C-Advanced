using System.Text.RegularExpressions;

namespace ExtensionsMethods.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string s)
        {
            if(string.IsNullOrWhiteSpace(s))
            {

            }
            return char.ToUpper(s[0])+ s.Substring(1);
        }

        public static string CapitalizeAll(this string s)
        {

            //string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);  // Split and remove empty entries
            //string textWithSingleSpaces = string.Join(" ", words);

            //return textWithSingleSpaces; // Output: This is a string with multiple spaces.

           
            string textWithSingleSpaces = Regex.Replace(s, @"\s+", " ");

            return textWithSingleSpaces.Trim(); // Output: This is a string with multiple spaces.


        }
    }
}
