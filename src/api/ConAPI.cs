using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace RTAManager.src.api
{
    class ConAPI
    {
        public static string getRecord()//レコード取得
        {
            string record;
            record = webRequest("https://script.google.com/macros/s/AKfycbxE-LW8I1jAILXPXrC77dqN6a4Q1ThNb1u5_3SK_TR6sTwF2KvOMoNSG4QltXTl70XPJg/exec");

            return record;
        }
        
        public static string getTags()
        {
            string tags;
            tags = webRequest("https://script.google.com/macros/s/AKfycbzWEvBwqBQ0C9NbBTxyFBjxsnViBWGJdUnvl4WhyNxpSnxTsT9igoQ-Wn_QjtYbA_tk/exec");

            return tags;
        }

        public static void addRecord()
        {
            
            string url = "https://script.google.com/macros/s/AKfycbynLE3HAZ2cE5YZCuTjKe4w7fY6QdpGsGiE2mIpI_wY2xwhp1ss1t5PJMTt7fW4KmAlHQ/exec";
            string score = "12:34:56", tag = "RTA,RFA", name = "Bob", when = "1900/01/01/12:34:56", comment = "hi-byAPI";
            string request = "?score=" + score + "&tag=" + tag + "&name=" + name + "&when=" + when + "&comment=" + comment;

            webRequest(url + request);
        }
        
        public static string webRequest(string url)   //webへのアクセス
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string res;

            try
            {
                res = wc.DownloadString(url);
            }
            catch (WebException e)
            {
                Console.Write(e);
                res = null;
            }

            return res;
        }
        
    }
}
