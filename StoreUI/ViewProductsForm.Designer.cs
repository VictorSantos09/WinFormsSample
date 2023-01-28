namespace StoreUI
{
    partial class ViewProductsForm
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
            this.listProductsBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listProductsBox
            // 
            this.listProductsBox.FormattingEnabled = true;
            this.listProductsBox.ItemHeight = 30;
            this.listProductsBox.Location = new System.Drawing.Point(12, 69);
            this.listProductsBox.Name = "listProductsBox";
            this.listProductsBox.Size = new System.Drawing.Size(328, 274);
            this.listProductsBox.TabIndex = 0;
            // 
            // ViewProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.listProductsBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ViewProductsForm";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ViewProductsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listProductsBox;
    }
}