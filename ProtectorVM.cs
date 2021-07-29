using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FUD
{
    public class ProtectorVM
    {
        public void MoveThePointer()
        {
            IntPtr pointer = Marshal.AllocHGlobal(1000000000);
            if ((pointer.ToInt32()) > 1)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
        }
    }
}