
namespace BUS_RESERVE
{
    partial class AddPassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassenger));
            this.Reset = new System.Windows.Forms.Button();
            this.RecordPassBtn = new System.Windows.Forms.Button();
            this.pass_nat_ = new System.Windows.Forms.ComboBox();
            this.pass_gend_ = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PassId = new System.Windows.Forms.TextBox();
            this.Customer_Name = new System.Windows.Forms.Label();
            this.Customer_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.PasssName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Passport_NO = new System.Windows.Forms.Label();
            this.ADDS = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PassAd = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PassPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.x = new System.Windows.Forms.Button();
            this.pass_id_ = new System.Windows.Forms.TextBox();
            this.pass_phone_ = new System.Windows.Forms.TextBox();
            this.passport_no_ = new System.Windows.Forms.TextBox();
            this.pass_name_ = new System.Windows.Forms.TextBox();
            this.address_ = new System.Windows.Forms.TextBox();
            this.view_pass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reset.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Reset.Location = new System.Drawing.Point(694, 712);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(281, 92);
            this.Reset.TabIndex = 30;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // RecordPassBtn
            // 
            this.RecordPassBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.RecordPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordPassBtn.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.RecordPassBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.RecordPassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.RecordPassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.RecordPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordPassBtn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RecordPassBtn.ForeColor = System.Drawing.Color.LavenderBlush;
            this.RecordPassBtn.Location = new System.Drawing.Point(1033, 713);
            this.RecordPassBtn.Name = "RecordPassBtn";
            this.RecordPassBtn.Size = new System.Drawing.Size(281, 91);
            this.RecordPassBtn.TabIndex = 31;
            this.RecordPassBtn.Text = "Record";
            this.RecordPassBtn.UseVisualStyleBackColor = false;
            this.RecordPassBtn.Click += new System.EventHandler(this.RecordPassBtn_Click);
            // 
            // pass_nat_
            // 
            this.pass_nat_.AllowDrop = true;
            this.pass_nat_.BackColor = System.Drawing.Color.LavenderBlush;
            this.pass_nat_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pass_nat_.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_nat_.FormattingEnabled = true;
            this.pass_nat_.Items.AddRange(new object[] {
            " Egypt",
            " Algeria",
            " Sudan",
            " Iraq",
            " Morocco",
            " Saudi Arabia",
            " Yemen",
            " Syria",
            " Tunisia",
            " Jordan",
            " United Arab Emirates",
            " Lebanon",
            " Libya",
            " Palestine",
            " Oman",
            " Mauritania",
            " Kuwait\t",
            " Qatar\t",
            " Bahrain\t",
            " Djibouti",
            " Comoros"});
            this.pass_nat_.Location = new System.Drawing.Point(222, 556);
            this.pass_nat_.Name = "pass_nat_";
            this.pass_nat_.Size = new System.Drawing.Size(190, 45);
            this.pass_nat_.TabIndex = 28;
            this.pass_nat_.SelectedIndexChanged += new System.EventHandler(this.PassNat_SelectedIndexChanged);
            // 
            // pass_gend_
            // 
            this.pass_gend_.AllowDrop = true;
            this.pass_gend_.BackColor = System.Drawing.Color.LavenderBlush;
            this.pass_gend_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pass_gend_.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_gend_.FormattingEnabled = true;
            this.pass_gend_.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.pass_gend_.Location = new System.Drawing.Point(585, 556);
            this.pass_gend_.Name = "pass_gend_";
            this.pass_gend_.Size = new System.Drawing.Size(211, 45);
            this.pass_gend_.TabIndex = 27;
            this.pass_gend_.SelectedIndexChanged += new System.EventHandler(this.PassGend_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(369, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(427, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // PassId
            // 
            this.PassId.BackColor = System.Drawing.Color.LavenderBlush;
            this.PassId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassId.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassId.Location = new System.Drawing.Point(376, 273);
            this.PassId.Name = "PassId";
            this.PassId.Size = new System.Drawing.Size(422, 37);
            this.PassId.TabIndex = 24;
            this.PassId.TextChanged += new System.EventHandler(this.PassId_TextChanged);
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSize = true;
            this.Customer_Name.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Customer_Name.Location = new System.Drawing.Point(41, 346);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(269, 38);
            this.Customer_Name.TabIndex = 20;
            this.Customer_Name.Text = "Customer Name";
            // 
            // Customer_ID
            // 
            this.Customer_ID.AutoSize = true;
            this.Customer_ID.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Customer_ID.Location = new System.Drawing.Point(41, 273);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(205, 38);
            this.Customer_ID.TabIndex = 19;
            this.Customer_ID.Text = "Customer ID";
            this.Customer_ID.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(398, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 62);
            this.label1.TabIndex = 17;
            this.label1.Text = "Record New Passenger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.LavenderBlush;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Century Gothic", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.Location = new System.Drawing.Point(464, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(424, 62);
            this.title.TabIndex = 16;
            this.title.Text = "SDK BUS SYSTEM";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasssName
            // 
            this.PasssName.BackColor = System.Drawing.Color.LavenderBlush;
            this.PasssName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasssName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasssName.Location = new System.Drawing.Point(376, 342);
            this.PasssName.Name = "PasssName";
            this.PasssName.Size = new System.Drawing.Size(422, 37);
            this.PasssName.TabIndex = 24;
            this.PasssName.TextChanged += new System.EventHandler(this.PasssName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(369, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(427, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // Passport_NO
            // 
            this.Passport_NO.AutoSize = true;
            this.Passport_NO.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Passport_NO.Location = new System.Drawing.Point(41, 409);
            this.Passport_NO.Name = "Passport_NO";
            this.Passport_NO.Size = new System.Drawing.Size(205, 38);
            this.Passport_NO.TabIndex = 19;
            this.Passport_NO.Text = "Passport NO";
            this.Passport_NO.Click += new System.EventHandler(this.label3_Click);
            // 
            // ADDS
            // 
            this.ADDS.AutoSize = true;
            this.ADDS.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADDS.Location = new System.Drawing.Point(41, 478);
            this.ADDS.Name = "ADDS";
            this.ADDS.Size = new System.Drawing.Size(141, 38);
            this.ADDS.TabIndex = 20;
            this.ADDS.Text = "Address";
            // 
            // Passport
            // 
            this.Passport.BackColor = System.Drawing.Color.LavenderBlush;
            this.Passport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passport.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passport.Location = new System.Drawing.Point(376, 405);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(422, 37);
            this.Passport.TabIndex = 24;
            this.Passport.TextChanged += new System.EventHandler(this.Passport_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(369, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(427, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // PassAd
            // 
            this.PassAd.BackColor = System.Drawing.Color.LavenderBlush;
            this.PassAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassAd.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassAd.Location = new System.Drawing.Point(376, 474);
            this.PassAd.Name = "PassAd";
            this.PassAd.Size = new System.Drawing.Size(422, 37);
            this.PassAd.TabIndex = 24;
            this.PassAd.TextChanged += new System.EventHandler(this.PassAd_TextChanged);
            // 
            // AdressBox
            // 
            this.AdressBox.AutoSize = true;
            this.AdressBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.AdressBox.Location = new System.Drawing.Point(369, 498);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(427, 15);
            this.AdressBox.TabIndex = 26;
            this.AdressBox.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 38);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nationality";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(435, 557);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 38);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(41, 632);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 38);
            this.label12.TabIndex = 19;
            this.label12.Text = "Phone";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // PassPhone
            // 
            this.PassPhone.BackColor = System.Drawing.Color.LavenderBlush;
            this.PassPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassPhone.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassPhone.Location = new System.Drawing.Point(376, 632);
            this.PassPhone.Name = "PassPhone";
            this.PassPhone.Size = new System.Drawing.Size(422, 37);
            this.PassPhone.TabIndex = 24;
            this.PassPhone.TextChanged += new System.EventHandler(this.PassPhone_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(369, 656);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(427, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "_________________________________________________________________________________" +
    "___";
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
            this.button1.Location = new System.Drawing.Point(354, 712);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 91);
            this.button1.TabIndex = 33;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(881, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(391, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(881, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.MidnightBlue;
            this.x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x.ForeColor = System.Drawing.Color.LavenderBlush;
            this.x.Location = new System.Drawing.Point(1276, 12);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(50, 50);
            this.x.TabIndex = 35;
            this.x.Text = "X";
            this.x.UseVisualStyleBackColor = false;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // pass_id_
            // 
            this.pass_id_.BackColor = System.Drawing.Color.LavenderBlush;
            this.pass_id_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_id_.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_id_.Location = new System.Drawing.Point(376, 272);
            this.pass_id_.Name = "pass_id_";
            this.pass_id_.Size = new System.Drawing.Size(422, 37);
            this.pass_id_.TabIndex = 24;
            this.pass_id_.TextChanged += new System.EventHandler(this.PassId_TextChanged);
            // 
            // pass_phone_
            // 
            this.pass_phone_.BackColor = System.Drawing.Color.LavenderBlush;
            this.pass_phone_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_phone_.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_phone_.Location = new System.Drawing.Point(376, 631);
            this.pass_phone_.Name = "pass_phone_";
            this.pass_phone_.Size = new System.Drawing.Size(422, 37);
            this.pass_phone_.TabIndex = 24;
            this.pass_phone_.TextChanged += new System.EventHandler(this.PassPhone_TextChanged);
            // 
            // passport_no_
            // 
            this.passport_no_.BackColor = System.Drawing.Color.LavenderBlush;
            this.passport_no_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passport_no_.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passport_no_.Location = new System.Drawing.Point(376, 404);
            this.passport_no_.Name = "passport_no_";
            this.passport_no_.Size = new System.Drawing.Size(422, 37);
            this.passport_no_.TabIndex = 24;
            this.passport_no_.TextChanged += new System.EventHandler(this.Passport_TextChanged);
            // 
            // pass_name_
            // 
            this.pass_name_.BackColor = System.Drawing.Color.LavenderBlush;
            this.pass_name_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_name_.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_name_.Location = new System.Drawing.Point(376, 341);
            this.pass_name_.Name = "pass_name_";
            this.pass_name_.Size = new System.Drawing.Size(422, 37);
            this.pass_name_.TabIndex = 24;
            this.pass_name_.TextChanged += new System.EventHandler(this.PasssName_TextChanged);
            // 
            // address_
            // 
            this.address_.BackColor = System.Drawing.Color.LavenderBlush;
            this.address_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address_.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_.Location = new System.Drawing.Point(376, 473);
            this.address_.Name = "address_";
            this.address_.Size = new System.Drawing.Size(422, 37);
            this.address_.TabIndex = 24;
            this.address_.TextChanged += new System.EventHandler(this.PassAd_TextChanged);
            // 
            // view_pass
            // 
            this.view_pass.BackColor = System.Drawing.Color.MidnightBlue;
            this.view_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_pass.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.view_pass.FlatAppearance.BorderSize = 0;
            this.view_pass.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.view_pass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.view_pass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.view_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_pass.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.view_pass.ForeColor = System.Drawing.Color.LavenderBlush;
            this.view_pass.Location = new System.Drawing.Point(12, 711);
            this.view_pass.Name = "view_pass";
            this.view_pass.Size = new System.Drawing.Size(281, 92);
            this.view_pass.TabIndex = 30;
            this.view_pass.Text = "View pass";
            this.view_pass.UseVisualStyleBackColor = false;
            this.view_pass.Click += new System.EventHandler(this.view_pass_Click);
            // 
            // AddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1338, 813);
            this.Controls.Add(this.address_);
            this.Controls.Add(this.pass_name_);
            this.Controls.Add(this.passport_no_);
            this.Controls.Add(this.pass_phone_);
            this.Controls.Add(this.pass_id_);
            this.Controls.Add(this.x);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view_pass);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.RecordPassBtn);
            this.Controls.Add(this.pass_nat_);
            this.Controls.Add(this.pass_gend_);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassAd);
            this.Controls.Add(this.PasssName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.PassPhone);
            this.Controls.Add(this.PassId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ADDS);
            this.Controls.Add(this.Customer_Name);
            this.Controls.Add(this.Passport_NO);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Customer_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassenger";
            this.Load += new System.EventHandler(this.AddPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button RecordPassBtn;
        private System.Windows.Forms.ComboBox pass_nat_;
        private System.Windows.Forms.ComboBox pass_gend_;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PassId;
        private System.Windows.Forms.Label Customer_Name;
        private System.Windows.Forms.Label Customer_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox PasssName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Passport_NO;
        private System.Windows.Forms.Label ADDS;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PassAd;
        private System.Windows.Forms.Label AdressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PassPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.TextBox pass_id_;
        private System.Windows.Forms.TextBox pass_phone_;
        private System.Windows.Forms.TextBox passport_no_;
        private System.Windows.Forms.TextBox pass_name_;
        private System.Windows.Forms.TextBox address_;
        private System.Windows.Forms.Button view_pass;
    }
}