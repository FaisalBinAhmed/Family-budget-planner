using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Budget_tracking
{
    public partial class admin : Form
    {
        // Data dt = new Data();
        //Data gid;
        //public Form1();
      //  Data dt=new Data();
        int gid;
        public admin(int a)
        {

            InitializeComponent();
            gid = a;
            
           
            hideAllPanels();

            
        }

        private void hideAllPanels()
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
 
        }



        private void refresh()
        {
            this.textBoxAmountRemaining.Text = "";
            this.textBoxAmountUsed.Text = "";
            this.textBoxBudget.Text = "";
            this.textBoxConfirmPass.Text = "";
            this.textBoxCostAmount.Text = "";
            this.textBoxCostTitle.Text = "";
           
            this.textBoxNewPass.Text = "";
            this.textBoxOldPass.Text = "";
           // this.textBoxRequestedAmount.Text = "";
           

        }

        //exit button
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Hide();
            fm1.Show();
        }

        
        //closing button work
        private void gurdian_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonShowStatus_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();
            panel1.Show();
            refresh();


        }

        private void radioButtonSetBudget_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();

            panel2.Show();
            refresh();
        }

        private void radioButtonAddExpense_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();
            panel3.Show();
            refresh();
        }

        private void radioButtonShowRequest_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();
            
            panel4.Show();
            refresh();
        }

        private void radioButtonALterPass_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();
            
            panel5.Show();
            button5.Hide();
            textBoxNewPass.Hide();
            textBoxConfirmPass.Hide();
            refresh();
        }

        private void ButtonSet_budget_Click(object sender, EventArgs e)
        {
            budget_set();
        }


        protected void budget_set()
        {
           // Form1 f1 =  new Form1();
            //Null reference exception here
            databaseDataContext db = new databaseDataContext();
            try
            {
               
                budget_setting b = new budget_setting();
                b.year = int.Parse(comboBox1.SelectedItem.ToString());
                b.month = comboBox2.SelectedItem.ToString();
                b.max = 0;
                b.budget = int.Parse(textBoxBudget.Text);
                b.guardian_id = gid;
               // b.guardian_id = f1.gid;
               
                
                db.budget_settings.InsertOnSubmit(b);
                db.SubmitChanges();

                MessageBox.Show("budget setting done!");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            

           



            /*try
            {
                using (databaseDataContext dbcon = new databaseDataContext())
                {
                    budget_setting bd=new budget_setting
                    {
                        year = int.Parse(comboBox1.SelectedItem.ToString()),
                        month = comboBox2.SelectedItem.ToString(),
                        budget = int.Parse(textBoxBudget.SelectedText),
                        max = int.Parse(textBoxMAX.SelectedText),
                        budget_id=int.Parse(textBoxBudgetId.SelectedText)
                        //month_id=tex
                    };
                    dbcon.budget_settings.InsertOnSubmit(bd);
                    dbcon.SubmitChanges();

                }
                //label17.Text = "Successfullt Done!";

                //MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }*/
        }

        private void comboBoxMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void show_budget(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            budget_setting bs = new budget_setting();
            //budget_setting bs1 = new budget_setting();
            try
            {
                int y = Int32.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                string m = comboBox2.GetItemText(this.comboBox2.SelectedItem);
            
            bs = db.budget_settings.SingleOrDefault(x => x.year == y && x.month==m);
            //bs = db.budget_settings.SingleOrDefault(x => x.month==m);

            textBoxAmountUsed.Text = bs.max.ToString();
            textBoxAmountRemaining.Text = (bs.budget - bs.max).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void set_budget(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            budget_setting bs = new budget_setting();
            databaseDataContext db1 = new databaseDataContext();
            int s = Int32.Parse(comboBoxYear.GetItemText(this.comboBoxYear.SelectedItem));
            string n = comboBoxMonth.GetItemText(this.comboBoxMonth.SelectedItem);
            budget_setting bs1 = new budget_setting();
            try{
            bs1=db1.budget_settings.SingleOrDefault(x=>x.year==s && x.month==n);


            if (bs1 == null) { 
            bs.year = s;
            bs.month = n;
            bs.max = 0;
            bs.budget = Int32.Parse(textBoxBudget.Text);
            bs.guardian_id = gid;
            db.budget_settings.InsertOnSubmit(bs);
            db.SubmitChanges();
            MessageBox.Show("budget set");
            }
            else { MessageBox.Show("item already exist"); }
            }
            catch(Exception ex){MessageBox.Show(ex.Message);}
        }


        private void addexpense(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            cost_table c = new cost_table();
            databaseDataContext db1 = new databaseDataContext();
            gurdian g = new gurdian();
            budget_setting bs = new budget_setting();
            try
            {
                //     Form1 f = new Form1();
              //  MessageBox.Show(dateTimePicker1.Value.Month.ToString());
                bs = db1.budget_settings.SingleOrDefault(x => x.year == dateTimePicker1.Value.Year && x.month == convertdate(dateTimePicker1.Value.Month.ToString()));
                bs.max = bs.max + Int32.Parse(textBoxCostAmount.Text);

                c.cost_title = textBoxCostTitle.Text;
                c.cost_amount = Int32.Parse(textBoxCostAmount.Text);
                g = db1.gurdians.SingleOrDefault(x => x.id == gid);
                // string s = f.gid.ToString();
                c.username = g.username;
                c.date = dateTimePicker1.Value;
                db.cost_tables.InsertOnSubmit(c);
                db1.SubmitChanges();
                db.SubmitChanges();
                MessageBox.Show("expense added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        
        
        }

        private void change_pass(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            gurdian g = new gurdian();


            try {

                g = db.gurdians.SingleOrDefault(x => x.id == gid);

                if (textBoxNewPass.Text == textBoxConfirmPass.Text)
                {
                    g.password = textBoxConfirmPass.Text;
                    //g.password.
                    
                    db.SubmitChanges();
                    MessageBox.Show("Password change successfully!");
                }
                else { MessageBox.Show("Passwords didn't match"); } }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void checkoldpass(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            gurdian g = new gurdian();
            // Form1 f = new Form1();

          //  MessageBox.Show("gid is"+gid);
            string op = textBoxOldPass.Text;
            
            try {

                g = db.gurdians.SingleOrDefault(x => x.id == gid);
                if (op==g.password)
                {
                    textBoxNewPass.Show();
                    textBoxConfirmPass.Show();
                    button5.Show();
                }
                else { MessageBox.Show("wrong password"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showrequests(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(gid);
            f2.Show();
        }

        private void showallexpense(object sender, EventArgs e)
        {

        }
        public string convertdate(string s) {
            string a="";
            int b = Int32.Parse(s);
            if (b == 1) {a="January"; }
            else if (b == 2) { a = "February"; }
            else if (b == 3) { a = "March"; }
            else if (b == 4) { a = "April"; }
            else if (b == 5) { a = "May"; }
            else if (b == 6) { a = "June"; }
            else if (b == 7) { a = "July"; }
            else if (b == 8) { a = "August"; }
            else if (b == 9) { a = "September"; }
            else if (b == 10) { a = "October"; }
            else if (b ==11) { a = "November"; }
            else if (b == 12) { a = "December"; }
            else { return a; }

            return a;
        
        
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            member_budget mb = new member_budget(gid);
            mb.Show();

        }

    }
}
