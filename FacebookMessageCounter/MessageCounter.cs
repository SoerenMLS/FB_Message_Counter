using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookMessageCounter
{
    class MessageCounter
    {
        private List<Messenger> messengers = new List<Messenger>();

        public void CountMessage(Message message)
        {
            if(messengers.Exists(x => x.Name == message.sender_name))
            {
                messengers.Find(x => x.Name == message.sender_name).WordCount++;
            }
            else
            {
                Messenger messenger = new Messenger(message.sender_name);
                messenger.WordCount++;
                messengers.Add(messenger);
            }
        }

        public void PrintMsgCount()
        {
            List<Messenger> SortedMessengers = messengers.OrderBy(x => x.WordCount).ToList();
            foreach (Messenger messenger in SortedMessengers)
            {
                Console.WriteLine($"{messenger.Name} has sent {messenger.WordCount} messages");
            }
        }

    }
}
