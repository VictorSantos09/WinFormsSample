namespace StoreUI
{
    partial class RegisterForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.storeNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.phoneNumberText = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(207, 15);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(80, 32);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Nome";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.Location = new System.Drawing.Point(124, 100);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(163, 32);
            this.storeNameLabel.TabIndex = 1;
            this.storeNameLabel.Text = "Nome da Loja";
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(331, 12);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(282, 39);
            this.userNameText.TabIndex = 1;
            // 
            // storeNameText
            // 
            this.storeNameText.Location = new System.Drawing.Point(331, 97);
            this.storeNameText.Name = "storeNameText";
            this.storeNameText.Size = new System.Drawing.Size(282, 39);
            this.storeNameText.TabIndex = 2;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(331, 179);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(282, 39);
            this.emailText.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(216, 182);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(71, 32);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(331, 262);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(282, 39);
            this.passwordText.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(207, 265);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 32);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Senha";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.Location = new System.Drawing.Point(331, 349);
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(282, 39);
            this.phoneNumberText.TabIndex = 5;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(181, 349);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(106, 32);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Telefone";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(311, 406);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(174, 43);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "CADASTRAR";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.phoneNumberText);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.storeNameText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.storeNameLabel);
            this.Controls.Add(this.userNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegisterForm";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userNameLabel;
        private Label storeNameLabel;
        private TextBox userNameText;
        private TextBox storeNameText;
        private TextBox emailText;
        private Label emailLabel;
        private TextBox passwordText;
        private Label passwordLabel;
        private TextBox phoneNumberText;
        private Label phoneNumberLabel;
        private Button registerButton;
    }
}