using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookMessageCounter
{
    class Message
    {
        public string sender_name { get; set; }
        public long timestamp_ms { get; set; }
        public Sticker sticker{ get; set; }
        public List<Image> Photos { get; set; }
        public string content { get; set; }
        public string type { get; set; }
        public bool is_unsent { get; set; }
        public List<Reaction> reactions { get; set; }
    }
}
