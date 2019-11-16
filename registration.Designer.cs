namespace Budget_tracking
{
    partial class registration
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.member = new System.Windows.Forms.Panel();
            this.relation_m = new System.Windows.Forms.ComboBox();
            this.gender_m = new System.Windows.Forms.ComboBox();
            this.name_m = new System.Windows.Forms.TextBox();
            this.dob_m = new System.Windows.Forms.DateTimePicker();
            this.pass = new System.Windows.Forms.TextBox();
            this.use_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gurdian = new System.Windows.Forms.Panel();
            this.salary = new System.Windows.Forms.TextBox();
            this.family = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.dob_g = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.member.SuspendLayout();
            this.gurdian.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox1.Location = new System.Drawing.Point(32, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Registar as GURDIAN";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // member
            // 
            this.member.Controls.Add(this.comboBox1);
            this.member.Controls.Add(this.relation_m);
            this.member.Controls.Add(this.gender_m);
            this.member.Controls.Add(this.name_m);
            this.member.Controls.Add(this.dob_m);
            this.member.Controls.Add(this.pass);
            this.member.Controls.Add(this.use_name);
            this.member.Controls.Add(this.label7);
            this.member.Controls.Add(this.label6);
            this.member.Controls.Add(this.label5);
            this.member.Controls.Add(this.label4);
            this.member.Controls.Add(this.label3);
            this.member.Controls.Add(this.label2);
            this.member.Controls.Add(this.label1);
            this.member.Location = new System.Drawing.Point(15, 47);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(363, 319);
            this.member.TabIndex = 16;
            // 
            // relation_m
            // 
            this.relation_m.FormattingEnabled = true;
            this.relation_m.Items.AddRange(new object[] {
            "FATHER",
            "MOTHER",
            "DAUGHTER",
            "SON",
            "SISTER",
            "BROTHER"});
            this.relation_m.Location = new System.Drawing.Point(144, 247);
            this.relation_m.Name = "relation_m";
            this.relation_m.Size = new System.Drawing.Size(200, 21);
            this.relation_m.TabIndex = 13;
            // 
            // gender_m
            // 
            this.gender_m.FormattingEnabled = true;
            this.gender_m.Items.AddRange(new object[] {
            "FEMALE",
            "MALE"});
            this.gender_m.Location = new System.Drawing.Point(144, 208);
            this.gender_m.Name = "gender_m";
            this.gender_m.Size = new System.Drawing.Size(200, 21);
            this.gender_m.Sorted = true;
            this.gender_m.TabIndex = 12;
            // 
            // name_m
            // 
            this.name_m.Location = new System.Drawing.Point(144, 172);
            this.name_m.Name = "name_m";
            this.name_m.Size = new System.Drawing.Size(200, 20);
            this.name_m.TabIndex = 11;
            // 
            // dob_m
            // 
            this.dob_m.Location = new System.Drawing.Point(144, 135);
            this.dob_m.Name = "dob_m";
            this.dob_m.Size = new System.Drawing.Size(200, 20);
            this.dob_m.TabIndex = 10;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(144, 95);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(200, 20);
            this.pass.TabIndex = 9;
            // 
            // use_name
            // 
            this.use_name.Location = new System.Drawing.Point(144, 55);
            this.use_name.Name = "use_name";
            this.use_name.Size = new System.Drawing.Size(200, 20);
            this.use_name.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Relation With Gurdian :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "GENDER :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATE OF BIRTH :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GURDIAN ID :";
            // 
            // gurdian
            // 
            this.gurdian.Controls.Add(this.salary);
            this.gurdian.Controls.Add(this.family);
            this.gurdian.Controls.Add(this.id);
            this.gurdian.Controls.Add(this.dob_g);
            this.gurdian.Controls.Add(this.gender);
            this.gurdian.Controls.Add(this.password);
            this.gurdian.Controls.Add(this.username);
            this.gurdian.Controls.Add(this.label15);
            this.gurdian.Controls.Add(this.label14);
            this.gurdian.Controls.Add(this.name);
            this.gurdian.Controls.Add(this.label13);
            this.gurdian.Controls.Add(this.label12);
            this.gurdian.Controls.Add(this.label11);
            this.gurdian.Controls.Add(this.label10);
            this.gurdian.Controls.Add(this.label9);
            this.gurdian.Controls.Add(this.label8);
            this.gurdian.Location = new System.Drawing.Point(12, 50);
            this.gurdian.Name = "gurdian";
            this.gurdian.Size = new System.Drawing.Size(363, 322);
            this.gurdian.TabIndex = 14;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(126, 275);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(200, 20);
            this.salary.TabIndex = 16;
            // 
            // family
            // 
            this.family.Location = new System.Drawing.Point(126, 235);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(200, 20);
            this.family.TabIndex = 15;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(126, 198);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(200, 20);
            this.id.TabIndex = 14;
            // 
            // dob_g
            // 
            this.dob_g.Location = new System.Drawing.Point(126, 155);
            this.dob_g.Name = "dob_g";
            this.dob_g.Size = new System.Drawing.Size(200, 20);
            this.dob_g.TabIndex = 13;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.gender.Location = new System.Drawing.Point(126, 121);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(200, 21);
            this.gender.TabIndex = 12;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(126, 92);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 20);
            this.password.TabIndex = 10;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(126, 54);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 20);
            this.username.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "MONTHLY SALARY :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "FAMILY MEMBER:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(126, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 20);
            this.name.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "ID :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Date Of Birth :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "GENDER :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "PASSWORD :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "USERNAME : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "NAME :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 424);
            this.Controls.Add(this.member);
            this.Controls.Add(this.gurdian);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Name = "registration";
            this.Text = "registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registration_FormClosing);
            this.Load += new System.EventHandler(this.registration_Load);
            this.member.ResumeLayout(false);
            this.member.PerformLayout();
            this.gurdian.ResumeLayout(false);
            this.gurdian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel member;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox relation_m;
        private System.Windows.Forms.ComboBox gender_m;
        private System.Windows.Forms.TextBox name_m;
        private System.Windows.Forms.DateTimePicker dob_m;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox use_name;
        private System.Windows.Forms.Panel gurdian;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox family;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DateTimePicker dob_g;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}