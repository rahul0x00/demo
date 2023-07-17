namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFname = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btSubmitt = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCPP = new System.Windows.Forms.CheckBox();
            this.cbJava = new System.Windows.Forms.CheckBox();
            this.cbDotnet = new System.Windows.Forms.CheckBox();
            this.btSubject = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.Location = new System.Drawing.Point(50, 52);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(121, 15);
            this.lbFname.TabIndex = 0;
            this.lbFname.Text = "Enter Your First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(54, 95);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(120, 15);
            this.lbLastName.TabIndex = 1;
            this.lbLastName.Text = "Enter Your Last Name";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(55, 159);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(53, 15);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "Message";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(212, 43);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(185, 23);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(213, 95);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(187, 23);
            this.tbLastName.TabIndex = 4;
            // 
            // btSubmitt
            // 
            this.btSubmitt.Location = new System.Drawing.Point(79, 220);
            this.btSubmitt.Name = "btSubmitt";
            this.btSubmitt.Size = new System.Drawing.Size(154, 39);
            this.btSubmitt.TabIndex = 5;
            this.btSubmitt.Text = "Submitt";
            this.btSubmitt.UseVisualStyleBackColor = true;
            this.btSubmitt.Click += new System.EventHandler(this.btSubmitt_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(271, 214);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(148, 46);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(17, 33);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 19);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(17, 58);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 19);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Location = new System.Drawing.Point(483, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Gen.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Your Preffered Programming Language";
            // 
            // cbCPP
            // 
            this.cbCPP.AutoSize = true;
            this.cbCPP.Location = new System.Drawing.Point(500, 199);
            this.cbCPP.Name = "cbCPP";
            this.cbCPP.Size = new System.Drawing.Size(50, 19);
            this.cbCPP.TabIndex = 11;
            this.cbCPP.Text = "C++";
            this.cbCPP.UseVisualStyleBackColor = true;
            this.cbCPP.CheckedChanged += new System.EventHandler(this.cbCPP_CheckedChanged);
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Location = new System.Drawing.Point(500, 233);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(48, 19);
            this.cbJava.TabIndex = 12;
            this.cbJava.Text = "Java";
            this.cbJava.UseVisualStyleBackColor = true;
            // 
            // cbDotnet
            // 
            this.cbDotnet.AutoSize = true;
            this.cbDotnet.Location = new System.Drawing.Point(501, 269);
            this.cbDotnet.Name = "cbDotnet";
            this.cbDotnet.Size = new System.Drawing.Size(125, 19);
            this.cbDotnet.TabIndex = 13;
            this.cbDotnet.Text = ".Net Programming";
            this.cbDotnet.UseVisualStyleBackColor = true;
            // 
            // btSubject
            // 
            this.btSubject.Location = new System.Drawing.Point(489, 308);
            this.btSubject.Name = "btSubject";
            this.btSubject.Size = new System.Drawing.Size(117, 33);
            this.btSubject.TabIndex = 14;
            this.btSubject.Text = "Subject Choice";
            this.btSubject.UseVisualStyleBackColor = true;
            this.btSubject.Click += new System.EventHandler(this.btSubject_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(74, 304);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 137);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Open";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btSubject);
            this.Controls.Add(this.cbDotnet);
            this.Controls.Add(this.cbJava);
            this.Controls.Add(this.cbCPP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSubmitt);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "My First Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFname;
        private Label lbLastName;
        private Label lbMessage;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Button btSubmitt;
        private Button btClear;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox cbCPP;
        private CheckBox cbJava;
        private CheckBox cbDotnet;
        private Button btSubject;
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}