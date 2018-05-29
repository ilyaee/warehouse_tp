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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private int SelectedRow;

        private void RefreshTable()
        {
            Connection.ShowAllEmployees();
            dgvEmployees.DataSource = Connection.ds.Tables[0];
            dgvEmployees.Columns[0].HeaderText = "ID";
            dgvEmployees.Columns[1].HeaderText = "Логин";
            dgvEmployees.Columns[2].HeaderText = "Пароль";
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
            dgvEmployees.Columns[2].Width = 220;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tb_login.TextLength <= 30 && tb_password.TextLength <= 150)
            {
                Connection.AddEmployee(tb_login.Text, tb_password.Text);
                RefreshTable();
            }
            else
                MessageBox.Show("Некорректный ввод");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tb_login.TextLength <= 30 && tb_password.TextLength <= 150)
            {
                Connection.UpdateEmployee(tb_login.Text, tb_password.Text, 
                                                Convert.ToInt32(dgvEmployees.Rows[SelectedRow].Cells[0].Value));
                RefreshTable();
            }
            else
                MessageBox.Show("Некорректный ввод");
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            tb_login.Text = dgvEmployees.Rows[SelectedRow].Cells[1].Value.ToString();
            //tb_hashpass.Text = dgvEmployees.Rows[SelectedRow].Cells[2].Value.ToString();
            //tb_password.Text = Authentication.UnHash(tb_hashpass.Text);  //раскодированный пароль
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection.DeleteEmployee(Convert.ToInt32(dgvEmployees.Rows[SelectedRow].Cells[0].Value));
            RefreshTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEmployees.RowCount; i++)
                dgvEmployees.Rows[i].DefaultCellStyle.BackColor = Color.White;
            Search(tbSearch.Text);
        }

        private void Search(string substring)
        {
            for (int i = 0; i < dgvEmployees.RowCount; i++)
                if (dgvEmployees.Rows[i].Cells[1].Value.ToString().ToLower().Contains(substring) ||
                                                                dgvEmployees.Rows[i].Cells[1].Value.ToString().Contains(substring))
                    dgvEmployees.Rows[i].DefaultCellStyle.BackColor = Color.Green;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}