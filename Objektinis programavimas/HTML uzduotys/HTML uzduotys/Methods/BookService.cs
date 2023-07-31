using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HTML_uzduotys.Methods
{
    public static class BookService
    {
        public static string DecodeHtml(string dataSeed)
        {
            return WebUtility.HtmlDecode(dataSeed);
           
        }

        public static string EncodeHtml(string dataSeed)
        { 
            return WebUtility.HtmlEncode(dataSeed);
           
        }
    }
}
