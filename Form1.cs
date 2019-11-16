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
    public partial class Form1 : Form
    {
        // public int gid;
        //Data dt=new Data();
        int gid;
        string mid;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            
        }


        //here is registration
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration r = new registration();
            r.Show();
        }


        //my login method. any login is approved.
        private void login()
        {
            
            gurdian g = new gurdian();
            databaseDataContext dbcon = new databaseDataContext();
            
            string s = textBox2.Text;

            g = dbcon.gurdians.SingleOrDefault(x => x.username == s);

            if (textBox3.Text == g.password)
            {

                this.Hide();
                admin ad = new admin(g.id);
                ad.Show();
                gid = g.id;
                //dt.setGID(g.id);
                
              //  MessageBox.Show("GID set to "+gid);
            }
            else
            {

                MessageBox.Show("wrong username or password");
            }


        }
        private void member_login()
        {
            databaseDataContext db = new databaseDataContext();
            member m = new member();
            string s = textBox2.Text;
            m = db.members.SingleOrDefault(x => x.username == s);
            if (textBox3.Text == m.password)
            {
                this.Hide();
                family_member fm = new family_member(m.username);
                fm.Show();
                mid = m.username;
                //this.gid = m.gurdian_id;

            }
            else
            {
                MessageBox.Show("wrong username or pasword");
            }


        }



        //login button check
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.GetItemText(this.comboBox1.SelectedItem) == "guardian")
                {

                    login();

                }
                else if (comboBox1.GetItemText(this.comboBox1.SelectedItem) == "member")
                {
                    member_login();
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }

        }



    }
}
    

