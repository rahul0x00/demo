namespace WinFormsApp2
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
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cbcpp = new System.Windows.Forms.CheckBox();
            this.cbJava = new System.Windows.Forms.CheckBox();
            this.cbdotnet = new System.Windows.Forms.CheckBox();
            this.btconcat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(36, 27);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(121, 15);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "Enter Your First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(191, 23);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(287, 23);
            this.tbFirstName.TabIndex = 1;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(36, 91);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(120, 15);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Enter Your Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(191, 88);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(288, 23);
            this.tbLastName.TabIndex = 3;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(41, 169);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(53, 15);
            this.lbMessage.TabIndex = 4;
            this.lbMessage.Text = "Message";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btSubmit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btClear, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 289);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 64);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btSubmit
            // 
            this.btSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSubmit.Location = new System.Drawing.Point(3, 3);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(278, 58);
            this.btSubmit.TabIndex = 0;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btClear.Location = new System.Drawing.Point(287, 3);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(278, 58);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(377, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Gender";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cbcpp
            // 
            this.cbcpp.AutoSize = true;
            this.cbcpp.Location = new System.Drawing.Point(226, 140);
            this.cbcpp.Name = "cbcpp";
            this.cbcpp.Size = new System.Drawing.Size(50, 19);
            this.cbcpp.TabIndex = 7;
            this.cbcpp.Text = "C++";
            this.cbcpp.UseVisualStyleBackColor = true;
            this.cbcpp.CheckedChanged += new System.EventHandler(this.cbcpp_CheckedChanged);
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Location = new System.Drawing.Point(226, 176);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(48, 19);
            this.cbJava.TabIndex = 8;
            this.cbJava.Text = "Java";
            this.cbJava.UseVisualStyleBackColor = true;
            // 
            // cbdotnet
            // 
            this.cbdotnet.AutoSize = true;
            this.cbdotnet.Location = new System.Drawing.Point(226, 211);
            this.cbdotnet.Name = "cbdotnet";
            this.cbdotnet.Size = new System.Drawing.Size(125, 19);
            this.cbdotnet.TabIndex = 9;
            this.cbdotnet.Text = ".Net Programming";
            this.cbdotnet.UseVisualStyleBackColor = true;
            // 
            // btconcat
            // 
            this.btconcat.Location = new System.Drawing.Point(222, 247);
            this.btconcat.Name = "btconcat";
            this.btconcat.Size = new System.Drawing.Size(94, 30);
            this.btconcat.TabIndex = 10;
            this.btconcat.Text = "Concat";
            this.btconcat.UseVisualStyleBackColor = true;
            this.btconcat.Click += new System.EventHandler(this.btconcat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 356);
            this.Controls.Add(this.btconcat);
            this.Controls.Add(this.cbdotnet);
            this.Controls.Add(this.cbJava);
            this.Controls.Add(this.cbcpp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Name = "Form1";
            this.Text = "First Windows Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFirstName;
        private TextBox tbFirstName;
        private Label lbLastName;
        private TextBox tbLastName;
        private Label lbMessage;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btSubmit;
        private Button btClear;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox cbcpp;
        private CheckBox cbJava;
        private CheckBox cbdotnet;
        private Button btconcat;
    }
}