using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookMessageCounter
{
    class MessengerCounter
    {
        public List<Messenger> Messengers { get; set; } = new List<Messenger>();

        public void AddMessenger(string name)
        {
            if (Messengers.Exists(x => x.Name == name))
                Messengers.Find(x => x.Name == name).WordCount++;
            else
            {
                Messenger messenger = new Messenger(name);
                messenger.WordCount++;
                Messengers.Add(messenger);
            }
        }

        public void PrintMessengers()
        {
            SortMessengers();

            foreach(Messenger messenger in Messengers)
            {
                Console.WriteLine($"{messenger.Name} has said the word: {messenger.WordCount} times");
            }
        }

        private void SortMessengers()
        {
            Messengers.OrderByDescending(x => x.WordCount);
        }
    }
}
