using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace RTAManager.src.api
{
    class ConAPI
    {
        public static string getRecord()//レコード取得
        {
            string record;
            NameValueCollection request = new NameValueCollection();
            request.Add("req", "gR");

            record = webRequest(request);
            return record;
        }
        
        public static string getTags()//タグ取得
        {
            string tags;
            NameValueCollection request = new NameValueCollection();
            request.Add("req", "gT");

            tags = webRequest(request);
            return tags;
        }

        public static void addRecord(Record newRecord)//レコード追加
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

            NameValueCollection request = new NameValueCollection();
            request.Add("req", "aR");
            request.Add("score", score);
            request.Add("tag", tag);
            request.Add("name", name);
            request.Add("when", when);
            request.Add("comment", comment);
            
            webRequest(request);
        }

        public static void addTags(string newTag)//タグ追加
        {
            NameValueCollection request = new NameValueCollection();
            request.Add("req", "aT");
            request.Add("tag", newTag);
            
            webRequest(request);
        }
        
        public static string webRequest(NameValueCollection param)   //webへのアクセス
        {
            string url = "https://script.google.com/macros/s/AKfycbzKimFeW3sMUAdzJsxEb9py9bB90ZX9jJe27AehyIqKmj6RALHZbLBFlUbOdyW6ZAEgZg/exec";
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            byte[] resBytes;
            string res;

            try
            {
                resBytes = wc.UploadValues(url, param);
                res = Encoding.UTF8.GetString(resBytes);
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
