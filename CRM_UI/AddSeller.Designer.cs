namespace CRM_UI
{
    partial class AddSeller
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
            this.SellerAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SellerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SellerAdd
            // 
            this.SellerAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SellerAdd.Location = new System.Drawing.Point(148, 116);
            this.SellerAdd.Name = "SellerAdd";
            this.SellerAdd.Size = new System.Drawing.Size(75, 23);
            this.SellerAdd.TabIndex = 0;
            this.SellerAdd.Text = "Добавить";
            this.SellerAdd.UseVisualStyleBackColor = true;
            this.SellerAdd.Click += new System.EventHandler(this.SellerAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить продавца";
            // 
            // SellerName
            // 
            this.SellerName.Location = new System.Drawing.Point(232, 47);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(100, 20);
            this.SellerName.TabIndex = 2;
            // 
            // AddSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 195);
            this.Controls.Add(this.SellerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellerAdd);
            this.Name = "AddSeller";
            this.Text = "AddSeller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SellerAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SellerName;
    }
}