using System;
using System.Collections;

namespace SpamCheckLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blackListWord = { "buy", "viagra", "free money", "lifetime offer", "send money", "meet girls", "h8te", "online pharmacy", "nigeria", "back account" };
            string message = Console.ReadLine();
            bool isSpam = false;
            message = message.ToLower();
            for (int i = 0; i < blackListWord.Length; i++)
            {
                if (message.Contains(blackListWord[i]))
                {
                    isSpam = true;
                }
            }
            if (isSpam == true)
            {
                Console.WriteLine("This message is spam.");
            }
            else
            {
                Console.WriteLine("The message is not spam.");
            }
        }
    }
}
