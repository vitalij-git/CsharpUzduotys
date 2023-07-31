using HTML_uzduotys.Methods;
using System.Net;
using System.Web;
using System.Windows.Forms.dll;




namespace HTML_uzduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string code = "<html>\r\n<head>\r\n  <meta charset=\"UTF-8\">\r\n  <meta name=\"description\" content=\"Free Web tutorials\">\r\n  <meta name=\"keywords\" content=\"HTML,CSS,XML,JavaScript\">\r\n  <meta name=\"author\" content=\"John Doe\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n</head>\r\n<body>\r\n\r\n<p>All meta information goes in the head section...</p>\r\n\r\n</body>\r\n</html>";
           string encoded = BookService.EncodeHtml(code);
           string decoded = BookService.DecodeHtml(encoded);
           //var htmlDocument = new HtmlDocument();

            Console.WriteLine(encoded);
            Console.WriteLine(decoded);
            Console.ReadKey();
        }

       
    }
}