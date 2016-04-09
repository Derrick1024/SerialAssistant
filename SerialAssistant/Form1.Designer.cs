namespace SerialAssistantApplication
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpbCOMSet = new System.Windows.Forms.GroupBox();
            this.COMCheck = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.rbnHEX = new System.Windows.Forms.RadioButton();
            this.rbnChar = new System.Windows.Forms.RadioButton();
            this.btnOpenCOM = new System.Windows.Forms.Button();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCOMPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.gpbDataRev = new System.Windows.Forms.GroupBox();
            this.tbxDataRev = new System.Windows.Forms.TextBox();
            this.gpbDataSend = new System.Windows.Forms.GroupBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tbxDataSend = new System.Windows.Forms.TextBox();
            this.gpbCOMSet.SuspendLayout();
            this.gpbDataRev.SuspendLayout();
            this.gpbDataSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCOMSet
            // 
            resources.ApplyResources(this.gpbCOMSet, "gpbCOMSet");
            this.gpbCOMSet.Controls.Add(this.COMCheck);
            this.gpbCOMSet.Controls.Add(this.About);
            this.gpbCOMSet.Controls.Add(this.rbnHEX);
            this.gpbCOMSet.Controls.Add(this.rbnChar);
            this.gpbCOMSet.Controls.Add(this.btnOpenCOM);
            this.gpbCOMSet.Controls.Add(this.cbbParity);
            this.gpbCOMSet.Controls.Add(this.cbbStopBits);
            this.gpbCOMSet.Controls.Add(this.label4);
            this.gpbCOMSet.Controls.Add(this.cbbDataBits);
            this.gpbCOMSet.Controls.Add(this.label3);
            this.gpbCOMSet.Controls.Add(this.cbbBaudRate);
            this.gpbCOMSet.Controls.Add(this.label2);
            this.gpbCOMSet.Controls.Add(this.cbbCOMPort);
            this.gpbCOMSet.Controls.Add(this.label1);
            this.gpbCOMSet.Controls.Add(this.label5);
            this.gpbCOMSet.Name = "gpbCOMSet";
            this.gpbCOMSet.TabStop = false;
            // 
            // COMCheck
            // 
            resources.ApplyResources(this.COMCheck, "COMCheck");
            this.COMCheck.Name = "COMCheck";
            this.COMCheck.UseVisualStyleBackColor = true;
            this.COMCheck.Click += new System.EventHandler(this.COMCheck_Click);
            // 
            // About
            // 
            resources.ApplyResources(this.About, "About");
            this.About.Name = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // rbnHEX
            // 
            resources.ApplyResources(this.rbnHEX, "rbnHEX");
            this.rbnHEX.Name = "rbnHEX";
            this.rbnHEX.UseVisualStyleBackColor = true;
            // 
            // rbnChar
            // 
            resources.ApplyResources(this.rbnChar, "rbnChar");
            this.rbnChar.Checked = true;
            this.rbnChar.Name = "rbnChar";
            this.rbnChar.TabStop = true;
            this.rbnChar.UseVisualStyleBackColor = true;
            
            // 
            // btnOpenCOM
            // 
            resources.ApplyResources(this.btnOpenCOM, "btnOpenCOM");
            this.btnOpenCOM.Name = "btnOpenCOM";
            this.btnOpenCOM.UseVisualStyleBackColor = true;
            this.btnOpenCOM.Click += new System.EventHandler(this.btnOpenCOM_Click);
            // 
            // cbbParity
            // 
            this.cbbParity.FormattingEnabled = true;
            resources.ApplyResources(this.cbbParity, "cbbParity");
            this.cbbParity.Name = "cbbParity";
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.FormattingEnabled = true;
            resources.ApplyResources(this.cbbStopBits, "cbbStopBits");
            this.cbbStopBits.Name = "cbbStopBits";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cbbDataBits
            // 
            this.cbbDataBits.FormattingEnabled = true;
            resources.ApplyResources(this.cbbDataBits, "cbbDataBits");
            this.cbbDataBits.Name = "cbbDataBits";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.FormattingEnabled = true;
            resources.ApplyResources(this.cbbBaudRate, "cbbBaudRate");
            this.cbbBaudRate.Name = "cbbBaudRate";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbbCOMPort
            // 
            this.cbbCOMPort.FormattingEnabled = true;
            resources.ApplyResources(this.cbbCOMPort, "cbbCOMPort");
            this.cbbCOMPort.Name = "cbbCOMPort";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnClearData
            // 
            resources.ApplyResources(this.btnClearData, "btnClearData");
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // gpbDataRev
            // 
            this.gpbDataRev.Controls.Add(this.tbxDataRev);
            resources.ApplyResources(this.gpbDataRev, "gpbDataRev");
            this.gpbDataRev.Name = "gpbDataRev";
            this.gpbDataRev.TabStop = false;
            // 
            // tbxDataRev
            // 
            resources.ApplyResources(this.tbxDataRev, "tbxDataRev");
            this.tbxDataRev.Name = "tbxDataRev";
            this.tbxDataRev.ReadOnly = true;
            // 
            // gpbDataSend
            // 
            this.gpbDataSend.Controls.Add(this.btnSendData);
            this.gpbDataSend.Controls.Add(this.tbxDataSend);
            this.gpbDataSend.Controls.Add(this.btnClearData);
            resources.ApplyResources(this.gpbDataSend, "gpbDataSend");
            this.gpbDataSend.Name = "gpbDataSend";
            this.gpbDataSend.TabStop = false;
            // 
            // btnSendData
            // 
            resources.ApplyResources(this.btnSendData, "btnSendData");
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tbxDataSend
            // 
            resources.ApplyResources(this.tbxDataSend, "tbxDataSend");
            this.tbxDataSend.Name = "tbxDataSend";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbDataSend);
            this.Controls.Add(this.gpbDataRev);
            this.Controls.Add(this.gpbCOMSet);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbCOMSet.ResumeLayout(false);
            this.gpbCOMSet.PerformLayout();
            this.gpbDataRev.ResumeLayout(false);
            this.gpbDataRev.PerformLayout();
            this.gpbDataSend.ResumeLayout(false);
            this.gpbDataSend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCOMSet;
        private System.Windows.Forms.GroupBox gpbDataRev;
        private System.Windows.Forms.GroupBox gpbDataSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCOMPort;
        private System.Windows.Forms.RadioButton rbnHEX;
        private System.Windows.Forms.RadioButton rbnChar;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnOpenCOM;
        private System.Windows.Forms.TextBox tbxDataRev;
        private System.Windows.Forms.TextBox tbxDataSend;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button COMCheck;
    }
}

