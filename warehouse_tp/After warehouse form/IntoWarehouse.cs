﻿using System;
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
    public partial class IntoWarehouse : Form
    {
        public IntoWarehouse()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            Connection.ShowRemnantsForWarehouseIn();
            datagv_warehouse.DataSource = Connection.ds.Tables[0];
            datagv_warehouse.Columns[0].HeaderText = datagv_cust.Columns[0].HeaderText = "Наименование";
            datagv_warehouse.Columns[1].HeaderText = datagv_cust.Columns[1].HeaderText = "Количество";
            datagv_warehouse.Columns[2].HeaderText = datagv_cust.Columns[2].HeaderText = "Цена";
            datagv_cust.Columns[0].Width = datagv_warehouse.Columns[0].Width = 135;
        }

        private void IntoWarehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            After_authorization_forms.Warehouse warehouse = new After_authorization_forms.Warehouse();
            warehouse.Show();
        }

        private void IntoWarehouse_Load(object sender, EventArgs e)
        {
            datagv_cust.ColumnCount = 3;
            RefreshTable();
        }

        private void button_totheBase_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datagv_cust.RowCount - 1; i++)  // -1 т.к. последняя строка пустая
            {
                if (Connection.ProductNameCheck(datagv_cust.Rows[i].Cells[0].Value.ToString()))
                {
                    Connection.ProductCountAndPriceUpdate(datagv_cust.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(datagv_cust.Rows[i].Cells[1].Value), Convert.ToDouble(datagv_cust.Rows[i].Cells[2].Value));
                    RefreshTable();
                }
                else
                {
                    Connection.AddNewProduct(datagv_cust.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(datagv_cust.Rows[i].Cells[1].Value), Convert.ToDouble(datagv_cust.Rows[i].Cells[2].Value));
                    RefreshTable();
                }
            }
        }
    }
}