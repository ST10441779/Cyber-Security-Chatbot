using System.Speech.Synthesis;
using System.Threading;

namespace CyberSecurityChatbot
{
    public static class AudioPlayer
    {
        public static void PlayGreeting(string userName = "")
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.Volume = 100;
            synth.Rate = -1;

            synth.Speak("Hello!");

            Thread.Sleep(300);

            if (!string.IsNullOrEmpty(userName))
            {
                synth.Speak($"Welcome {userName}.");
            }

            synth.Speak("Welcome to the Cybersecurity Awareness Bot.");
            Thread.Sleep(200);
            synth.Speak("I am here to help you stay safe online.");
        }
    }
}