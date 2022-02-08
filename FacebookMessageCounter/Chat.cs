using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookMessageCounter
{
    class Chat
    {
        public List<Participant> Participants { get; set; }
        public List<Message> Messages { get; set; }
        public string title { get; set; }
        public bool is_still_participant{ get; set; }
        public string thread_type { get; set; }
        public string thread_path { get; set; }
        public List<string> magic_words { get; set; }
        public Image image { get; set; }
    }
}
