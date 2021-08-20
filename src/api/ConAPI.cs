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
        //レコード取得
        public static string getRecord()
        {
            string record;
            NameValueCollection request = new NameValueCollection();
            request.Add("req", "gR");

            record = webRequest(request);
            return record;
        }

        //タグ取得
        public static string getTags()
        {
            string tags;
            NameValueCollection request = new NameValueCollection();
            request.Add("req", "gT");

            tags = webRequest(request);
            return tags;
        }

        //レコード追加
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

            NameValueCollection request = new NameValueCollection();
            request.Add("req", "aR");
            request.Add("score", score);
            request.Add("tag", tag);
            request.Add("name", name);
            request.Add("when", when);
            request.Add("comment", comment);
            
            webRequest(request);
        }

        //タグ追加
        public static void addTags(string newTag)
        {
            NameValueCollection request = new NameValueCollection();
            request.Add("req", "aT");
            request.Add("tag", newTag);
            
            webRequest(request);
        }

        /*webへのアクセス*/
        public static string webRequest(NameValueCollection param)
        {
            string url = "https://script.google.com/macros/s/AKfycbzDWVkXEjSqpJzE-cwBiaG6504uCJyymCGI00rrhjSXsxGA5-imaQOi0J8M9if1CiTi/exec"; //本番環境です
            /*string url = "https://script.google.com/macros/s/AKfycbzKimFeW3sMUAdzJsxEb9py9bB90ZX9jJe27AehyIqKmj6RALHZbLBFlUbOdyW6ZAEgZg/exec";  //テスト環境です*/
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
