using System;
using System.Collections.Generic;

namespace FacebookMessageCounter
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What word do you want to search for?");
            string UserInput = Console.ReadLine().ToLower();

            MessageCounter msgCounter = new MessageCounter();
            MessengerCounter messengerCounter = new MessengerCounter();
            int WordCount = 0;

            MessageReader Reader = new MessageReader();
            List<Message> messages = Reader.ReadMessages();

            foreach (Message message in messages)
            {
                msgCounter.CountMessage(message);
                if (message.content != null)
                {
                    message.content.ToLower();
                    if (message.content.Contains(UserInput))
                    {
                        messengerCounter.AddMessenger(message.sender_name);
                        WordCount++;
                    }
                }
            }

            Console.WriteLine($"Total Messages sent:{messages.Count}\n{UserInput} count: {WordCount}\nTop Messengers:");
            messengerCounter.PrintMessengers();
            Console.WriteLine("\nOverall message statistics:");
            msgCounter.PrintMsgCount();

        }
    }
}
