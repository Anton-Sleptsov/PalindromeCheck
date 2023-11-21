namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            if(IsPalindrome(str))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Это палиндром");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это не палиндром");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static bool IsPalindrome(string strStart)
        {
            string strEnd;

            strStart = ReplaceSymbols(strStart);
            strStart = strStart.ToLower(); 
            
            strEnd = Reverse(strStart);

            if (strStart ==  strEnd)
                return true;
            else
                return false;
        }

        static string ReplaceSymbols(string str)
        {    
            return str.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace("-", "").Replace("\"", "");
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}