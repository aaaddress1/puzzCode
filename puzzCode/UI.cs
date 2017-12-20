using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace puzzCode
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private static void logMsg(string text, Color colorReq)
        {
            Program.mainUi.BeginInvoke((MethodInvoker)delegate
            {
                Color org = Program.mainUi.logBox.SelectionColor;
                Program.mainUi.logBox.SelectionColor = colorReq;
                Program.mainUi.logBox.AppendText(text + "\n");
                Program.mainUi.logBox.SelectionColor = org;
                Program.mainUi.logBox.ScrollToCaret();
                Program.mainUi.Refresh();
            });

        }

        private string demostr =
            " .-.\n" +
            "(o o) boo!\n" +
            "| O \\\n" +
            " \\   \\\n" +
            "  `~~~'\n" +
            "puzzCode v1.0\n" +
            "support for x86 executable file(PE) only.\n" +
            "powered by aaaddress1 @chroot.org";
        public string srcPath = "", asmPath = "", obfAsmPath = "", exePath = "";

        private void refreshUi(object sender, EventArgs e)
        {
            /* i'm too lazy to make a editor for C/C++ :P,
             * and this editor is really useful!!
             * https://github.com/PavelTorgashov/FastColoredTextBox */
            fastColoredTextBox.Language = FastColoredTextBoxNS.Language.CSharp;

            if (srcPath == "")
                srcPath = Path.Combine(Application.StartupPath, "main.cpp");

            if (!File.Exists(srcPath))
                File.WriteAllText(srcPath, Properties.Resources.templateSrc);

            fastColoredTextBox.InsertText(File.ReadAllText(srcPath));

            asmPath = Path.Combine(Path.GetDirectoryName(srcPath), Path.GetFileNameWithoutExtension(srcPath) + ".s");
            obfAsmPath = Path.Combine(Path.GetDirectoryName(srcPath), Path.GetFileNameWithoutExtension(srcPath) + "_obf.s");
            exePath = Path.Combine(Path.GetDirectoryName(srcPath), Path.GetFileNameWithoutExtension(srcPath) + ".exe");
            this.Text = string.Format("puzzCode [{0}] by aaaddres1@chroot.org", new FileInfo(srcPath).Name);

            logBox.Clear();
            logMsg(demostr, Color.Blue);

            compiler.logText = this.logBox;
            obfuscator.logText = this.logBox;

            this.splitContainer.Panel2Collapsed = true;

            if (!new DirectoryInfo(Properties.Settings.Default.gwPath).Exists)
            {
                MessageBox.Show("please choose your MinGW path.");
                (new config()).ShowDialog();
                if (!new DirectoryInfo(Properties.Settings.Default.gwPath).Exists)
                {
                    MessageBox.Show("sorry, MinGW not found :(");
                    Application.Exit();
                }
            }
        }  

        private void config_Click(object sender, EventArgs e)
        {
            new config().ShowDialog();
        }

        private void logPanelBtn_Click(object sender, EventArgs e)
        {
            this.splitContainer.Panel2Collapsed = !this.splitContainer.Panel2Collapsed;
            logPanelBtn.Text = this.splitContainer.Panel2Collapsed ? "+" : "x";
        }

        private void runPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] file = System.IO.File.ReadAllBytes(this.openFileDialog.FileName);
                string injectSrc = Properties.Resources.templateInjectSrc;

                injectSrc = injectSrc.Replace("{EXECUTABLE_FILE_PAYLOAD}", "{0x" + BitConverter.ToString(file).Replace("-", ", 0x") + "}");
                injectSrc = injectSrc.Replace("{EXECUTABLE_FILE_PATH}", this.openFileDialog.FileName);
                fastColoredTextBox.Clear();
                fastColoredTextBox.InsertText(injectSrc);
            }
            
        }

        private void about_Click(object sender, EventArgs e)
        {
            (new aboutUI()).ShowDialog();
        }

        private void run_Click(object sender, EventArgs e)
        {
            if (new FileInfo(exePath).Exists)
                Process.Start(exePath);
            else
                MessageBox.Show("executable file not found!");
        }

        private void compile_Click(object sender, EventArgs e)
        {

            (new System.Threading.Thread(() =>
            {
                this.Invoke((MethodInvoker)delegate () {
                    compile.Enabled = false;
                    logBox.Clear();
                    logMsg(demostr, Color.Blue);
                    this.splitContainer.Panel2Collapsed = false;
                    this.logPanelBtn.Text = "x";
                });
                File.WriteAllText(srcPath, this.fastColoredTextBox.Text);
                File.Delete(exePath);
                File.Delete(asmPath);
                File.Delete(obfAsmPath);

                logMsg(" --- \n", Color.Blue);
                logMsg(string.Format(
                        "[\tInfo\t] current compile info... \n" +
                        " - source: {0}\n" +
                        " - asm path: {1}\n" +
                        " - obfuscated asm path: {2}\n" +
                        " - output exe path: {3}\n", srcPath, asmPath, obfAsmPath, exePath), Color.Blue);

                if (compiler.geneateAsmSource(srcPath, asmPath))
                    logMsg("[\tOK\t] generate assembly code of source code.", Color.Green);
                else
                {
                    logMsg("[\tFail\t] generate assembly code of sorce code failure ...", Color.Red);
                    this.Invoke((MethodInvoker)delegate () { compile.Enabled = true; });
                    return;
                }

                if (obfuscator.obfuscaAsm(asmPath, obfAsmPath))
                    logMsg("[\tOK\t] generate obfuscated assembly code of source code.", Color.Green);
                else
                {
                    logMsg("[\tFail\t] generate obfuscated assembly code of sorce code failure ...", Color.Red);
                    this.Invoke((MethodInvoker)delegate () { compile.Enabled = true; });
                    return;
                }
                if (compiler.generateExe(obfAsmPath, exePath))
                {
                    var arr = System.IO.File.ReadAllBytes(exePath);
                    var size = arr.Length;
                    var md5 = BitConverter.ToString(MD5.Create().ComputeHash(arr)).Replace("-", "");
                    var sha256 = BitConverter.ToString(SHA256.Create().ComputeHash(arr)).Replace("-", "");
                    logMsg("[\tInfo\t] exe size: " + size + " bytes", Color.Blue);
                    logMsg("[\tInfo\t] MD5: " + md5, Color.Blue);
                    logMsg("[\tInfo\t] SHA256: " + sha256, Color.Blue);
                    logMsg("[\tOK\t] generate executable file successfully :)", Color.Green);
                }
                else
                    logMsg("[\tFail\t] generate executable file failure ... o___O", Color.Red);
 
                if (Properties.Settings.Default.clnAftCompile)
                {
                    File.Delete(asmPath);
                    File.Delete(obfAsmPath);
                }
                this.Invoke((MethodInvoker)delegate () { compile.Enabled = true; });
            })
            { IsBackground = true }).Start();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "explorer";
            p.StartInfo.Arguments = Application.StartupPath;
            p.Start();
        }
    }
}
