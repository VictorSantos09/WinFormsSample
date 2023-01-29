namespace StoreUI
{
    partial class HomeForm
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.viewProductsButton = new System.Windows.Forms.Button();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helloLabel.Location = new System.Drawing.Point(44, 34);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(55, 30);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "OLÁ";
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.servicesLabel.Location = new System.Drawing.Point(338, 253);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(112, 30);
            this.servicesLabel.TabIndex = 2;
            this.servicesLabel.Text = "SERVIÇOS";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(38, 311);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(208, 46);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Adicionar Produto";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // removeProductButton
            // 
            this.removeProductButton.Location = new System.Drawing.Point(292, 311);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(208, 46);
            this.removeProductButton.TabIndex = 4;
            this.removeProductButton.Text = "Remover Produto";
            this.removeProductButton.UseVisualStyleBackColor = true;
            // 
            // viewProductsButton
            // 
            this.viewProductsButton.Location = new System.Drawing.Point(538, 311);
            this.viewProductsButton.Name = "viewProductsButton";
            this.viewProductsButton.Size = new System.Drawing.Size(208, 46);
            this.viewProductsButton.TabIndex = 5;
            this.viewProductsButton.Text = "Ver Produtos";
            this.viewProductsButton.UseVisualStyleBackColor = true;
            this.viewProductsButton.Click += new System.EventHandler(this.viewProductsButton_Click);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(44, 86);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(113, 30);
            this.PhoneNumberLabel.TabIndex = 6;
            this.PhoneNumberLabel.Text = "TELEFONE";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(44, 137);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(77, 30);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "EMAIL";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.viewProductsButton);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.servicesLabel);
            this.Controls.Add(this.helloLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "HomeForm";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label helloLabel;
        private Label servicesLabel;
        private Button addProductButton;
        private Button removeProductButton;
        private Button viewProductsButton;
        private Label PhoneNumberLabel;
        private Label emailLabel;
    }
}