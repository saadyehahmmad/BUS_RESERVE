
namespace BUS_RESERVE
{
    partial class AddJourneys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJourneys));
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Jsrc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Jdate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Jdest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jreset = new System.Windows.Forms.Button();
            this.jRecord = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Jcap = new System.Windows.Forms.TextBox();
            this.Jno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.LavenderBlush;
            this.title.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.Location = new System.Drawing.Point(483, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(424, 62);
            this.title.TabIndex = 3;
            this.title.Text = "SDK BUS SYSTEM";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(417, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Record New Journey";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Num Of Seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = " Journey NO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(298, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(427, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(298, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(427, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // Jsrc
            // 
            this.Jsrc.AllowDrop = true;
            this.Jsrc.BackColor = System.Drawing.Color.LavenderBlush;
            this.Jsrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jsrc.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jsrc.FormattingEnabled = true;
            this.Jsrc.Items.AddRange(new object[] {
            "Syria",
            "Egybt",
            "Lebanon",
            "Iraq"});
            this.Jsrc.Location = new System.Drawing.Point(298, 303);
            this.Jsrc.Name = "Jsrc";
            this.Jsrc.Size = new System.Drawing.Size(429, 41);
            this.Jsrc.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(60, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 38);
            this.label10.TabIndex = 5;
            this.label10.Text = "Source";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // Jdate
            // 
            this.Jdate.CalendarFont = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Jdate.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.Jdate.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Jdate.Location = new System.Drawing.Point(298, 456);
            this.Jdate.Name = "Jdate";
            this.Jdate.Size = new System.Drawing.Size(427, 36);
            this.Jdate.TabIndex = 12;
            this.Jdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(60, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 38);
            this.label11.TabIndex = 5;
            this.label11.Text = "Source";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // Jdest
            // 
            this.Jdest.AllowDrop = true;
            this.Jdest.BackColor = System.Drawing.Color.LavenderBlush;
            this.Jdest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jdest.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jdest.FormattingEnabled = true;
            this.Jdest.Items.AddRange(new object[] {
            "Syria",
            "Egybt",
            "Lebanon",
            "Iraq"});
            this.Jdest.Location = new System.Drawing.Point(298, 374);
            this.Jdest.Name = "Jdest";
            this.Jdest.Size = new System.Drawing.Size(429, 41);
            this.Jdest.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "TakeOfDate";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // jreset
            // 
            this.jreset.BackColor = System.Drawing.Color.MidnightBlue;
            this.jreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jreset.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.jreset.FlatAppearance.BorderSize = 0;
            this.jreset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.jreset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.jreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.jreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jreset.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jreset.ForeColor = System.Drawing.Color.LavenderBlush;
            this.jreset.Location = new System.Drawing.Point(367, 706);
            this.jreset.Name = "jreset";
            this.jreset.Size = new System.Drawing.Size(258, 108);
            this.jreset.TabIndex = 13;
            this.jreset.Text = "Reset";
            this.jreset.UseVisualStyleBackColor = false;
            this.jreset.Click += new System.EventHandler(this.jReset_Click);
            // 
            // jRecord
            // 
            this.jRecord.BackColor = System.Drawing.Color.MidnightBlue;
            this.jRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jRecord.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.jRecord.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.jRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.jRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.jRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jRecord.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jRecord.ForeColor = System.Drawing.Color.LavenderBlush;
            this.jRecord.Location = new System.Drawing.Point(1053, 706);
            this.jRecord.Name = "jRecord";
            this.jRecord.Size = new System.Drawing.Size(258, 108);
            this.jRecord.TabIndex = 14;
            this.jRecord.Text = "Record";
            this.jRecord.UseVisualStyleBackColor = false;
            this.jRecord.Click += new System.EventHandler(this.jRecord_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.LavenderBlush;
            this.exit.Location = new System.Drawing.Point(1276, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.TabIndex = 15;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(788, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(788, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(523, 328);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Jcap
            // 
            this.Jcap.BackColor = System.Drawing.Color.LavenderBlush;
            this.Jcap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Jcap.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jcap.Location = new System.Drawing.Point(300, 525);
            this.Jcap.Name = "Jcap";
            this.Jcap.Size = new System.Drawing.Size(422, 37);
            this.Jcap.TabIndex = 17;
            // 
            // Jno
            // 
            this.Jno.BackColor = System.Drawing.Color.LavenderBlush;
            this.Jno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Jno.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jno.Location = new System.Drawing.Point(300, 234);
            this.Jno.Name = "Jno";
            this.Jno.Size = new System.Drawing.Size(422, 37);
            this.Jno.TabIndex = 18;
            this.Jno.TextChanged += new System.EventHandler(this.Jno_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(28, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 108);
            this.button1.TabIndex = 19;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.View_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.MidnightBlue;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.Color.LavenderBlush;
            this.back.Location = new System.Drawing.Point(709, 706);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(258, 108);
            this.back.TabIndex = 34;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddJourneys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1338, 813);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Jcap);
            this.Controls.Add(this.Jno);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.jreset);
            this.Controls.Add(this.jRecord);
            this.Controls.Add(this.Jdate);
            this.Controls.Add(this.Jdest);
            this.Controls.Add(this.Jsrc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddJourneys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TripTpi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Jsrc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Jdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Jdest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button jreset;
        private System.Windows.Forms.Button jRecord;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Jcap;
        private System.Windows.Forms.TextBox Jno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back;
    }
}