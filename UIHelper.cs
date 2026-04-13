using System;
using System.Threading;

namespace CyberSecurityChatbot
{
    public static class UIHelper
    {
        public static void DisplayLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("===============================================");
            Console.WriteLine("        CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("===============================================");

            Console.WriteLine(@"
           [ 🔒 SECURE 🔒 ]
          -----------------
         |   0       0     |
         |       ^         |
         |     \___/       |
          -----------------
            ");

            Console.ResetColor();
        }

        public static void Divider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===============================================");
            Console.ResetColor();
        }

        public static void TypeText(string message, int delay = 20)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}