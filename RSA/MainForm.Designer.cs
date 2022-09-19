
namespace RSA
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.dOpen = new System.Windows.Forms.OpenFileDialog();
            this.bOpen = new System.Windows.Forms.Button();
            this.cbEncrypted = new System.Windows.Forms.CheckBox();
            this.dSave = new System.Windows.Forms.SaveFileDialog();
            this.tbOpenKey = new System.Windows.Forms.TextBox();
            this.lOpenKey = new System.Windows.Forms.Label();
            this.lPValue = new System.Windows.Forms.Label();
            this.tbPValue = new System.Windows.Forms.TextBox();
            this.lQValue = new System.Windows.Forms.Label();
            this.tbQValue = new System.Windows.Forms.TextBox();
            this.lRValue = new System.Windows.Forms.Label();
            this.tbRValue = new System.Windows.Forms.TextBox();
            this.lPrivateKey = new System.Windows.Forms.Label();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bEncrypt = new System.Windows.Forms.Button();
            this.bDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.Location = new System.Drawing.Point(60, 123);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(496, 538);
            this.tbInput.TabIndex = 0;
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOutput.Location = new System.Drawing.Point(768, 123);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(496, 538);
            this.tbOutput.TabIndex = 1;
            // 
            // dOpen
            // 
            this.dOpen.FileName = "openFileDialog1";
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(60, 13);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(139, 29);
            this.bOpen.TabIndex = 2;
            this.bOpen.Text = "Open file";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // cbEncrypted
            // 
            this.cbEncrypted.AutoSize = true;
            this.cbEncrypted.Location = new System.Drawing.Point(205, 19);
            this.cbEncrypted.Name = "cbEncrypted";
            this.cbEncrypted.Size = new System.Drawing.Size(98, 19);
            this.cbEncrypted.TabIndex = 3;
            this.cbEncrypted.Text = "Encrypted file";
            this.cbEncrypted.UseVisualStyleBackColor = true;
            // 
            // tbOpenKey
            // 
            this.tbOpenKey.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOpenKey.Location = new System.Drawing.Point(99, 65);
            this.tbOpenKey.Name = "tbOpenKey";
            this.tbOpenKey.Size = new System.Drawing.Size(100, 32);
            this.tbOpenKey.TabIndex = 4;
            // 
            // lOpenKey
            // 
            this.lOpenKey.AutoSize = true;
            this.lOpenKey.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOpenKey.Location = new System.Drawing.Point(46, 68);
            this.lOpenKey.Name = "lOpenKey";
            this.lOpenKey.Size = new System.Drawing.Size(47, 25);
            this.lOpenKey.TabIndex = 6;
            this.lOpenKey.Text = "Ko=";
            // 
            // lPValue
            // 
            this.lPValue.AutoSize = true;
            this.lPValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPValue.Location = new System.Drawing.Point(414, 68);
            this.lPValue.Name = "lPValue";
            this.lPValue.Size = new System.Drawing.Size(36, 25);
            this.lPValue.TabIndex = 8;
            this.lPValue.Text = "p=";
            // 
            // tbPValue
            // 
            this.tbPValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPValue.Location = new System.Drawing.Point(456, 65);
            this.tbPValue.Name = "tbPValue";
            this.tbPValue.Size = new System.Drawing.Size(100, 32);
            this.tbPValue.TabIndex = 7;
            // 
            // lQValue
            // 
            this.lQValue.AutoSize = true;
            this.lQValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lQValue.Location = new System.Drawing.Point(766, 68);
            this.lQValue.Name = "lQValue";
            this.lQValue.Size = new System.Drawing.Size(36, 25);
            this.lQValue.TabIndex = 10;
            this.lQValue.Text = "q=";
            // 
            // tbQValue
            // 
            this.tbQValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQValue.Location = new System.Drawing.Point(808, 65);
            this.tbQValue.Name = "tbQValue";
            this.tbQValue.Size = new System.Drawing.Size(100, 32);
            this.tbQValue.TabIndex = 9;
            // 
            // lRValue
            // 
            this.lRValue.AutoSize = true;
            this.lRValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lRValue.Location = new System.Drawing.Point(592, 68);
            this.lRValue.Name = "lRValue";
            this.lRValue.Size = new System.Drawing.Size(32, 25);
            this.lRValue.TabIndex = 12;
            this.lRValue.Text = "r=";
            // 
            // tbRValue
            // 
            this.tbRValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRValue.Location = new System.Drawing.Point(634, 65);
            this.tbRValue.Name = "tbRValue";
            this.tbRValue.Size = new System.Drawing.Size(100, 32);
            this.tbRValue.TabIndex = 11;
            // 
            // lPrivateKey
            // 
            this.lPrivateKey.AutoSize = true;
            this.lPrivateKey.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPrivateKey.Location = new System.Drawing.Point(1111, 68);
            this.lPrivateKey.Name = "lPrivateKey";
            this.lPrivateKey.Size = new System.Drawing.Size(47, 25);
            this.lPrivateKey.TabIndex = 14;
            this.lPrivateKey.Text = "Kp=";
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPrivateKey.Location = new System.Drawing.Point(1164, 65);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(100, 32);
            this.tbPrivateKey.TabIndex = 13;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(766, 13);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(139, 29);
            this.bSave.TabIndex = 15;
            this.bSave.Text = "Save as";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEncrypt
            // 
            this.bEncrypt.Location = new System.Drawing.Point(606, 301);
            this.bEncrypt.Name = "bEncrypt";
            this.bEncrypt.Size = new System.Drawing.Size(107, 38);
            this.bEncrypt.TabIndex = 16;
            this.bEncrypt.Text = "Encrypt";
            this.bEncrypt.UseVisualStyleBackColor = true;
            this.bEncrypt.Click += new System.EventHandler(this.bEncrypt_Click);
            // 
            // bDecrypt
            // 
            this.bDecrypt.Location = new System.Drawing.Point(606, 375);
            this.bDecrypt.Name = "bDecrypt";
            this.bDecrypt.Size = new System.Drawing.Size(107, 39);
            this.bDecrypt.TabIndex = 17;
            this.bDecrypt.Text = "Decrypt";
            this.bDecrypt.UseVisualStyleBackColor = true;
            this.bDecrypt.Click += new System.EventHandler(this.bDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 737);
            this.Controls.Add(this.bDecrypt);
            this.Controls.Add(this.bEncrypt);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lPrivateKey);
            this.Controls.Add(this.tbPrivateKey);
            this.Controls.Add(this.lRValue);
            this.Controls.Add(this.tbRValue);
            this.Controls.Add(this.lQValue);
            this.Controls.Add(this.tbQValue);
            this.Controls.Add(this.lPValue);
            this.Controls.Add(this.tbPValue);
            this.Controls.Add(this.lOpenKey);
            this.Controls.Add(this.tbOpenKey);
            this.Controls.Add(this.cbEncrypted);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.OpenFileDialog dOpen;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.CheckBox cbEncrypted;
        private System.Windows.Forms.SaveFileDialog dSave;
        private System.Windows.Forms.TextBox tbOpenKey;
        private System.Windows.Forms.Label lOpenKey;
        private System.Windows.Forms.Label lPValue;
        private System.Windows.Forms.TextBox tbPValue;
        private System.Windows.Forms.Label lQValue;
        private System.Windows.Forms.TextBox tbQValue;
        private System.Windows.Forms.Label lRValue;
        private System.Windows.Forms.TextBox tbRValue;
        private System.Windows.Forms.Label lPrivateKey;
        private System.Windows.Forms.TextBox tbPrivateKey;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEncrypt;
        private System.Windows.Forms.Button bDecrypt;
    }
}

