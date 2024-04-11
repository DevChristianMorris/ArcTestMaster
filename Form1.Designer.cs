namespace ArcTest
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxUserMin = new System.Windows.Forms.TextBox();
            this.textBoxUserMax = new System.Windows.Forms.TextBox();
            this.textBoxUserCount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPreviousResults = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titlelabel.AutoSize = true;
            this.titlelabel.BackColor = System.Drawing.Color.Orange;
            this.titlelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titlelabel.ForeColor = System.Drawing.Color.Black;
            this.titlelabel.Location = new System.Drawing.Point(90, 127);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(204, 33);
            this.titlelabel.TabIndex = 2;
            this.titlelabel.Text = "Dice Roller App";
            this.titlelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(63, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click Me To Roll The Dice!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUserMin
            // 
            this.textBoxUserMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUserMin.Location = new System.Drawing.Point(10, 186);
            this.textBoxUserMin.Name = "textBoxUserMin";
            this.textBoxUserMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserMin.TabIndex = 6;
            this.textBoxUserMin.TextChanged += new System.EventHandler(this.textBoxUserMin_TextChanged);
            // 
            // textBoxUserMax
            // 
            this.textBoxUserMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUserMax.Location = new System.Drawing.Point(143, 186);
            this.textBoxUserMax.Name = "textBoxUserMax";
            this.textBoxUserMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserMax.TabIndex = 7;
            // 
            // textBoxUserCount
            // 
            this.textBoxUserCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUserCount.Location = new System.Drawing.Point(276, 186);
            this.textBoxUserCount.Name = "textBoxUserCount";
            this.textBoxUserCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserCount.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ArcTest.Properties.Resources.arclogo;
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lowest Side of Dice";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Highest Side of Dice";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of Dice";
            // 
            // textBoxPreviousResults
            // 
            this.textBoxPreviousResults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPreviousResults.Location = new System.Drawing.Point(114, 292);
            this.textBoxPreviousResults.Multiline = true;
            this.textBoxPreviousResults.Name = "textBoxPreviousResults";
            this.textBoxPreviousResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPreviousResults.Size = new System.Drawing.Size(159, 90);
            this.textBoxPreviousResults.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(118)))), ((int)(((byte)(33)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(129, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Previous Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcTest.Properties.Resources.dicepngbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPreviousResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserCount);
            this.Controls.Add(this.textBoxUserMax);
            this.Controls.Add(this.textBoxUserMin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxUserMin;
        private System.Windows.Forms.TextBox textBoxUserMax;
        private System.Windows.Forms.TextBox textBoxUserCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPreviousResults;
        private System.Windows.Forms.Label label5;
    }
}

