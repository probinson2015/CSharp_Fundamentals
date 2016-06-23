using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        //helper methods are used for the DRY principle and encapsulation. Just use private > return type > input parameters
        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            //return client.DownloadString(url);

            //changing how the library works to demonstrate that if the library changes,
            //then the client will change automatically.
            string content = client.DownloadString(url);
            content += "That's All Folks!!";
            return content;



        }
    }
}
