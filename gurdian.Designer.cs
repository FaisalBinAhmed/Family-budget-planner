namespace Budget_tracking
{
    partial class admin
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAmountRemaining = new System.Windows.Forms.TextBox();
            this.textBoxAmountUsed = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBudget = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxCostAmount = new System.Windows.Forms.TextBox();
            this.textBoxCostTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.radioButtonShowStatus = new System.Windows.Forms.RadioButton();
            this.radioButtonSetBudget = new System.Windows.Forms.RadioButton();
            this.radioButtonAddExpense = new System.Windows.Forms.RadioButton();
            this.radioButtonShowRequest = new System.Windows.Forms.RadioButton();
            this.radioButtonALterPass = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxAmountRemaining);
            this.panel1.Controls.Add(this.textBoxAmountUsed);
            this.panel1.Location = new System.Drawing.Point(17, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 225);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.show_budget);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Month";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Year";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox2.Location = new System.Drawing.Point(83, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.comboBox1.Location = new System.Drawing.Point(83, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount remaining";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount used";
            // 
            // textBoxAmountRemaining
            // 
            this.textBoxAmountRemaining.Location = new System.Drawing.Point(101, 155);
            this.textBoxAmountRemaining.Name = "textBoxAmountRemaining";
            this.textBoxAmountRemaining.Size = new System.Drawing.Size(77, 20);
            this.textBoxAmountRemaining.TabIndex = 1;
            // 
            // textBoxAmountUsed
            // 
            this.textBoxAmountUsed.Location = new System.Drawing.Point(101, 120);
            this.textBoxAmountUsed.Name = "textBoxAmountUsed";
            this.textBoxAmountUsed.Size = new System.Drawing.Size(77, 20);
            this.textBoxAmountUsed.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.comboBoxMonth);
            this.panel2.Controls.Add(this.comboBoxYear);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxBudget);
            this.panel2.Location = new System.Drawing.Point(217, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 225);
            this.panel2.TabIndex = 12;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(40, 184);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "Add Member Budget";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.set_budget);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 20);
            this.label17.TabIndex = 8;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(63, 65);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(91, 21);
            this.comboBoxMonth.TabIndex = 7;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBoxYear.Location = new System.Drawing.Point(63, 30);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(92, 21);
            this.comboBoxYear.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Month";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Budget";
            // 
            // textBoxBudget
            // 
            this.textBoxBudget.Location = new System.Drawing.Point(63, 102);
            this.textBoxBudget.Name = "textBoxBudget";
            this.textBoxBudget.Size = new System.Drawing.Size(91, 20);
            this.textBoxBudget.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.textBoxCostAmount);
            this.panel3.Controls.Add(this.textBoxCostTitle);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(399, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 224);
            this.panel3.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(51, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.addexpense);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBoxCostAmount
            // 
            this.textBoxCostAmount.Location = new System.Drawing.Point(80, 67);
            this.textBoxCostAmount.Name = "textBoxCostAmount";
            this.textBoxCostAmount.Size = new System.Drawing.Size(84, 20);
            this.textBoxCostAmount.TabIndex = 4;
            // 
            // textBoxCostTitle
            // 
            this.textBoxCostTitle.Location = new System.Drawing.Point(79, 31);
            this.textBoxCostTitle.Name = "textBoxCostTitle";
            this.textBoxCostTitle.Size = new System.Drawing.Size(85, 20);
            this.textBoxCostTitle.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cost amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cost title";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.button7);
            this.panel4.Location = new System.Drawing.Point(585, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 223);
            this.panel4.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(51, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "show requests";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.showrequests);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.textBoxConfirmPass);
            this.panel5.Controls.Add(this.textBoxOldPass);
            this.panel5.Controls.Add(this.textBoxNewPass);
            this.panel5.Location = new System.Drawing.Point(780, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 226);
            this.panel5.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(114, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.checkoldpass);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(114, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Change";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.change_pass);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Confirm password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "New password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Old password";
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Location = new System.Drawing.Point(93, 130);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(96, 20);
            this.textBoxConfirmPass.TabIndex = 2;
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Location = new System.Drawing.Point(93, 30);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(96, 20);
            this.textBoxOldPass.TabIndex = 1;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(93, 90);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(97, 20);
            this.textBoxNewPass.TabIndex = 0;
            // 
            // radioButtonShowStatus
            // 
            this.radioButtonShowStatus.AutoSize = true;
            this.radioButtonShowStatus.Location = new System.Drawing.Point(55, 44);
            this.radioButtonShowStatus.Name = "radioButtonShowStatus";
            this.radioButtonShowStatus.Size = new System.Drawing.Size(81, 17);
            this.radioButtonShowStatus.TabIndex = 16;
            this.radioButtonShowStatus.TabStop = true;
            this.radioButtonShowStatus.Text = "Activate me";
            this.radioButtonShowStatus.UseVisualStyleBackColor = true;
            this.radioButtonShowStatus.CheckedChanged += new System.EventHandler(this.radioButtonShowStatus_CheckedChanged);
            // 
            // radioButtonSetBudget
            // 
            this.radioButtonSetBudget.AutoSize = true;
            this.radioButtonSetBudget.Location = new System.Drawing.Point(257, 44);
            this.radioButtonSetBudget.Name = "radioButtonSetBudget";
            this.radioButtonSetBudget.Size = new System.Drawing.Size(81, 17);
            this.radioButtonSetBudget.TabIndex = 17;
            this.radioButtonSetBudget.TabStop = true;
            this.radioButtonSetBudget.Text = "Activate me";
            this.radioButtonSetBudget.UseVisualStyleBackColor = true;
            this.radioButtonSetBudget.CheckedChanged += new System.EventHandler(this.radioButtonSetBudget_CheckedChanged);
            // 
            // radioButtonAddExpense
            // 
            this.radioButtonAddExpense.AutoSize = true;
            this.radioButtonAddExpense.Location = new System.Drawing.Point(435, 44);
            this.radioButtonAddExpense.Name = "radioButtonAddExpense";
            this.radioButtonAddExpense.Size = new System.Drawing.Size(81, 17);
            this.radioButtonAddExpense.TabIndex = 18;
            this.radioButtonAddExpense.TabStop = true;
            this.radioButtonAddExpense.Text = "Activate me";
            this.radioButtonAddExpense.UseVisualStyleBackColor = true;
            this.radioButtonAddExpense.CheckedChanged += new System.EventHandler(this.radioButtonAddExpense_CheckedChanged);
            // 
            // radioButtonShowRequest
            // 
            this.radioButtonShowRequest.AutoSize = true;
            this.radioButtonShowRequest.Location = new System.Drawing.Point(617, 44);
            this.radioButtonShowRequest.Name = "radioButtonShowRequest";
            this.radioButtonShowRequest.Size = new System.Drawing.Size(81, 17);
            this.radioButtonShowRequest.TabIndex = 19;
            this.radioButtonShowRequest.TabStop = true;
            this.radioButtonShowRequest.Text = "Activate me";
            this.radioButtonShowRequest.UseVisualStyleBackColor = true;
            this.radioButtonShowRequest.CheckedChanged += new System.EventHandler(this.radioButtonShowRequest_CheckedChanged);
            // 
            // radioButtonALterPass
            // 
            this.radioButtonALterPass.AutoSize = true;
            this.radioButtonALterPass.Location = new System.Drawing.Point(839, 45);
            this.radioButtonALterPass.Name = "radioButtonALterPass";
            this.radioButtonALterPass.Size = new System.Drawing.Size(81, 17);
            this.radioButtonALterPass.TabIndex = 20;
            this.radioButtonALterPass.TabStop = true;
            this.radioButtonALterPass.Text = "Activate me";
            this.radioButtonALterPass.UseVisualStyleBackColor = true;
            this.radioButtonALterPass.CheckedChanged += new System.EventHandler(this.radioButtonALterPass_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Show budget status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "set budget";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(434, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "add my expendeture";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(635, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "show request";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(835, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "alter password";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 353);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonALterPass);
            this.Controls.Add(this.radioButtonShowRequest);
            this.Controls.Add(this.radioButtonAddExpense);
            this.Controls.Add(this.radioButtonSetBudget);
            this.Controls.Add(this.radioButtonShowStatus);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "admin";
            this.Text = "Guardian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAmountRemaining;
        private System.Windows.Forms.TextBox textBoxAmountUsed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBudget;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxCostAmount;
        private System.Windows.Forms.TextBox textBoxCostTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButtonShowStatus;
        private System.Windows.Forms.RadioButton radioButtonSetBudget;
        private System.Windows.Forms.RadioButton radioButtonAddExpense;
        private System.Windows.Forms.RadioButton radioButtonShowRequest;
        private System.Windows.Forms.RadioButton radioButtonALterPass;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button9;
    }
}