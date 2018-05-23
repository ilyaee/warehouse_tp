namespace warehouse_tp.After_warehouse_form
{
    partial class IntoWarehouse
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
            this.datagv_cust = new System.Windows.Forms.DataGridView();
            this.datagv_warehouse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_totheBase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_cust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_warehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // datagv_cust
            // 
            this.datagv_cust.AllowUserToResizeRows = false;
            this.datagv_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_cust.ColumnHeadersVisible = false;
            this.datagv_cust.Location = new System.Drawing.Point(12, 30);
            this.datagv_cust.Name = "datagv_cust";
            this.datagv_cust.RowHeadersVisible = false;
            this.datagv_cust.RowTemplate.Height = 24;
            this.datagv_cust.Size = new System.Drawing.Size(416, 425);
            this.datagv_cust.TabIndex = 0;
            // 
            // datagv_warehouse
            // 
            this.datagv_warehouse.AllowUserToAddRows = false;
            this.datagv_warehouse.AllowUserToDeleteRows = false;
            this.datagv_warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_warehouse.Location = new System.Drawing.Point(557, 30);
            this.datagv_warehouse.Name = "datagv_warehouse";
            this.datagv_warehouse.ReadOnly = true;
            this.datagv_warehouse.RowHeadersVisible = false;
            this.datagv_warehouse.RowTemplate.Height = 24;
            this.datagv_warehouse.Size = new System.Drawing.Size(420, 425);
            this.datagv_warehouse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Текущие остатки на складе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Текущая накладная";
            // 
            // button_totheBase
            // 
            this.button_totheBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_totheBase.Location = new System.Drawing.Point(400, 461);
            this.button_totheBase.Name = "button_totheBase";
            this.button_totheBase.Size = new System.Drawing.Size(173, 48);
            this.button_totheBase.TabIndex = 11;
            this.button_totheBase.Text = "Провести";
            this.button_totheBase.UseVisualStyleBackColor = true;
            this.button_totheBase.Click += new System.EventHandler(this.button_totheBase_Click);
            // 
            // IntoWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 524);
            this.Controls.Add(this.button_totheBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagv_warehouse);
            this.Controls.Add(this.datagv_cust);
            this.Name = "IntoWarehouse";
            this.Text = "IntoWarehouse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IntoWarehouse_FormClosed);
            this.Load += new System.EventHandler(this.IntoWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_cust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_warehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagv_cust;
        private System.Windows.Forms.DataGridView datagv_warehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_totheBase;
    }
}