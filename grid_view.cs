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
    public partial class grid_view : Form
    {
        public string id;
        public grid_view(string a)
        {
            InitializeComponent();
            id = a;
            
            
        }

        private void grid_view_Load(object sender, EventArgs e)
        {
            try
            {
                databaseDataContext db1 = new databaseDataContext();

                Grid.DataSource = db1.cost_tables.Where(x => x.username == id).Select(x => new { x.cost_amount,x.cost_title,x.date});
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
