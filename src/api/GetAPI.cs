using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace RTAManager
{
    class GetAPI
    {
        public string getAPI()
        {
            string url = "https://script.google.com/macros/s/AKfycbxE-LW8I1jAILXPXrC77dqN6a4Q1ThNb1u5_3SK_TR6sTwF2KvOMoNSG4QltXTl70XPJg/exec";
            WebClient wc = new WebClient();

            return url;
        }
        
    }
}
