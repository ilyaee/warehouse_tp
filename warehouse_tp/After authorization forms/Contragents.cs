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

        private int SelectedRow;
        private string[] roles_arr = new string[] { "Продавец", "Покупатель"};
        private string CurrentFIO;

        private void RefreshTable()
        {
            Connection.ShowContractors();
            datagv_contractors.DataSource = Connection.ds.Tables[0];
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
            comboBox_roles.Items.AddRange(roles_arr);
            comboBox_roles.SelectedIndex = 0;
        }

        private void datagv_contractors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            tb_fio.Text = datagv_contractors.Rows[SelectedRow].Cells[0].Value.ToString();
            if (datagv_contractors.Rows[SelectedRow].Cells[1].Value.ToString() != comboBox_roles.SelectedItem.ToString())
            {
                if (comboBox_roles.SelectedIndex == 0)
                {
                    comboBox_roles.SelectedIndex = 1;
                }
                else
                {
                    comboBox_roles.SelectedIndex = 0;
                }
            }
            CurrentFIO = datagv_contractors.Rows[SelectedRow].Cells[0].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Connection.AddNewContractor(tb_fio.Text, comboBox_roles.SelectedItem.ToString());
            RefreshTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection.ContractorUpdate(CurrentFIO, tb_fio.Text, comboBox_roles.SelectedItem.ToString());
            RefreshTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection.DeleteContractor(CurrentFIO);
            RefreshTable();
        }

        private void Search(string substring)
        {
            for (int i = 0; i < datagv_contractors.RowCount; i++)
                if (datagv_contractors.Rows[i].Cells[0].Value.ToString().ToLower().Contains(substring) ||
                                                                datagv_contractors.Rows[0].Cells[1].Value.ToString().Contains(substring))
                    datagv_contractors.Rows[i].DefaultCellStyle.BackColor = Color.Green;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datagv_contractors.RowCount; i++)
                datagv_contractors.Rows[i].DefaultCellStyle.BackColor = Color.White;
            Search(tbSearch.Text);
        }
    }
}