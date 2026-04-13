using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            UIHelper.DisplayLogo();

            Chatbot bot = new Chatbot();
            bot.StartChat();

            Console.ReadLine();
        }
    }
}