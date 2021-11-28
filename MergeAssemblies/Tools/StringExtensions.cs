using System;

namespace Technagem.Tools
{
    public static class StringExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string SayHi(this String str)
        {
            return $"Hi {str}!";
        }

        public static string SayHello(this String str)
        {
            return $"Hello {str}!";
        }
    }
}
