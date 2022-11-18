using BibleBuddy.Core.BibleVersions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace BibleBuddy.Core
{
    /// <summary>
    /// Bible Buddy Root Class
    /// </summary>
    public class Logic
    {
        private BibleBuddyForm _form;
        public Logic(BibleBuddyForm form)
        {
            _form = form;
            init();
        }

        private void init()
        {
            Thread thr = new Thread(new ThreadStart(LoadKJV));
            thr.Start();

        }

        private void LoadKJV()
        {
            
            KJV.KingJamesVersion = new List<BBook>();

            foreach (string fileName in Directory.GetFiles("C:\\BibleStudyApp\\BibleBuddy\\BibleBuddy\\Core\\Data\\Bible-kjv-master\\"))
            {
                string file = @File.ReadAllText(fileName);
                BBook data = JsonConvert.DeserializeObject<BBook>(file);
                System.Console.WriteLine($"Adding {data.book}");
                KJV.KingJamesVersion.Add(data);
            }
            System.Console.WriteLine($"Loades {KJV.KingJamesVersion.Count} books.");
        }
    }
}
