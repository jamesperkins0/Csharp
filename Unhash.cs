using System;
using System.Text;
 
    class Unhash
    {
        private const String letters = "acdegilmnoprstuw";
 
        static void Main(string[] args)
        {
            
            Int64 hash = Hash("leepadg");
            Console.WriteLine("phrase hashed:\t\t{0}", hash); // 680131659347
            Console.WriteLine("phrase unhashed:\t{0}", Unhasher(hash)); // "leepadg"
 
            Console.WriteLine();
            Console.WriteLine("The Word we are looking for:\t\t{0}", Unhasher(956446786872726));
            Console.ReadLine();
        }
 
        private static Int64 Hash (String s)
        {
            Int64 h = 7;
            for(Int32 i = 0; i < s.Length; i++)
            {
                h = (h * 37 + letters.IndexOf(s[i]));
            }
            return h;
        }
 
        private static String Unhasher(Int64 n)
        {
            StringBuilder output = new StringBuilder();
 
            while (n > 7)
            {
               
                for (Int32 i = 0; i < letters.Length; i++)
                {
                    Int64 nAdjustment = n - i;
                    Int64 remainder = nAdjustment % 37;
                    bool letter = (remainder == 0);
 
                    if (letter)
                    {
                        output.Insert(0, letters[i]);
                        n = (n - i)/37;
                        break;
                    }
                }
            }
 
            return output.ToString();
        }
    }