using System;

namespace CharPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take The User String
            Console.WriteLine("Enter The String");
            string name=Console.ReadLine();
            
            //Convert The String into Charecter Array
            char[] arr = name.ToCharArray();
            
            //Create Array For Reverse The String
            char[] rev = new char[name.Length];
            int j = 0;
            
            //Check String Is Palindrom 
            for(int i = name.Length - 1; i >= 0; i--)
            {
                rev[j] = name[i];
                j++;
            }

            //Convert The Reverse Charecter Array Into String
            string reverse = new string(rev);
            
            //Check User String And Reverse String Is Same 
            if (reverse.Equals(name)==true)
            {
                Console.WriteLine("The String Is Palindrome String");
            }
            else
            {
                Console.WriteLine("The String Is Not Palindrome String");
            }
        }
    }
}
