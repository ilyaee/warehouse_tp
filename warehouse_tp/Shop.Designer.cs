namespace warehouse_tp
{
    partial class Shop
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
            this.SuspendLayout();
            // 
            // button_in
            // 
            this.button_in.Location = new System.Drawing.Point(12, 12);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(258, 62);
            this.button_in.TabIndex = 0;
            this.button_in.Text = "Приход";
            this.button_in.UseVisualStyleBackColor = true;
            // 
            // button_out
            // 
            this.button_out.Location = new System.Drawing.Point(12, 80);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(258, 62);
            this.button_out.TabIndex = 1;
            this.button_out.Text = "Реализация";
            this.button_out.UseVisualStyleBackColor = true;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 163);
            this.Controls.Add(this.button_out);
            this.Controls.Add(this.button_in);
            this.Name = "Shop";
            this.Text = "Магазин";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.Button button_out;
    }
}