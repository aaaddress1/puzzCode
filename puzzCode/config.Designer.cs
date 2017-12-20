namespace puzzCode
{
    partial class config
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gwPathTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clArgTB = new System.Windows.Forms.TextBox();
            this.lkArgTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.obfusPcntTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insrtJunkCB = new System.Windows.Forms.CheckBox();
            this.cnfOrgJunk = new System.Windows.Forms.CheckBox();
            this.clnComplieCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MinGW Path";
            // 
            // gwPathTB
            // 
            this.gwPathTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gwPathTB.Location = new System.Drawing.Point(156, 14);
            this.gwPathTB.Name = "gwPathTB";
            this.gwPathTB.Size = new System.Drawing.Size(508, 15);
            this.gwPathTB.TabIndex = 2;
            this.gwPathTB.Text = "C:\\MinGW\\bin";
            this.gwPathTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(592, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Compiler Argument";
            // 
            // clArgTB
            // 
            this.clArgTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clArgTB.Location = new System.Drawing.Point(156, 35);
            this.clArgTB.Name = "clArgTB";
            this.clArgTB.Size = new System.Drawing.Size(508, 15);
            this.clArgTB.TabIndex = 6;
            this.clArgTB.Text = "-Os -fdata-sections -ffunction-sections -O3 -fno-rtti -fno-threadsafe-statics -fn" +
    "o-exceptions";
            this.clArgTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lkArgTB
            // 
            this.lkArgTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lkArgTB.Location = new System.Drawing.Point(156, 56);
            this.lkArgTB.Name = "lkArgTB";
            this.lkArgTB.Size = new System.Drawing.Size(508, 15);
            this.lkArgTB.TabIndex = 8;
            this.lkArgTB.Text = "-mwindows -static -Wl,--strip-all";
            this.lkArgTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Linker Argument";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(514, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "&Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // obfusPcntTB
            // 
            this.obfusPcntTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.obfusPcntTB.Location = new System.Drawing.Point(630, 77);
            this.obfusPcntTB.Name = "obfusPcntTB";
            this.obfusPcntTB.Size = new System.Drawing.Size(34, 15);
            this.obfusPcntTB.TabIndex = 11;
            this.obfusPcntTB.Text = "50";
            this.obfusPcntTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Obfuscate % (0 ~ 100)";
            // 
            // insrtJunkCB
            // 
            this.insrtJunkCB.AutoSize = true;
            this.insrtJunkCB.Location = new System.Drawing.Point(14, 109);
            this.insrtJunkCB.Name = "insrtJunkCB";
            this.insrtJunkCB.Size = new System.Drawing.Size(107, 16);
            this.insrtJunkCB.TabIndex = 12;
            this.insrtJunkCB.Text = "Insert Junk Codes";
            this.insrtJunkCB.UseVisualStyleBackColor = true;
            // 
            // cnfOrgJunk
            // 
            this.cnfOrgJunk.AutoSize = true;
            this.cnfOrgJunk.Location = new System.Drawing.Point(14, 131);
            this.cnfOrgJunk.Name = "cnfOrgJunk";
            this.cnfOrgJunk.Size = new System.Drawing.Size(133, 16);
            this.cnfOrgJunk.TabIndex = 13;
            this.cnfOrgJunk.Text = "Confuse Orginal Codes";
            this.cnfOrgJunk.UseVisualStyleBackColor = true;
            // 
            // clnComplieCB
            // 
            this.clnComplieCB.AutoSize = true;
            this.clnComplieCB.Location = new System.Drawing.Point(14, 153);
            this.clnComplieCB.Name = "clnComplieCB";
            this.clnComplieCB.Size = new System.Drawing.Size(121, 16);
            this.clnComplieCB.TabIndex = 14;
            this.clnComplieCB.Text = "Clean After Compile";
            this.clnComplieCB.UseVisualStyleBackColor = true;
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 180);
            this.Controls.Add(this.clnComplieCB);
            this.Controls.Add(this.cnfOrgJunk);
            this.Controls.Add(this.insrtJunkCB);
            this.Controls.Add(this.obfusPcntTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lkArgTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clArgTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gwPathTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "config";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gwPathTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clArgTB;
        private System.Windows.Forms.TextBox lkArgTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox obfusPcntTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox insrtJunkCB;
        private System.Windows.Forms.CheckBox cnfOrgJunk;
        private System.Windows.Forms.CheckBox clnComplieCB;
    }
}
