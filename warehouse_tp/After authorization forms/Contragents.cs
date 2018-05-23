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
    public partial class Contractors : Form
    {
        public Contractors()
        {
            InitializeComponent();
        }

        private void Contragents_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Contragents_Load(object sender, EventArgs e)
        {
            Connection.ShowContractors();
            datagv_contractors.DataSource = Connection.ds.Tables[0];
        }
    }
}