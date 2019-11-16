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
    public partial class member_budget : Form
    {
        public member_budget(int a)
        {
            InitializeComponent();
            databaseDataContext db = new databaseDataContext();
            member m = new member();
            try
            {
                comboBox1.DataSource = db.members.Where(x => x.gurdian_id == a).Select(x => x.username);
            }
            catch (Exception ex) { MessageBox.Show("No users found"+ex.Message); }
        }

        private void member_budget_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseDataContext bd = new databaseDataContext();
            balance b = new balance();
            databaseDataContext bd1 = new databaseDataContext();
            budget_setting bs = new budget_setting();
            databaseDataContext bd2 = new databaseDataContext();
            
           
            try
            {
              //  b = bd.balances.SingleOrDefault(x => x.membername == comboBox1.GetItemText(this.comboBox1.SelectedItem));

                int m = int.Parse(bd2.balances.Select(x => x.year).ToString());
                string fs = bd2.balances.Select(x => x.month).ToString();

                b.membername = comboBox1.SelectedItem.ToString();
                b.amount = int.Parse(textBox1.Text);
                b.month = comboBox3.SelectedItem.ToString();
                b.year = int.Parse(comboBox2.SelectedItem.ToString());
                if (b.month == fs && b.year == m)
                {
                    bd.balances.InsertOnSubmit(b);
                    bd.SubmitChanges();
                    MessageBox.Show("balance added");

                }

                else { MessageBox.Show("duplicate value!!"); }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try {

                bs = bd1.budget_settings.SingleOrDefault(x => x.month == b.month && x.year == b.year);
                bs.max = bs.max + b.amount;
                bd1.SubmitChanges();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
         
        }
    }

