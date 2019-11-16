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
    public partial class Form2 : Form
    {
        int gid;
        public Form2(int a)
        {
            InitializeComponent();
            gid = a;
            button1.Enabled = false;
            button2.Enabled = false;

        }

        private void showrequests(object sender, EventArgs e)
        {
            request r = new request();
            databaseDataContext db = new databaseDataContext();
            //r = db.requests.
            comboBox1.DataSource = db.requests.Select(x => x.amount).Distinct();





            //r = db.requests.ToList
            // dataGridView1.DataSource = db.requests.ToList();
        }
        public void acceptreq(object sender, EventArgs e) {
            databaseDataContext db3 = new databaseDataContext();
            budget_setting bs = new budget_setting();
            //DateTime dt = new DateTime();
            databaseDataContext db = new databaseDataContext();
            balance b = new balance();
            request r = new request();
            admin adm = new admin(gid);
            databaseDataContext db1 = new databaseDataContext();
            try {
                string s = comboBox1.GetItemText(this.comboBox1.SelectedItem);
                int es = Int32.Parse(s);

                b = db.balances.SingleOrDefault(x => x.membername == textBox1.Text);
                b.amount = b.amount + es;


                db.SubmitChanges();
                r = db1.requests.SingleOrDefault(x => x.amount == es);
                db1.requests.DeleteOnSubmit(r);
                db1.SubmitChanges();
                //following 3 lines don't work
                //bs = db3.budget_settings.SingleOrDefault(x => x.guardian_id == gid && x.year==dateTimePicker1.Value.Month && x.month==adm.convertdate(dateTimePicker1.Value.Month.ToString()));
                //bs.max = bs.max + es;

                //db3.SubmitChanges();





                MessageBox.Show("request accepted");
            
            }
        catch(Exception ex){MessageBox.Show(ex.Message);}
        }

        private void select1stcombo(object sender, EventArgs e)
        {
            request r = new request();
            databaseDataContext db = new databaseDataContext();
            int a =int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
            r = db.requests.SingleOrDefault(x => x.amount==a);
            textBox1.Text = r.username;
            richTextBox1.Text = r.description;
            button1.Enabled =true;
            button2.Enabled = true;
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void deletereq(object sender, EventArgs e)
        {
            //databaseDataContext db = new databaseDataContext();
         //   balance b = new balance();
            request r = new request();
            databaseDataContext db1 = new databaseDataContext();
           // budget_setting bs = new budget_setting();

            
            try {
                string s = comboBox1.GetItemText(this.comboBox1.SelectedItem);
                int es = Int32.Parse(s);

           //     b = db.balances.SingleOrDefault(x => x.membername == textBox1.Text);
             //   b.balance1 = b.balance1 + es;


               // db.SubmitChanges();
                r = db1.requests.SingleOrDefault(x => x.amount == es);
                db1.requests.DeleteOnSubmit(r);
                db1.SubmitChanges();
                MessageBox.Show("request deleted");

                

            }
        catch(Exception ex){MessageBox.Show(ex.Message);}
        }
        }

    }
