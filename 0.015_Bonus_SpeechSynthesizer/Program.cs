using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._015_Bonus_SpeechSynthesizer
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            talkingConsole.Speak("What is your name?");
        }
    }
}
