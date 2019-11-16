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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            member.Visible = true;         //MEMBER PANEL
            gurdian.Visible = false;       //GURDIAN PANEL
        }
        //full application close
        private void registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //click changes make panel visible
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                gurdian.Visible = true;
                member.Visible = false;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                gurdian.Visible = false;
                member.Visible = true;
            }
        }
        //registration button click action 
        private void button1_Click(object sender, EventArgs e)
        {
           
                    if(checkBox1.CheckState==CheckState.Checked)    // if gurdian panel active
                            {
                                  insert_gurdian();

                             }

                    else if (checkBox1.CheckState == CheckState.Unchecked)
                    {
                        insert_member();        //if member panel active

                      
                    }

     
        }
        protected void insert_gurdian()
        {
            try {
                using (databaseDataContext dbcon = new databaseDataContext())
                {   //without date of birth
                    gurdian reg_gurdian = new gurdian
                    {
                        name = name.Text,
                        username = username.Text,
                        password = password.Text,
                        gender = gender.SelectedItem.ToString(),
                        id = int.Parse(id.Text),
                       // dob=dob_g.Value,
                        family_member = int.Parse(family.Text),
                        month_sal = int.Parse(salary.Text)

                    };
                    dbcon.gurdians.InsertOnSubmit(reg_gurdian);
                    dbcon.SubmitChanges();
                }
                MessageBox.Show("registration complete");
                Form1 fm1 = new Form1();
                this.Hide();
                fm1.Show();

            
            }
                catch(Exception e)
            {
                
                MessageBox.Show(e.Message);
                }
           

            }
        
        
        protected void insert_member()
        {
          //  databaseDataContext db = new databaseDataContext();
            //balance b = new balance();
            try
            {
               

                using (databaseDataContext dbcon = new databaseDataContext())
                {
                    member reg_member = new member
                    {
                        gurdian_id = int.Parse(comboBox1.SelectedItem.ToString()),
                        username = use_name.Text,
                        password = pass.Text,
                        dob = dob_m.Value,
                        name = name_m.Text,
                        gender = gender_m.SelectedItem.ToString(),
                        relation = relation_m.SelectedItem.ToString()

                    };
                    dbcon.members.InsertOnSubmit(reg_member);
                    dbcon.SubmitChanges();


                    
                }

                using (databaseDataContext db = new databaseDataContext())
                {
                    balance b = new balance
                    {membername=use_name.Text,
                        
                        amount=0


                    };
                    db.balances.InsertOnSubmit(b);
                    db.SubmitChanges();

                }


                MessageBox.Show("registration complete");
                Form1 fm1 = new Form1();
                this.Hide();
                fm1.Show();

            
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void registration_Load(object sender, EventArgs e)
        {

            databaseDataContext db1 = new databaseDataContext();

            comboBox1.DataSource = db1.gurdians.Select(x => x.id).Distinct();
        }
    
}
}

