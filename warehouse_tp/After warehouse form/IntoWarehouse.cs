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
    public partial class IntoWarehouse : Form
    {
        public IntoWarehouse()
        {
            InitializeComponent();
        }

        private void IntoWarehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            After_authorization_forms.Warehouse warehouse = new After_authorization_forms.Warehouse();
            warehouse.Show();
        }

        private void IntoWarehouse_Load(object sender, EventArgs e)
        {
            datagv_cust.ColumnCount = 3;
            Connection.ShowRemnantsForWarehouseIn();
            datagv_warehouse.DataSource = Connection.ds.Tables[0];
            //Connection.ShowProductsNames();
            //datagv_cust.DataSource = Connection.ds.Tables[0];
        }

        private void button_totheBase_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datagv_cust.RowCount - 1; i++)  // -1 т.к. последняя строка пустая
            {
                if (Connection.ProductNameCheck(datagv_cust.Rows[i].Cells[0].Value.ToString()))
                {
                    Connection.ProductCountAndPriceUpdate(datagv_cust.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(datagv_cust.Rows[i].Cells[1].Value), Convert.ToDouble(datagv_cust.Rows[i].Cells[2].Value));

                    Connection.ShowRemnantsForWarehouseIn();
                    datagv_warehouse.DataSource = Connection.ds.Tables[0];
                }
                else
                {
                    Connection.AddNewProduct(datagv_cust.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(datagv_cust.Rows[i].Cells[1].Value), Convert.ToDouble(datagv_cust.Rows[i].Cells[2].Value));

                    Connection.ShowRemnantsForWarehouseIn();
                    datagv_warehouse.DataSource = Connection.ds.Tables[0];
                }
            }
        }
    }
}