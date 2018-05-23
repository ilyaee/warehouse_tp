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
            ((System.ComponentModel.ISupportInitialize)(this.datagv_contractors)).BeginInit();
            this.SuspendLayout();
            // 
            // datagv_contractors
            // 
            this.datagv_contractors.AllowUserToAddRows = false;
            this.datagv_contractors.AllowUserToDeleteRows = false;
            this.datagv_contractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_contractors.Location = new System.Drawing.Point(12, 12);
            this.datagv_contractors.Name = "datagv_contractors";
            this.datagv_contractors.ReadOnly = true;
            this.datagv_contractors.RowHeadersVisible = false;
            this.datagv_contractors.RowTemplate.Height = 24;
            this.datagv_contractors.Size = new System.Drawing.Size(776, 426);
            this.datagv_contractors.TabIndex = 0;
            // 
            // Contractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagv_contractors);
            this.Name = "Contractors";
            this.Text = "Contractors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contragents_FormClosed);
            this.Load += new System.EventHandler(this.Contragents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_contractors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagv_contractors;
    }
}