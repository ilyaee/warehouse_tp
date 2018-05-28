namespace warehouse_tp.After_warehouse_form
{
    partial class OutWarehouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagv_warehouse = new System.Windows.Forms.DataGridView();
            this.datagv_cust = new System.Windows.Forms.DataGridView();
            this.button_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_cust)).BeginInit();
            this.SuspendLayout();
            // 
            // datagv_warehouse
            // 
            this.datagv_warehouse.AllowUserToAddRows = false;
            this.datagv_warehouse.AllowUserToDeleteRows = false;
            this.datagv_warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_warehouse.Location = new System.Drawing.Point(12, 12);
            this.datagv_warehouse.Name = "datagv_warehouse";
            this.datagv_warehouse.ReadOnly = true;
            this.datagv_warehouse.RowHeadersVisible = false;
            this.datagv_warehouse.RowTemplate.Height = 24;
            this.datagv_warehouse.Size = new System.Drawing.Size(502, 438);
            this.datagv_warehouse.TabIndex = 0;
            this.datagv_warehouse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagv_warehouse_CellDoubleClick);
            // 
            // datagv_cust
            // 
            this.datagv_cust.AllowUserToAddRows = false;
            this.datagv_cust.AllowUserToDeleteRows = false;
            this.datagv_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_cust.Location = new System.Drawing.Point(590, 13);
            this.datagv_cust.Name = "datagv_cust";
            this.datagv_cust.RowHeadersVisible = false;
            this.datagv_cust.RowTemplate.Height = 24;
            this.datagv_cust.Size = new System.Drawing.Size(453, 437);
            this.datagv_cust.TabIndex = 1;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(492, 456);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(118, 44);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "Провести";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // OutWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 512);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.datagv_cust);
            this.Controls.Add(this.datagv_warehouse);
            this.Name = "OutWarehouse";
            this.Text = "OutWarehouse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OutWarehouse_FormClosed);
            this.Load += new System.EventHandler(this.OutWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_cust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagv_warehouse;
        private System.Windows.Forms.DataGridView datagv_cust;
        private System.Windows.Forms.Button button_ok;
    }
}