using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Brain_Talk
{
    class Brain
    {
        public static void Counting()
        {
            for (int i = 0; i <= 200; i += 10)
            {
                if (i % 3 == 0)
                {
                    SpeechSynthesizer talk = new SpeechSynthesizer();
                    string toStr = i.ToString();
                    Console.WriteLine(i);
                    talk.Speak(toStr + " is divisible by 3");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
