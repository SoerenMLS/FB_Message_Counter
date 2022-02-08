using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FacebookMessageCounter
{
    class MessageReader
    {

        // Reads Facebook messages from json file
        // TODO: Do not hardcode filepath and amount of files to iterate over

        public List<Message> ReadMessages()
        {
            Chat chat = new Chat();
            List<Message> Messages = new List<Message>();

            for (int i = 0; i < 45; i++)
            {
                chat = JsonConvert.DeserializeObject<Chat>(File.ReadAllText("PATH TO FACEBOOK MESSAGE FILES")); //Should be something a long the lines of @$"C:\Route\To\Messages_{i+1}.json"
                Messages.AddRange(chat.Messages);
            }
            return Messages;
        }
    }
}
