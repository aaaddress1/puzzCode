using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace puzzCode
{
    partial class config : Form
    {
        public config()
        {
            InitializeComponent();
        }
        
        private void config_Load(object sender, EventArgs e)
        {
            this.gwPathTB.Text = Properties.Settings.Default.gwPath;
            this.lkArgTB.Text = Properties.Settings.Default.linkArg;
            this.clArgTB.Text = Properties.Settings.Default.clArg;
            this.obfusPcntTB.Text = Properties.Settings.Default.obfusPcnt.ToString();
            this.cnfOrgJunk.Checked = Properties.Settings.Default.cnfseCode;
            this.insrtJunkCB.Checked = Properties.Settings.Default.insrtJunk;
            this.clnComplieCB.Checked = Properties.Settings.Default.clnAftCompile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gwPathInput = this.gwPathTB.Text;
            if (!new DirectoryInfo(gwPathInput).Exists)
            {
                MessageBox.Show(string.Format("MinGW path \"{0}\" not found!", gwPathInput));
                return;
            }
            if (!new FileInfo(Path.Combine(gwPathInput, "gcc.exe")).Exists)
            {
                MessageBox.Show(string.Format("MinGW compiler \"{0}\" not found!", Path.Combine(gwPathInput, "gcc.exe")));
                return;
            }
            if (!new FileInfo(Path.Combine(gwPathInput, "ld.exe")).Exists)
            {
                MessageBox.Show(string.Format("MinGW linker \"{0}\" not found!", Path.Combine(gwPathInput, "ld.exe")));
                return;
            }

            int p = 0;
            if (!int.TryParse(this.obfusPcntTB.Text, out p))
            {
                MessageBox.Show(string.Format("Obfuscate % \"{0}\" not found!", this.obfusPcntTB.Text));
                return;
            }
            Properties.Settings.Default.gwPath = this.gwPathTB.Text;
            Properties.Settings.Default.linkArg = this.lkArgTB.Text;
            Properties.Settings.Default.clArg = this.clArgTB.Text;
            Properties.Settings.Default.obfusPcnt = p;
            Properties.Settings.Default.cnfseCode = this.cnfOrgJunk.Checked;
            Properties.Settings.Default.insrtJunk = this.insrtJunkCB.Checked;
            Properties.Settings.Default.clnAftCompile = this.clnComplieCB.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show("save config successfully!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            config_Load(null, null);
        }
    }
}
