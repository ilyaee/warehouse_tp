namespace warehouse_tp.After_warehouse_form
{
    partial class Remnants
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
            this.datagv_remnants = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_remnants)).BeginInit();
            this.SuspendLayout();
            // 
            // datagv_remnants
            // 
            this.datagv_remnants.AllowUserToAddRows = false;
            this.datagv_remnants.AllowUserToDeleteRows = false;
            this.datagv_remnants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_remnants.Location = new System.Drawing.Point(12, 12);
            this.datagv_remnants.Name = "datagv_remnants";
            this.datagv_remnants.ReadOnly = true;
            this.datagv_remnants.RowHeadersVisible = false;
            this.datagv_remnants.RowTemplate.Height = 24;
            this.datagv_remnants.Size = new System.Drawing.Size(897, 432);
            this.datagv_remnants.TabIndex = 0;
            // 
            // Remnants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 456);
            this.Controls.Add(this.datagv_remnants);
            this.Name = "Remnants";
            this.Text = "Remnants";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Remnants_FormClosed);
            this.Load += new System.EventHandler(this.Remnants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_remnants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagv_remnants;
    }
}