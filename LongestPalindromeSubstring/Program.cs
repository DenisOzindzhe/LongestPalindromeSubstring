namespace LongestPalindromeSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? value = Console.ReadLine();
            string? solution = LongestPalindromeSubstring.GetSubstring(value);
            Console.WriteLine(solution);
        }
    }

    class LongestPalindromeSubstring
    {
        static int lenght = 0;
        static int start = 0;
        public static string GetSubstring(string s)
        {
            string? result = " ";
            

            if (s == null || s == " " || s.Length <= 1) return s;
            

            for (int i = 0; i < s.Length; i++)
            {
                MiddlePointer(s, i, i);
                MiddlePointer(s, i, i + 1);
            }


            result = s.Substring(start,lenght);
            return result;
        }
        public static void MiddlePointer(string s, int i, int j)
        {
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                i--;
                j++;
            }
            if (j - i - 1 > lenght)
            {
                lenght = j - i - 1;
                start = i + 1;
            }
        }
    }
}