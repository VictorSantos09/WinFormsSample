namespace StoreUI
{
    partial class RemoveProductForm
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
            this.removeItemButton = new System.Windows.Forms.Button();
            this.itensCheckBox = new System.Windows.Forms.CheckedListBox();
            this.AllItensCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(500, 362);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(147, 43);
            this.removeItemButton.TabIndex = 2;
            this.removeItemButton.Text = "Apagar";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // itensCheckBox
            // 
            this.itensCheckBox.FormattingEnabled = true;
            this.itensCheckBox.Location = new System.Drawing.Point(28, 131);
            this.itensCheckBox.Name = "itensCheckBox";
            this.itensCheckBox.Size = new System.Drawing.Size(316, 244);
            this.itensCheckBox.TabIndex = 3;
            // 
            // AllItensCheckBox
            // 
            this.AllItensCheckBox.AutoSize = true;
            this.AllItensCheckBox.Location = new System.Drawing.Point(214, 67);
            this.AllItensCheckBox.Name = "AllItensCheckBox";
            this.AllItensCheckBox.Size = new System.Drawing.Size(86, 34);
            this.AllItensCheckBox.TabIndex = 1;
            this.AllItensCheckBox.Text = "Todos";
            this.AllItensCheckBox.UseVisualStyleBackColor = true;
            this.AllItensCheckBox.CheckedChanged += new System.EventHandler(this.AllItensCheckBox_CheckedChanged);
            // 
            // RemoveProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.AllItensCheckBox);
            this.Controls.Add(this.itensCheckBox);
            this.Controls.Add(this.removeItemButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RemoveProductForm";
            this.Text = "RemoveProductForm";
            this.Load += new System.EventHandler(this.RemoveProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button removeItemButton;
        private CheckedListBox itensCheckBox;
        private CheckBox AllItensCheckBox;
    }
}