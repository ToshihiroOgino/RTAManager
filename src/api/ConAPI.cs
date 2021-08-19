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
            string request,record;
            request = "?req=gR";

            record = webRequest(request);
            return record;
        }
        
        public static string getTags()
        {
            string request,tags;
            request = "?req=gT";

            tags = webRequest(request);
            return tags;
        }

        public static void addRecord(Record newRecord)
        {
            string score, tag="", name, when, comment;
            
            score = newRecord.score;
            for(int i = 0; i< newRecord.tag.Count;i++)
            {
                if(i != 0)
                {
                    tag = tag + ",";
                }
                tag = tag + newRecord.tag[i];
            }
            name = newRecord.name;
            when = newRecord.when;
            comment = newRecord.comment;

            string request = "?req=aR&score=" + score + "&tag=" + tag + "&name=" + name + "&when=" + when + "&comment=" + comment;
            webRequest(request);
        }

        public static void addTags(string newTag)
        {
            string request = "?req=aT&tag=" + newTag;
            webRequest(request);
        }
        
        public static string webRequest(string req)   //webへのアクセス
        {
            string url = "https://script.google.com/macros/s/AKfycbzKimFeW3sMUAdzJsxEb9py9bB90ZX9jJe27AehyIqKmj6RALHZbLBFlUbOdyW6ZAEgZg/exec";
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string res;

            try
            {
                res = wc.DownloadString(url + req);
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
