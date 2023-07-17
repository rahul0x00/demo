namespace WinFormsListBoxDemo
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
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.lbRight = new System.Windows.Forms.ListBox();
            this.btRight = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLeft
            // 
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.ItemHeight = 15;
            this.lbLeft.Items.AddRange(new object[] {
            "NFSU",
            "IIT Gandhinagar",
            "NIT Surat",
            "IIT Bombay"});
            this.lbLeft.Location = new System.Drawing.Point(91, 70);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(121, 169);
            this.lbLeft.TabIndex = 0;
            // 
            // lbRight
            // 
            this.lbRight.FormattingEnabled = true;
            this.lbRight.ItemHeight = 15;
            this.lbRight.Location = new System.Drawing.Point(455, 74);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(125, 154);
            this.lbRight.TabIndex = 1;
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(310, 103);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(72, 42);
            this.btRight.TabIndex = 2;
            this.btRight.Text = ">>";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(310, 186);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(72, 42);
            this.btLeft.TabIndex = 3;
            this.btLeft.Text = "<<";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbLeft;
        private ListBox lbRight;
        private Button btRight;
        private Button btLeft;
    }
}