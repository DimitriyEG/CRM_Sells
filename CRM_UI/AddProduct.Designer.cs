namespace CRM_UI
{
    partial class AddProduct
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
            this.AddProductAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNameBox = new System.Windows.Forms.TextBox();
            this.AddPriceBox = new System.Windows.Forms.NumericUpDown();
            this.AddCountBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AddPriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductAccept
            // 
            this.AddProductAccept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddProductAccept.Location = new System.Drawing.Point(184, 157);
            this.AddProductAccept.Name = "AddProductAccept";
            this.AddProductAccept.Size = new System.Drawing.Size(75, 23);
            this.AddProductAccept.TabIndex = 0;
            this.AddProductAccept.Text = "Добавить";
            this.AddProductAccept.UseVisualStyleBackColor = true;
            this.AddProductAccept.Click += new System.EventHandler(this.AddProductAccept_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество";
            // 
            // AddNameBox
            // 
            this.AddNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNameBox.Location = new System.Drawing.Point(230, 26);
            this.AddNameBox.Name = "AddNameBox";
            this.AddNameBox.Size = new System.Drawing.Size(120, 20);
            this.AddNameBox.TabIndex = 4;
            // 
            // AddPriceBox
            // 
            this.AddPriceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPriceBox.DecimalPlaces = 2;
            this.AddPriceBox.Location = new System.Drawing.Point(230, 60);
            this.AddPriceBox.Name = "AddPriceBox";
            this.AddPriceBox.Size = new System.Drawing.Size(120, 20);
            this.AddPriceBox.TabIndex = 7;
            // 
            // AddCountBox
            // 
            this.AddCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCountBox.Location = new System.Drawing.Point(230, 96);
            this.AddCountBox.Name = "AddCountBox";
            this.AddCountBox.Size = new System.Drawing.Size(120, 20);
            this.AddCountBox.TabIndex = 8;
            // 
            // AddProduct
            // 
            this.AcceptButton = this.AddProductAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 248);
            this.Controls.Add(this.AddCountBox);
            this.Controls.Add(this.AddPriceBox);
            this.Controls.Add(this.AddNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddProductAccept);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.AddPriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddNameBox;
        private System.Windows.Forms.NumericUpDown AddPriceBox;
        private System.Windows.Forms.NumericUpDown AddCountBox;
    }
}