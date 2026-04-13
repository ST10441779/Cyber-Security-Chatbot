using System;

namespace CyberSecurityChatbot
{
    public class Chatbot
    {
        private string userName;

        public void StartChat()
        {
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("⚠️ Name cannot be empty. Enter your name: ");
                userName = Console.ReadLine();
            }

            UIHelper.TypeText($"\nHello {userName}! Nice to meet you 😊");
            UIHelper.Divider();

            // Play voice AFTER getting name
            AudioPlayer.PlayGreeting(userName);

            UIHelper.TypeText("\nYou can ask me about:");
            UIHelper.TypeText("- Password safety");
            UIHelper.TypeText("- Phishing");
            UIHelper.TypeText("- Safe browsing");
            UIHelper.TypeText("Type 'exit' to quit.");

            ChatLoop();
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    UIHelper.TypeText("⚠️ Please enter something.");
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Bot: ");
                Console.ResetColor();

                if (input.Contains("how are you"))
                {
                    UIHelper.TypeText("I'm functioning perfectly and ready to help you stay safe online!");
                }
                else if (input.Contains("purpose"))
                {
                    UIHelper.TypeText("My purpose is to educate you about cybersecurity and protect you online.");
                }
                else if (input.Contains("password"))
                {
                    UIHelper.TypeText("Use strong passwords with uppercase, lowercase, numbers, and symbols. Never reuse passwords!");
                }
                else if (input.Contains("phishing"))
                {
                    UIHelper.TypeText("Phishing is a scam where attackers trick you into giving personal info. Always verify links and emails.");
                }
                else if (input.Contains("browsing"))
                {
                    UIHelper.TypeText("Always use HTTPS websites and avoid entering sensitive data on public Wi-Fi.");
                }
                else if (input.Contains("what can i ask"))
                {
                    UIHelper.TypeText("You can ask me about passwords, phishing, and safe browsing.");
                }
                else if (input.Contains("exit"))
                {
                    UIHelper.TypeText($"Goodbye {userName}! Stay safe online 🔐");
                    break;
                }
                else
                {
                    UIHelper.TypeText("I didn't quite understand that. Could you rephrase?");
                }
            }
        }
    }
}