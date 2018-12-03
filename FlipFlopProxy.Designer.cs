namespace Proxy
{
    partial class FlipFlopProxy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlipFlopProxy));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delHTTP = new System.Windows.Forms.Button();
            this.saveHTTP = new System.Windows.Forms.Button();
            this.LHTTP = new System.Windows.Forms.ListBox();
            this.uHTTP = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delHTTPS = new System.Windows.Forms.Button();
            this.saveHTTPs = new System.Windows.Forms.Button();
            this.LHTTPS = new System.Windows.Forms.ListBox();
            this.uHTTPS = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delFTP = new System.Windows.Forms.Button();
            this.saveFTP = new System.Windows.Forms.Button();
            this.LFTP = new System.Windows.Forms.ListBox();
            this.uFTP = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.delSOCKS = new System.Windows.Forms.Button();
            this.saveSOCKS = new System.Windows.Forms.Button();
            this.LSOCKS = new System.Windows.Forms.ListBox();
            this.uSOCKS = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.showCurrent = new System.Windows.Forms.Label();
            this.resultOfProxy = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.addList = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.ListOfElements = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.addList.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delHTTP);
            this.groupBox1.Controls.Add(this.saveHTTP);
            this.groupBox1.Controls.Add(this.LHTTP);
            this.groupBox1.Controls.Add(this.uHTTP);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // delHTTP
            // 
            resources.ApplyResources(this.delHTTP, "delHTTP");
            this.delHTTP.Name = "delHTTP";
            this.delHTTP.UseVisualStyleBackColor = true;
            this.delHTTP.Click += new System.EventHandler(this.ClearEvent);
            // 
            // saveHTTP
            // 
            resources.ApplyResources(this.saveHTTP, "saveHTTP");
            this.saveHTTP.Name = "saveHTTP";
            this.saveHTTP.UseVisualStyleBackColor = true;
            this.saveHTTP.Click += new System.EventHandler(this.addToHTTP);
            // 
            // LHTTP
            // 
            resources.ApplyResources(this.LHTTP, "LHTTP");
            this.LHTTP.FormattingEnabled = true;
            this.LHTTP.Name = "LHTTP";
            // 
            // uHTTP
            // 
            resources.ApplyResources(this.uHTTP, "uHTTP");
            this.uHTTP.Name = "uHTTP";
            this.uHTTP.UseVisualStyleBackColor = true;
            this.uHTTP.Click += new System.EventHandler(this.AllowTypeOfProxy);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delHTTPS);
            this.groupBox2.Controls.Add(this.saveHTTPs);
            this.groupBox2.Controls.Add(this.LHTTPS);
            this.groupBox2.Controls.Add(this.uHTTPS);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // delHTTPS
            // 
            resources.ApplyResources(this.delHTTPS, "delHTTPS");
            this.delHTTPS.Name = "delHTTPS";
            this.delHTTPS.UseVisualStyleBackColor = true;
            this.delHTTPS.Click += new System.EventHandler(this.ClearEvent);
            // 
            // saveHTTPs
            // 
            resources.ApplyResources(this.saveHTTPs, "saveHTTPs");
            this.saveHTTPs.Name = "saveHTTPs";
            this.saveHTTPs.UseVisualStyleBackColor = true;
            this.saveHTTPs.Click += new System.EventHandler(this.addToHTTPs);
            // 
            // LHTTPS
            // 
            resources.ApplyResources(this.LHTTPS, "LHTTPS");
            this.LHTTPS.FormattingEnabled = true;
            this.LHTTPS.Name = "LHTTPS";
            // 
            // uHTTPS
            // 
            resources.ApplyResources(this.uHTTPS, "uHTTPS");
            this.uHTTPS.Name = "uHTTPS";
            this.uHTTPS.UseVisualStyleBackColor = true;
            this.uHTTPS.Click += new System.EventHandler(this.AllowTypeOfProxy);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delFTP);
            this.groupBox3.Controls.Add(this.saveFTP);
            this.groupBox3.Controls.Add(this.LFTP);
            this.groupBox3.Controls.Add(this.uFTP);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // delFTP
            // 
            resources.ApplyResources(this.delFTP, "delFTP");
            this.delFTP.Name = "delFTP";
            this.delFTP.UseVisualStyleBackColor = true;
            this.delFTP.Click += new System.EventHandler(this.ClearEvent);
            // 
            // saveFTP
            // 
            resources.ApplyResources(this.saveFTP, "saveFTP");
            this.saveFTP.Name = "saveFTP";
            this.saveFTP.UseVisualStyleBackColor = true;
            this.saveFTP.Click += new System.EventHandler(this.addToFTP);
            // 
            // LFTP
            // 
            resources.ApplyResources(this.LFTP, "LFTP");
            this.LFTP.FormattingEnabled = true;
            this.LFTP.Name = "LFTP";
            // 
            // uFTP
            // 
            resources.ApplyResources(this.uFTP, "uFTP");
            this.uFTP.Name = "uFTP";
            this.uFTP.UseVisualStyleBackColor = true;
            this.uFTP.Click += new System.EventHandler(this.AllowTypeOfProxy);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.delSOCKS);
            this.groupBox4.Controls.Add(this.saveSOCKS);
            this.groupBox4.Controls.Add(this.LSOCKS);
            this.groupBox4.Controls.Add(this.uSOCKS);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // delSOCKS
            // 
            resources.ApplyResources(this.delSOCKS, "delSOCKS");
            this.delSOCKS.Name = "delSOCKS";
            this.delSOCKS.UseVisualStyleBackColor = true;
            this.delSOCKS.Click += new System.EventHandler(this.ClearEvent);
            // 
            // saveSOCKS
            // 
            resources.ApplyResources(this.saveSOCKS, "saveSOCKS");
            this.saveSOCKS.Name = "saveSOCKS";
            this.saveSOCKS.UseVisualStyleBackColor = true;
            this.saveSOCKS.Click += new System.EventHandler(this.addToSOCKS);
            // 
            // LSOCKS
            // 
            resources.ApplyResources(this.LSOCKS, "LSOCKS");
            this.LSOCKS.FormattingEnabled = true;
            this.LSOCKS.Name = "LSOCKS";
            // 
            // uSOCKS
            // 
            resources.ApplyResources(this.uSOCKS, "uSOCKS");
            this.uSOCKS.Name = "uSOCKS";
            this.uSOCKS.UseVisualStyleBackColor = true;
            this.uSOCKS.Click += new System.EventHandler(this.AllowTypeOfProxy);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.showCurrent);
            this.flowLayoutPanel2.Controls.Add(this.resultOfProxy);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // showCurrent
            // 
            resources.ApplyResources(this.showCurrent, "showCurrent");
            this.showCurrent.Name = "showCurrent";
            // 
            // resultOfProxy
            // 
            resources.ApplyResources(this.resultOfProxy, "resultOfProxy");
            this.resultOfProxy.Name = "resultOfProxy";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.TimeValue);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.applyBtn);
            this.flowLayoutPanel3.Controls.Add(this.runBtn);
            this.flowLayoutPanel3.Controls.Add(this.changeBtn);
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TimeValue
            // 
            resources.ApplyResources(this.TimeValue, "TimeValue");
            this.TimeValue.Name = "TimeValue";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // applyBtn
            // 
            resources.ApplyResources(this.applyBtn, "applyBtn");
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.saveTime);
            // 
            // runBtn
            // 
            resources.ApplyResources(this.runBtn, "runBtn");
            this.runBtn.Name = "runBtn";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.RunEvent);
            // 
            // changeBtn
            // 
            resources.ApplyResources(this.changeBtn, "changeBtn");
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.ChangeManually);
            // 
            // addList
            // 
            resources.ApplyResources(this.addList, "addList");
            this.addList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addList.Controls.Add(this.addBtn);
            this.addList.Controls.Add(this.okBtn);
            this.addList.Controls.Add(this.ListOfElements);
            this.addList.Name = "addList";
            this.addList.TabStop = true;
            // 
            // addBtn
            // 
            resources.ApplyResources(this.addBtn, "addBtn");
            this.addBtn.Name = "addBtn";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.saveList);
            // 
            // okBtn
            // 
            resources.ApplyResources(this.okBtn, "okBtn");
            this.okBtn.Name = "okBtn";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okEvent);
            // 
            // ListOfElements
            // 
            resources.ApplyResources(this.ListOfElements, "ListOfElements");
            this.ListOfElements.Name = "ListOfElements";
            // 
            // GlobalProxy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.addList);
            this.Name = "Flip-flop Proxy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnApplicationExit);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.addList.ResumeLayout(false);
            this.addList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox LHTTP;
        private System.Windows.Forms.CheckBox uHTTP;
        private System.Windows.Forms.ListBox LHTTPS;
        private System.Windows.Forms.CheckBox uHTTPS;
        private System.Windows.Forms.ListBox LFTP;
        private System.Windows.Forms.CheckBox uFTP;
        private System.Windows.Forms.ListBox LSOCKS;
        private System.Windows.Forms.CheckBox uSOCKS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showCurrent;
        private System.Windows.Forms.Label resultOfProxy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button saveHTTP;
        private System.Windows.Forms.Button saveHTTPs;
        private System.Windows.Forms.Button saveFTP;
        private System.Windows.Forms.Button saveSOCKS;
        private System.Windows.Forms.Panel addList;
        private System.Windows.Forms.RichTextBox ListOfElements;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button delHTTP;
        private System.Windows.Forms.Button delHTTPS;
        private System.Windows.Forms.Button delFTP;
        private System.Windows.Forms.Button delSOCKS;
    }
}

