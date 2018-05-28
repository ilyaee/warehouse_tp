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
    public partial class OutWarehouse : Form
    {
        public OutWarehouse()
        {
            InitializeComponent();
        }

        private int LastRowIndexInCust;

        private void RefreshTable()
        {
            Connection.ShowRemnantsForWarehouseIn();
            datagv_warehouse.DataSource = Connection.ds.Tables[0];
            datagv_warehouse.AutoResizeColumns(); //исправить
            datagv_warehouse.Columns[0].HeaderText = datagv_cust.Columns[0].HeaderText = "Наименование";
        }

        private void OutWarehouse_Load(object sender, EventArgs e)
        {
            LastRowIndexInCust = 0;
            datagv_cust.ColumnCount = 3;
            datagv_cust.RowCount = 1;
            RefreshTable();
        }

        private void OutWarehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            After_authorization_forms.Warehouse warehouse = new After_authorization_forms.Warehouse();
            warehouse.Show();
        }

        private void datagv_warehouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool Exists = false;
            for (int k = 0; k < datagv_cust.RowCount; k++)
                if (datagv_warehouse.Rows[e.RowIndex].Cells[0].Value == datagv_cust.Rows[k].Cells[0].Value)
                {
                    Exists = true;
                    break;
                }
            if (!Exists)
            {
                for (int i = 0; i < datagv_cust.ColumnCount; i = i + 2)
                    datagv_cust.Rows[LastRowIndexInCust].Cells[i].Value = datagv_warehouse.Rows[e.RowIndex].Cells[i].Value;
                LastRowIndexInCust++;
                datagv_cust.RowCount++;
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            //bool PriceOk = true;
            bool CountOk = true;
            int CountIndex = 0;
            //bool EqualCount = false;
            for (int i = 0; i < datagv_cust.RowCount - 1; i++)
            {
                if (datagv_cust.Rows[i].Cells[1].Value == null || !UInt32.TryParse(datagv_cust.Rows[i].Cells[1].Value.ToString(), out uint res) || res == 0)
                {
                    CountOk = false;
                    MessageBox.Show("Задано некорректное значение количества товара");
                    break;
                }

                for (int k = 0; k < datagv_warehouse.RowCount; k++) //определяется строка товара с таким же наименованием
                    if (datagv_warehouse.Rows[k].Cells[0].Value == datagv_cust.Rows[i].Cells[0].Value)
                    {
                        CountIndex = k;
                        break;
                    }

                if (Convert.ToInt32(datagv_cust.Rows[i].Cells[1].Value) > Convert.ToInt32(datagv_warehouse.Rows[CountIndex].Cells[1].Value))
                {
                    CountOk = false;
                    MessageBox.Show("На складе отсутствует заданное количество товара");
                    break;
                }
            }

            if (CountOk)
            {
                for (int i = 0; i < datagv_cust.RowCount - 1; i++)
                {
                    Connection.UpdateForWarehouseOut(datagv_cust.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(datagv_cust.Rows[i].Cells[1].Value)
                        , Convert.ToDouble(datagv_cust.Rows[i].Cells[2].Value));
                }
                RefreshTable();
            }
        }
    }
}