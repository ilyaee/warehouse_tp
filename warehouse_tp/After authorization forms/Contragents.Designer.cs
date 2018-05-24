namespace warehouse_tp.After_authorization_forms
{
    partial class Contractors
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
            this.datagv_contractors = new System.Windows.Forms.DataGridView();
            this.groupBox_AddUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.comboBox_roles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_contractors)).BeginInit();
            this.groupBox_AddUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagv_contractors
            // 
            this.datagv_contractors.AllowUserToAddRows = false;
            this.datagv_contractors.AllowUserToDeleteRows = false;
            this.datagv_contractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_contractors.Location = new System.Drawing.Point(12, 70);
            this.datagv_contractors.Name = "datagv_contractors";
            this.datagv_contractors.ReadOnly = true;
            this.datagv_contractors.RowHeadersVisible = false;
            this.datagv_contractors.RowTemplate.Height = 24;
            this.datagv_contractors.Size = new System.Drawing.Size(603, 368);
            this.datagv_contractors.TabIndex = 0;
            this.datagv_contractors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagv_contractors_CellClick);
            // 
            // groupBox_AddUpdate
            // 
            this.groupBox_AddUpdate.Controls.Add(this.comboBox_roles);
            this.groupBox_AddUpdate.Controls.Add(this.btnUpdate);
            this.groupBox_AddUpdate.Controls.Add(this.btnAdd);
            this.groupBox_AddUpdate.Controls.Add(this.tb_fio);
            this.groupBox_AddUpdate.Controls.Add(this.labelFIO);
            this.groupBox_AddUpdate.Location = new System.Drawing.Point(633, 12);
            this.groupBox_AddUpdate.Name = "groupBox_AddUpdate";
            this.groupBox_AddUpdate.Size = new System.Drawing.Size(319, 180);
            this.groupBox_AddUpdate.TabIndex = 4;
            this.groupBox_AddUpdate.TabStop = false;
            this.groupBox_AddUpdate.Text = "Добавление / изменение данных";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(108, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 26);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tb_fio
            // 
            this.tb_fio.Location = new System.Drawing.Point(6, 49);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(276, 22);
            this.tb_fio.TabIndex = 2;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(3, 24);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(46, 17);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 24);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(144, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(207, 22);
            this.tbSearch.TabIndex = 5;
            // 
            // comboBox_roles
            // 
            this.comboBox_roles.FormattingEnabled = true;
            this.comboBox_roles.Location = new System.Drawing.Point(6, 101);
            this.comboBox_roles.Name = "comboBox_roles";
            this.comboBox_roles.Size = new System.Drawing.Size(121, 24);
            this.comboBox_roles.TabIndex = 8;
            // 
            // Contractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.groupBox_AddUpdate);
            this.Controls.Add(this.datagv_contractors);
            this.Name = "Contractors";
            this.Text = "Contractors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contragents_FormClosed);
            this.Load += new System.EventHandler(this.Contragents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_contractors)).EndInit();
            this.groupBox_AddUpdate.ResumeLayout(false);
            this.groupBox_AddUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagv_contractors;
        private System.Windows.Forms.GroupBox groupBox_AddUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox comboBox_roles;
    }
}