namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bwt_Back = new System.Windows.Forms.Button();
            this.Bwt_Forward = new System.Windows.Forms.Button();
            this.Bwt_Stop = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.Bwt_Go = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel2.Controls.Add(this.Bwt_Back);
            this.flowLayoutPanel2.Controls.Add(this.Bwt_Forward);
            this.flowLayoutPanel2.Controls.Add(this.Bwt_Stop);
            this.flowLayoutPanel2.Controls.Add(this.txt_url);
            this.flowLayoutPanel2.Controls.Add(this.Bwt_Go);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // Bwt_Back
            // 
            this.Bwt_Back.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Bwt_Back, "Bwt_Back");
            this.Bwt_Back.Name = "Bwt_Back";
            this.Bwt_Back.UseVisualStyleBackColor = false;
            this.Bwt_Back.Click += new System.EventHandler(this.Bwt_Back_Click);
            // 
            // Bwt_Forward
            // 
            this.Bwt_Forward.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Bwt_Forward, "Bwt_Forward");
            this.Bwt_Forward.Name = "Bwt_Forward";
            this.Bwt_Forward.UseVisualStyleBackColor = false;
            this.Bwt_Forward.Click += new System.EventHandler(this.Bwt_Forward_Click);
            // 
            // Bwt_Stop
            // 
            this.Bwt_Stop.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Bwt_Stop, "Bwt_Stop");
            this.Bwt_Stop.Name = "Bwt_Stop";
            this.Bwt_Stop.UseVisualStyleBackColor = false;
            this.Bwt_Stop.Click += new System.EventHandler(this.Bwt_Stop_Click);
            // 
            // txt_url
            // 
            resources.ApplyResources(this.txt_url, "txt_url");
            this.txt_url.Name = "txt_url";
            this.txt_url.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_url_MouseClick);
            this.txt_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_url_KeyPress);
            // 
            // Bwt_Go
            // 
            resources.ApplyResources(this.Bwt_Go, "Bwt_Go");
            this.Bwt_Go.BackColor = System.Drawing.SystemColors.Control;
            this.Bwt_Go.Name = "Bwt_Go";
            this.Bwt_Go.UseVisualStyleBackColor = false;
            this.Bwt_Go.Click += new System.EventHandler(this.Bwt_Go_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Bwt_Back;
        private System.Windows.Forms.Button Bwt_Forward;
        private System.Windows.Forms.Button Bwt_Stop;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button Bwt_Go;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

