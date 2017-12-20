using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace puzzCode
{
    public static class compiler
    {
        public static RichTextBox logText;
        private static void logMsg(string text, Color colorReq)
        {
            Program.mainUi.BeginInvoke((MethodInvoker)delegate
            {
                Color org = logText.SelectionColor;
                logText.SelectionColor = colorReq;
                logText.AppendText(text + "\n");
                logText.SelectionColor = org;
                logText.ScrollToCaret();
            });
        }

        public static bool geneateAsmSource(string srcPath, string outAsmPath)
        {
            Process p = new Process();
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = Path.Combine(Properties.Settings.Default.gwPath, "g++.exe");
            p.StartInfo.WorkingDirectory = Properties.Settings.Default.gwPath;

            p.StartInfo.Arguments = string.Format("-S {0} -masm=intel {2} -o {1}", srcPath, outAsmPath, Properties.Settings.Default.clArg);
            p.Start();

            string errr = p.StandardError.ReadToEnd();
            string oupt = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            if (File.Exists(outAsmPath)) return true;

            Program.mainUi.Invoke((MethodInvoker)delegate ()
            {
                if (logText == null) return;
                logMsg("============= Error =============", Color.Red);
                logMsg(errr + oupt, Color.Red);
            });
            return false;
        }


        public static bool generateExe(string asmPath, string exeOutPath)
        {
            Process p = new Process();
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = Path.Combine(Properties.Settings.Default.gwPath, "g++.exe");
            p.StartInfo.WorkingDirectory = Properties.Settings.Default.gwPath;
            p.StartInfo.Arguments = string.Format("{0} -masm=intel {2} -o {1}", asmPath, exeOutPath, Properties.Settings.Default.linkArg);
            p.Start();

            string errr = p.StandardError.ReadToEnd();
            string oupt = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            if (File.Exists(exeOutPath)) return true;

            Program.mainUi.Invoke((MethodInvoker)delegate ()
            {
                if (logText == null) return;
                logMsg("============= Error =============", Color.Red);
                logMsg(errr + oupt, Color.Red);
            });
            return false;
        }
    }
}
