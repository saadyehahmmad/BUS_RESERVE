
namespace BUS_RESERVE
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Tkt = new System.Windows.Forms.Button();
            this.Canc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Button();
            this.Jour = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tkt
            // 
            this.Tkt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Tkt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tkt.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.Tkt.FlatAppearance.BorderSize = 0;
            this.Tkt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Tkt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Tkt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Tkt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tkt.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tkt.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Tkt.Location = new System.Drawing.Point(674, 694);
            this.Tkt.Name = "Tkt";
            this.Tkt.Size = new System.Drawing.Size(652, 108);
            this.Tkt.TabIndex = 22;
            this.Tkt.Text = "Tickets";
            this.Tkt.UseVisualStyleBackColor = false;
            this.Tkt.Click += new System.EventHandler(this.Tkt_Click);
            // 
            // Canc
            // 
            this.Canc.BackColor = System.Drawing.Color.MidnightBlue;
            this.Canc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Canc.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.Canc.FlatAppearance.BorderSize = 0;
            this.Canc.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Canc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Canc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Canc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Canc.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Canc.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Canc.Location = new System.Drawing.Point(674, 570);
            this.Canc.Name = "Canc";
            this.Canc.Size = new System.Drawing.Size(652, 108);
            this.Canc.TabIndex = 22;
            this.Canc.Text = "Cancellation";
            this.Canc.UseVisualStyleBackColor = false;
            this.Canc.Click += new System.EventHandler(this.Canc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 91);
            this.panel1.TabIndex = 23;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LavenderBlush;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exit.Location = new System.Drawing.Point(1277, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.TabIndex = 25;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.MidnightBlue;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.LavenderBlush;
            this.title.Location = new System.Drawing.Point(469, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(424, 62);
            this.title.TabIndex = 24;
            this.title.Text = "SDK BUS SYSTEM";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(-1, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 62);
            this.label1.TabIndex = 24;
            this.label1.Text = "SDK BUS SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(-1, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 62);
            this.label2.TabIndex = 24;
            this.label2.Text = "SDK BUS SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(-1, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 62);
            this.label3.TabIndex = 24;
            this.label3.Text = "SDK BUS SYSTEM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(-1, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 62);
            this.label4.TabIndex = 24;
            this.label4.Text = "SDK BUS SYSTEM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(-1, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 62);
            this.label5.TabIndex = 24;
            this.label5.Text = "SDK BUS SYSTEM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LavenderBlush;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(-1, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(424, 62);
            this.label6.TabIndex = 24;
            this.label6.Text = "SDK BUS SYSTEM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LavenderBlush;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(-1, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(424, 62);
            this.label7.TabIndex = 24;
            this.label7.Text = "SDK BUS SYSTEM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LavenderBlush;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(-1, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(424, 62);
            this.label8.TabIndex = 24;
            this.label8.Text = "SDK BUS SYSTEM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.MidnightBlue;
            this.Pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pass.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.Pass.FlatAppearance.BorderSize = 0;
            this.Pass.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Pass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Pass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pass.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pass.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Pass.Location = new System.Drawing.Point(12, 570);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(652, 108);
            this.Pass.TabIndex = 26;
            this.Pass.Text = "Passengers";
            this.Pass.UseVisualStyleBackColor = false;
            this.Pass.Click += new System.EventHandler(this.Pass_Click);
            // 
            // Jour
            // 
            this.Jour.BackColor = System.Drawing.Color.MidnightBlue;
            this.Jour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jour.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.Jour.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Jour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Jour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Jour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jour.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Jour.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Jour.Location = new System.Drawing.Point(12, 693);
            this.Jour.Name = "Jour";
            this.Jour.Size = new System.Drawing.Size(652, 108);
            this.Jour.TabIndex = 27;
            this.Jour.Text = "Journeys";
            this.Jour.UseVisualStyleBackColor = false;
            this.Jour.Click += new System.EventHandler(this.Jour_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LavenderBlush;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(-1, 590);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(424, 62);
            this.label9.TabIndex = 24;
            this.label9.Text = "SDK BUS SYSTEM";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LavenderBlush;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(-1, 652);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(424, 62);
            this.label10.TabIndex = 24;
            this.label10.Text = "SDK BUS SYSTEM";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LavenderBlush;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(-1, 714);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(424, 62);
            this.label11.TabIndex = 24;
            this.label11.Text = "SDK BUS SYSTEM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LavenderBlush;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(-1, 776);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(424, 62);
            this.label12.TabIndex = 24;
            this.label12.Text = "SDK BUS SYSTEM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, -95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 854);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1338, 813);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Jour);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Canc);
            this.Controls.Add(this.Tkt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tkt;
        private System.Windows.Forms.Button Canc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Pass;
        private System.Windows.Forms.Button Jour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}