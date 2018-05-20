using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse_tp.After_authorization_forms
{
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void button_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            After_warehouse_form.IntoWarehouse intoWarehouse = new After_warehouse_form.IntoWarehouse();
            intoWarehouse.Show();
            
        }

        private void button_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            After_warehouse_form.OutWarehouse outWarehouse = new After_warehouse_form.OutWarehouse();
            outWarehouse.Show();
        }

        private void button_remnants_Click(object sender, EventArgs e)
        {
            this.Hide();
            After_warehouse_form.Remnants remnants = new After_warehouse_form.Remnants();
            remnants.Show();
        }

        private void Warehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
