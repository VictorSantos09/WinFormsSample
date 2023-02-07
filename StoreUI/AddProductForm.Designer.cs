namespace StoreUI
{
    partial class AddProductForm
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
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.itemAmountValue = new System.Windows.Forms.NumericUpDown();
            this.itemQuantityLabel = new System.Windows.Forms.Label();
            this.itemNameText = new System.Windows.Forms.TextBox();
            this.itemPriceValue = new System.Windows.Forms.NumericUpDown();
            this.saveItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemAmountValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceValue)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(133, 115);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(180, 30);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Nome do Produto";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Location = new System.Drawing.Point(246, 177);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(59, 30);
            this.itemPriceLabel.TabIndex = 1;
            this.itemPriceLabel.Text = "Valor";
            // 
            // itemAmountValue
            // 
            this.itemAmountValue.Location = new System.Drawing.Point(320, 243);
            this.itemAmountValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.itemAmountValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.itemAmountValue.Name = "itemAmountValue";
            this.itemAmountValue.Size = new System.Drawing.Size(205, 35);
            this.itemAmountValue.TabIndex = 3;
            // 
            // itemQuantityLabel
            // 
            this.itemQuantityLabel.AutoSize = true;
            this.itemQuantityLabel.Location = new System.Drawing.Point(206, 245);
            this.itemQuantityLabel.Name = "itemQuantityLabel";
            this.itemQuantityLabel.Size = new System.Drawing.Size(99, 30);
            this.itemQuantityLabel.TabIndex = 3;
            this.itemQuantityLabel.Text = "Unidades";
            // 
            // itemNameText
            // 
            this.itemNameText.Location = new System.Drawing.Point(319, 112);
            this.itemNameText.Name = "itemNameText";
            this.itemNameText.Size = new System.Drawing.Size(205, 35);
            this.itemNameText.TabIndex = 1;
            // 
            // itemPriceValue
            // 
            this.itemPriceValue.Location = new System.Drawing.Point(319, 175);
            this.itemPriceValue.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.itemPriceValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.itemPriceValue.Name = "itemPriceValue";
            this.itemPriceValue.Size = new System.Drawing.Size(206, 35);
            this.itemPriceValue.TabIndex = 2;
            // 
            // saveItemButton
            // 
            this.saveItemButton.Location = new System.Drawing.Point(319, 327);
            this.saveItemButton.Name = "saveItemButton";
            this.saveItemButton.Size = new System.Drawing.Size(122, 42);
            this.saveItemButton.TabIndex = 4;
            this.saveItemButton.Text = "Salvar";
            this.saveItemButton.UseVisualStyleBackColor = true;
            this.saveItemButton.Click += new System.EventHandler(this.saveItemButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.saveItemButton);
            this.Controls.Add(this.itemPriceValue);
            this.Controls.Add(this.itemNameText);
            this.Controls.Add(this.itemQuantityLabel);
            this.Controls.Add(this.itemAmountValue);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.itemAmountValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label itemNameLabel;
        private Label itemPriceLabel;
        private NumericUpDown itemAmountValue;
        private Label itemQuantityLabel;
        private TextBox itemNameText;
        private NumericUpDown itemPriceValue;
        private Button saveItemButton;
        private Button button2;
        private NumericUpDown itemValue;
        private Label label4;
        private NumericUpDown numericUpDown4;
        private Label itemValueLabel;
    }
}