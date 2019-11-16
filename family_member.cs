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
    public partial class family_member : Form
    {
        string mid;
        public family_member(string a)
        {
            InitializeComponent();
            hideAllPanels();
            mid = a;
        
        }


        private void hideAllPanels()
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            

        }






        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();
            panel1.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();
            panel2.Show();
            //comboBox3.SelectedItem = mid;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();
            panel3.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();
            panel4.Show();
            textBox7.Hide();
            textBox8.Hide();
            button9.Hide();
        }

        private void family_member_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      /*  private void showmembud(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            budget_setting bs = new budget_setting();
            
            try
            {
                int y = Int32.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                string m = comboBox2.GetItemText(this.comboBox2.SelectedItem);

                bs = db.budget_settings.SingleOrDefault(x => x.year == y && x.month == m);
              

                textBox1.Text = bs.max.ToString();
                textBox2.Text = (bs.budget - bs.max).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
*/
        private void family_member_Load(object sender, EventArgs e)
        {

        }

        private void addmemexp(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            cost_table c = new cost_table();
           databaseDataContext db1 = new databaseDataContext();
            // member m = new member();
           balance b = new balance();

            try {
                c.cost_title = textBox3.Text;
                c.cost_amount = Int32.Parse(textBox4.Text);
                // m = db1.members.SingleOrDefault(x=>x.username==mid);
                // string s = f.gid.ToString();
                c.username = mid;
                c.date = dateTimePicker1.Value;
                db.cost_tables.InsertOnSubmit(c);
                db.SubmitChanges();

                b = db1.balances.SingleOrDefault(x=>x.membername==mid);
                b.amount = b.amount - Int32.Parse(textBox4.Text);
                db1.SubmitChanges();


                MessageBox.Show("expense added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void checkoldmempass(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            member m = new member();
           
            string op = textBox6.Text;

            try
            {
                m = db.members.SingleOrDefault(x=>x.username==mid);

                if (op == m.password)
                {
                    textBox7.Show();
                    textBox8.Show();
                    button9.Show();
                }
                else { MessageBox.Show("wrong password"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void changemempass(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            member m = new member();


            try
            {

                m = db.members.SingleOrDefault(x => x.username == mid);

                if (textBox7.Text == textBox8.Text)
                {
                    m.password = textBox8.Text;
     
                    db.SubmitChanges();

                    MessageBox.Show("Password change successfully!");
                }
                else { MessageBox.Show("Passwords didn't match"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void requestmoney(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            databaseDataContext db1 = new databaseDataContext();
            request r = new request();
            member m = new member();
            try {
                r.username = mid;
                r.amount = Int32.Parse(textBox5.Text);
                r.description = textBox9.Text;
                m = db1.members.SingleOrDefault(x => x.username == mid);
                r.guardian_id = m.gurdian_id;

                db.requests.InsertOnSubmit(r);
                db.SubmitChanges();
                MessageBox.Show("request sent");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        private void showbalance(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            member m = new member();
            balance b = new balance();

            try { 
            
                b=db.balances.SingleOrDefault(x=>x.membername==mid);
                label5.Text=b.amount.ToString();
            
            
            
            
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid_view gv = new grid_view(mid);
            gv.Show();

        }
    }
}
