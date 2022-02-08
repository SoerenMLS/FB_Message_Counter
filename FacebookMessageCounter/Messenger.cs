using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookMessageCounter
{
    class Messenger
    {
        public Messenger(string name)
        {
            this.Name = name;
        }

        public string Name{ get; set; }
        public int WordCount { get; set; } = 0;

        public override bool Equals(object obj)
        {
            return obj is Messenger messenger &&
                   Name == messenger.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
