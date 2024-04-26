namespace ExtensionsMethods.Extensions
{
    public static class CollectionExtensions
    {

        public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            // Copy elements to a list for efficient random access
            List<TSource> elements = new List<TSource>(source);
            Random random = new Random();

            for (int i = elements.Count - 1; i > 0; i--)
            {
                // Generate a random index between 0 and i (inclusive)
                int j = random.Next(i + 1);

                // Swap the current element with the randomly chosen element
                TSource temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;
            }

            return elements;
        }
        private static readonly Random rng = new Random();
        public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> source, int startIndex, int endIndex)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (startIndex < 0 || endIndex < 0 || endIndex < startIndex || endIndex >= source.Count())
                throw new ArgumentOutOfRangeException("Invalid start or end index.");

            List<TSource> list = source.ToList();
            for (int i = startIndex; i <= endIndex; i++)
            {
                int randomIndex = rng.Next(startIndex, endIndex + 1);
                TSource temp = list[i];
                list[i] = list[randomIndex];
                list[randomIndex] = temp;
            }
            return list;
        }
    }


}

