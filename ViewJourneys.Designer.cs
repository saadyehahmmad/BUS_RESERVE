
namespace BUS_RESERVE
{
    partial class ViewJourneys
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Jdest = new System.Windows.Forms.ComboBox();
            this.Jsrc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.journeysDGV = new System.Windows.Forms.DataGridView();
            this.Jcap = new System.Windows.Forms.TextBox();
            this.Jno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.journeysDGV)).BeginInit();
            this.SuspendLayout();
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
            this.exit.TabIndex = 8;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(282, 266);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(340, 37);
            this.dateTimePicker.TabIndex = 24;
            // 
            // Jdest
            // 
            this.Jdest.AllowDrop = true;
            this.Jdest.BackColor = System.Drawing.Color.LavenderBlush;
            this.Jdest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jdest.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jdest.FormattingEnabled = true;
            this.Jdest.Items.AddRange(new object[] {
            "Syria",
            "Egybt",
            "Lebanon",
            "Iraq"});
            this.Jdest.Location = new System.Drawing.Point(928, 247);
            this.Jdest.Name = "Jdest";
            this.Jdest.Size = new System.Drawing.Size(351, 45);
            this.Jdest.TabIndex = 22;
            // 
            // Jsrc
            // 
            this.Jsrc.AllowDrop = true;
            this.Jsrc.BackColor = System.Drawing.Color.LavenderBlush;
            this.Jsrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jsrc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jsrc.FormattingEnabled = true;
            this.Jsrc.Items.AddRange(new object[] {
            "Syria",
            "Egybt",
            "Lebanon",
            "Iraq"});
            this.Jsrc.Location = new System.Drawing.Point(928, 176);
            this.Jsrc.Name = "Jsrc";
            this.Jsrc.Size = new System.Drawing.Size(351, 45);
            this.Jsrc.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(281, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(347, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "____________________________________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(282, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "____________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Num Of Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "TakeOfDate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(772, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 38);
            this.label11.TabIndex = 15;
            this.label11.Text = "Source";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(772, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 38);
            this.label10.TabIndex = 16;
            this.label10.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = " Journey NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(350, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 62);
            this.label1.TabIndex = 25;
            this.label1.Text = "View Scheduled Journeys";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.LavenderBlush;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.Location = new System.Drawing.Point(484, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(424, 62);
            this.title.TabIndex = 26;
            this.title.Text = "SDK BUS SYSTEM";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.back.Location = new System.Drawing.Point(1049, 730);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(277, 71);
            this.back.TabIndex = 28;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.reset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.ForeColor = System.Drawing.Color.LavenderBlush;
            this.reset.Location = new System.Drawing.Point(1049, 626);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(277, 71);
            this.reset.TabIndex = 29;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.MidnightBlue;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.update.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.ForeColor = System.Drawing.Color.LavenderBlush;
            this.update.Location = new System.Drawing.Point(1049, 410);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(277, 71);
            this.update.TabIndex = 29;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.LavenderBlush;
            this.delete.Location = new System.Drawing.Point(1049, 518);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(277, 71);
            this.delete.TabIndex = 28;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // journeysDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            this.journeysDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.journeysDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.journeysDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.journeysDGV.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.journeysDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.journeysDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.journeysDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.journeysDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.journeysDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journeysDGV.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.journeysDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.journeysDGV.GridColor = System.Drawing.Color.Gold;
            this.journeysDGV.Location = new System.Drawing.Point(23, 410);
            this.journeysDGV.Name = "journeysDGV";
            this.journeysDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.journeysDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.journeysDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.journeysDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LavenderBlush;
            this.journeysDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.journeysDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.journeysDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.journeysDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            this.journeysDGV.RowTemplate.Height = 30;
            this.journeysDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.journeysDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.journeysDGV.Size = new System.Drawing.Size(986, 391);
            this.journeysDGV.TabIndex = 34;
            this.journeysDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.journeysDGV_CellContentClick);
            // 
            // Jcap
            // 
            this.Jcap.BackColor = System.Drawing.Color.LavenderBlush;
            this.Jcap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Jcap.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jcap.Location = new System.Drawing.Point(292, 333);
            this.Jcap.Name = "Jcap";
            this.Jcap.Size = new System.Drawing.Size(330, 37);
            this.Jcap.TabIndex = 35;
            // 
            // Jno
            // 
            this.Jno.BackColor = System.Drawing.Color.LavenderBlush;
            this.Jno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Jno.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jno.Location = new System.Drawing.Point(299, 179);
            this.Jno.Name = "Jno";
            this.Jno.Size = new System.Drawing.Size(320, 37);
            this.Jno.TabIndex = 36;
            // 
            // ViewJourneys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1338, 813);
            this.Controls.Add(this.Jcap);
            this.Controls.Add(this.Jno);
            this.Controls.Add(this.journeysDGV);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Jdest);
            this.Controls.Add(this.Jsrc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewJourneys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewJourneys";
            this.Load += new System.EventHandler(this.ViewJourneys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.journeysDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox Jdest;
        private System.Windows.Forms.ComboBox Jsrc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView journeysDGV;
        private System.Windows.Forms.TextBox Jcap;
        private System.Windows.Forms.TextBox Jno;
    }
}