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
            string score = "", tag = "", name = "", when = "", comment = "";
            
            score = src.StaticObj.AllRecords[0].score;
            for(int i = 0; i< src.StaticObj.AllRecords[0].tag.Count;i++)
            {
                if(i != 0)
                {
                    tag = tag + ",";
                }
                tag = tag + src.StaticObj.AllRecords[0].tag[i];
            }
            name = src.StaticObj.AllRecords[0].name;
            when = src.StaticObj.AllRecords[0].when;
            comment = src.StaticObj.AllRecords[0].comment;

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
