using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse_tp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AcceptButton = button_login;
        }

        //wh-склад
        //co-контрагенты
        //ad-окно управления

        private string prefix;
        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text != null && textBox_password.Text != "" && Connection.PasswordCheck(textBox_login.Text, textBox_password.Text, out prefix))
            {
                if (prefix == "ad")
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                if (prefix == "wh")
                {
                    this.Hide();
                    After_authorization_forms.Warehouse warehouse = new After_authorization_forms.Warehouse();
                    warehouse.Show();
                }
                
                if (prefix == "co")
                {
                    this.Hide();
                    After_authorization_forms.Contractors contragents = new After_authorization_forms.Contractors();
                    contragents.Show();
                }
            }
            else
                MessageBox.Show("Неверный ввод");

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}