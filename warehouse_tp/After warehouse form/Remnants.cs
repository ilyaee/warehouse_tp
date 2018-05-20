using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse_tp.After_warehouse_form
{
    public partial class Remnants : Form
    {
        public Remnants()
        {
            InitializeComponent();
        }

        private void Remnants_Load(object sender, EventArgs e)
        {
            Connection.ShowRemnants();
            datagv_remnants.DataSource = Connection.ds.Tables[0];
        }

        private void Remnants_FormClosed(object sender, FormClosedEventArgs e)
        {
            After_authorization_forms.Warehouse warehouse = new After_authorization_forms.Warehouse();
            warehouse.Show();
        }
    }
}
