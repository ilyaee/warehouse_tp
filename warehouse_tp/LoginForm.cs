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
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (Connection.PasswordCheck(textBox_login.Text, textBox_password.Text))
            {
                this.Hide();
                AdminForm adminForm = new AdminForm();  //позже накинуть проверки на символы и распределить окна
                adminForm.Show();
            }
            else
                MessageBox.Show("Неверный пароль");
        }
    }
}
