using System;

using System.Collections.Generic;

namespace Insulter
{
    class Program
    {
        static void Main(string[] args)
        {

        List<string> Insults = new List<string> {
            "You look like what morning breath smells like.",
            "If you tried to give me cpr I would probably throw myself back under water",
            "I am not a fan of you",
            "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
            "I'd rather walk than be on the same plane as you",
            "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
            "Do you have to be so...like that?"
            };

            // Randomly generate an insult and try to not see duplicates 
            List<int> Indexes = new List<int> { };
            // While loop to iterate thru the list to make sure there aren't any duplicates when program is run
            // 3 insults will be returned
            while (Indexes.Count < 3)
            {
                int candidate = getRandomInt();
                if (!Indexes.Contains(candidate))
                {
                    Indexes.Add(candidate);
                }
            }

            // for loop that will generate the random the insult. 
            // start at index 0 and increase the index number, but make it random when app is run
            for (int i = 0; i < Indexes.Count; i++)
            {
                int index = Indexes[i];
                Console.WriteLine(Insults[index]);
            }
            int getRandomInt() => new Random().Next(0, Insults.Count - 1);
        }
    }
}