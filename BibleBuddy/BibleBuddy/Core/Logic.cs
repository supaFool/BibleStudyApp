using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace BibleBuddy.Core
{
    /// <summary>
    /// Bible Buddy Root Class
    /// </summary>
    public class Logic
    {
        private List<BBook> books;
        public Logic()
        {
            init();
        }

        private void init()
        {
            books = new List<BBook>();
            //string file = @File.ReadAllText("C:\\BibleStudyApp\\BibleBuddy\\BibleBuddy\\Core\\Data\\Bible-kjv-master\\1Chronicles.json");

            foreach (string fileName in Directory.GetFiles("C:\\BibleStudyApp\\BibleBuddy\\BibleBuddy\\Core\\Data\\Bible-kjv-master\\"))
            {
                string file = @File.ReadAllText(fileName);
            BBook data = JsonConvert.DeserializeObject<BBook>(file);
                System.Console.WriteLine($"Adding {data.book}");
                books.Add(data);
            }
{
                // Do something with the file content
            }



        }
    }
}
