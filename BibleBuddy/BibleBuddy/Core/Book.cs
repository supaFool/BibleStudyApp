using Newtonsoft.Json;
using System;

namespace BibleBuddy.Core
{

    public class BBook
    {
        public string book { get; set; }
        public Chapter[] chapters { get; set; }
    }

    public class Chapter
    {
        public string chapter { get; set; }
        public Vers[] verses { get; set; }
    }

    public class Vers
    {
        public string verse { get; set; }
        public string text { get; set; }
    }

}
