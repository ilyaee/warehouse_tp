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

        private void IntoWarehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            After_authorization_forms.Warehouse warehouse = new After_authorization_forms.Warehouse();
            warehouse.Show();
        }
    }
}