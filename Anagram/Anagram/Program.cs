namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word1 = "dog";
            string word2 = "god";
            int j = 0;
            int i = 0;
            if (word1.Length == word2.Length)
            {
                for (; i <= word1.Length - 1; j++)
                {

                    if (j < word1.Length && word1[i] == word2[j])
                    {
                        i++;
                        j = -1;
                    }
                    else if (j == word1.Length - 1)
                    {
                        if (j < word1.Length)
                        {
                            Console.WriteLine("Is not anagram");
                        }
                        break;

                    }
                }
                if (word1.Length == i)
                {
                    Console.WriteLine("Anagram");
                }
            }
            else
            {
                Console.WriteLine("Is not anagram");
            }
        }
    }
}