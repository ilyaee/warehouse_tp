namespace warehouse_tp.After_authorization_forms
{
    partial class Warehouse
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
            this.button_in = new System.Windows.Forms.Button();
            this.button_out = new System.Windows.Forms.Button();
            this.button_remnants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_in
            // 
            this.button_in.Location = new System.Drawing.Point(12, 12);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(341, 41);
            this.button_in.TabIndex = 0;
            this.button_in.Text = "Приход";
            this.button_in.UseVisualStyleBackColor = true;
            this.button_in.Click += new System.EventHandler(this.button_in_Click);
            // 
            // button_out
            // 
            this.button_out.Location = new System.Drawing.Point(12, 59);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(341, 42);
            this.button_out.TabIndex = 1;
            this.button_out.Text = "Реализация";
            this.button_out.UseVisualStyleBackColor = true;
            this.button_out.Click += new System.EventHandler(this.button_out_Click);
            // 
            // button_remnants
            // 
            this.button_remnants.Location = new System.Drawing.Point(12, 129);
            this.button_remnants.Name = "button_remnants";
            this.button_remnants.Size = new System.Drawing.Size(341, 42);
            this.button_remnants.TabIndex = 2;
            this.button_remnants.Text = "Остатки";
            this.button_remnants.UseVisualStyleBackColor = true;
            this.button_remnants.Click += new System.EventHandler(this.button_remnants_Click);
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 183);
            this.Controls.Add(this.button_remnants);
            this.Controls.Add(this.button_out);
            this.Controls.Add(this.button_in);
            this.Name = "Warehouse";
            this.Text = "Склад";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Warehouse_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.Button button_out;
        private System.Windows.Forms.Button button_remnants;
    }
}