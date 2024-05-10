
namespace BUS_RESERVE
{
    partial class waiting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waiting));
            this.background = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.x = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(-3, 63);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1343, 801);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.LavenderBlush;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.Location = new System.Drawing.Point(29, -2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(424, 62);
            this.title.TabIndex = 1;
            this.title.Text = "SDK BUS SYSTEM";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // progress
            // 
            this.progress.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progress.Location = new System.Drawing.Point(-3, 786);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1344, 10);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress.TabIndex = 2;
            this.progress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.MidnightBlue;
            this.x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x.ForeColor = System.Drawing.Color.LavenderBlush;
            this.x.Location = new System.Drawing.Point(1276, 7);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(50, 50);
            this.x.TabIndex = 8;
            this.x.Text = "X";
            this.x.UseVisualStyleBackColor = false;
            this.x.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // waiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1338, 813);
            this.Controls.Add(this.x);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.title);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "waiting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.waiting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Timer timer;
    }
}

