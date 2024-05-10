
namespace BUS_RESERVE
{
    partial class Cancellation
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
            this.Tktid = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.cancellationDGV = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.Canceldate = new System.Windows.Forms.DateTimePicker();
            this.p_id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.j_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cancellationDGV)).BeginInit();
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
            this.exit.Location = new System.Drawing.Point(1260, 11);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.TabIndex = 109;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Tktid
            // 
            this.Tktid.AllowDrop = true;
            this.Tktid.BackColor = System.Drawing.Color.LavenderBlush;
            this.Tktid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tktid.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tktid.FormattingEnabled = true;
            this.Tktid.Location = new System.Drawing.Point(917, 139);
            this.Tktid.Name = "Tktid";
            this.Tktid.Size = new System.Drawing.Size(290, 45);
            this.Tktid.TabIndex = 108;
            this.Tktid.SelectionChangeCommitted += new System.EventHandler(this.tId_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(720, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 38);
            this.label11.TabIndex = 94;
            this.label11.Text = "Date";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 38);
            this.label4.TabIndex = 93;
            this.label4.Text = "Journey NO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(49, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 38);
            this.label10.TabIndex = 91;
            this.label10.Text = "Passenger ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(714, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 38);
            this.label3.TabIndex = 87;
            this.label3.Text = "Ticket ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(444, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 62);
            this.label1.TabIndex = 84;
            this.label1.Text = "Cancellation List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.LavenderBlush;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.Location = new System.Drawing.Point(458, -1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(424, 62);
            this.title.TabIndex = 85;
            this.title.Text = "SDK BUS SYSTEM";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancellationDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            this.cancellationDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cancellationDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.cancellationDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.cancellationDGV.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.cancellationDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cancellationDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cancellationDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cancellationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cancellationDGV.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cancellationDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.cancellationDGV.GridColor = System.Drawing.Color.Gold;
            this.cancellationDGV.Location = new System.Drawing.Point(12, 372);
            this.cancellationDGV.Name = "cancellationDGV";
            this.cancellationDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cancellationDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.cancellationDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LavenderBlush;
            this.cancellationDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancellationDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cancellationDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.cancellationDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            this.cancellationDGV.RowTemplate.Height = 30;
            this.cancellationDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cancellationDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cancellationDGV.Size = new System.Drawing.Size(986, 391);
            this.cancellationDGV.TabIndex = 110;
            this.cancellationDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cancellationDGV_CellContentClick);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Cancel.Location = new System.Drawing.Point(1033, 372);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(277, 118);
            this.Cancel.TabIndex = 113;
            this.Cancel.Text = "Cancel ";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.MidnightBlue;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.Color.LavenderBlush;
            this.back.Location = new System.Drawing.Point(1033, 645);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(277, 118);
            this.back.TabIndex = 112;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.ForeColor = System.Drawing.Color.LavenderBlush;
            this.reset.Location = new System.Drawing.Point(1033, 509);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(277, 118);
            this.reset.TabIndex = 114;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Canceldate
            // 
            this.Canceldate.CalendarFont = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Canceldate.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.Canceldate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Canceldate.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Canceldate.Location = new System.Drawing.Point(917, 231);
            this.Canceldate.Name = "Canceldate";
            this.Canceldate.Size = new System.Drawing.Size(290, 37);
            this.Canceldate.TabIndex = 115;
            this.Canceldate.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // p_id
            // 
            this.p_id.BackColor = System.Drawing.Color.LavenderBlush;
            this.p_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p_id.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.p_id.Location = new System.Drawing.Point(308, 149);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(300, 37);
            this.p_id.TabIndex = 116;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(308, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 15);
            this.label13.TabIndex = 117;
            this.label13.Text = "____________________________________________";
            // 
            // j_no
            // 
            this.j_no.BackColor = System.Drawing.Color.LavenderBlush;
            this.j_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.j_no.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.j_no.Location = new System.Drawing.Point(308, 225);
            this.j_no.Name = "j_no";
            this.j_no.Size = new System.Drawing.Size(300, 37);
            this.j_no.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(308, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 15);
            this.label2.TabIndex = 119;
            this.label2.Text = "____________________________________________";
            // 
            // Cancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1322, 774);
            this.Controls.Add(this.j_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Canceldate);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.cancellationDGV);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Tktid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cancellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancellation";
            this.Load += new System.EventHandler(this.Cancellation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancellationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox Tktid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView cancellationDGV;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DateTimePicker Canceldate;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox j_no;
        private System.Windows.Forms.Label label2;
    }
}