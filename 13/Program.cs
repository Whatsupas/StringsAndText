using System;
using System.Text;

namespace _13
{
    /*
    Program extract from the URL the protocol, server and resource parts. 
    For example, when http://www.cnn.com/video is passed, the result is:
    [protocol]="http"
    [server]="www.cnn.com"
    [resource]="/video"
    */

    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://productforums.google.com/forum/#!topic/chrome/YdnJRctiq-4";

            StringBuilder protocol = new StringBuilder();
            int index = url.IndexOf("://");
            for (int i = 0; i < index; i++)
            {
                protocol.Append(url[i]);
            }

            StringBuilder server = new StringBuilder();
            int nextIndex = url.IndexOf("/", index + 3);
            for (int i = index + 3; i < nextIndex; i++)
            {
                server.Append(url[i]);
            }

            StringBuilder recource = new StringBuilder();
            int lastIndex = url.LastIndexOf("/");
            for (int i = lastIndex; i < url.Length; i++)
            {
                recource.Append(url[i]);
            }

            Console.WriteLine("[Protocol] = \"{0}\"", protocol);
            Console.WriteLine("[Server]   = \"{0}\"", server);
            Console.WriteLine("[Recource] = \"{0}\"", recource);
        }
    }
}
