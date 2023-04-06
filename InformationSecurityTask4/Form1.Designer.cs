namespace InformationSecurityTask4
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VerifyInputTextBox = new System.Windows.Forms.TextBox();
            this.SignatureTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ExportPrivateKeyBtn = new System.Windows.Forms.Button();
            this.ExportPublicKeyBtn = new System.Windows.Forms.Button();
            this.ChangePrivateKeyBtn = new System.Windows.Forms.Button();
            this.VerifySignatureBtn = new System.Windows.Forms.Button();
            this.CalculateSignatureBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Verified input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Signature text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Plain text:";
            // 
            // VerifyInputTextBox
            // 
            this.VerifyInputTextBox.Location = new System.Drawing.Point(103, 88);
            this.VerifyInputTextBox.Name = "VerifyInputTextBox";
            this.VerifyInputTextBox.Size = new System.Drawing.Size(329, 23);
            this.VerifyInputTextBox.TabIndex = 18;
            // 
            // SignatureTextBox
            // 
            this.SignatureTextBox.Location = new System.Drawing.Point(103, 59);
            this.SignatureTextBox.Name = "SignatureTextBox";
            this.SignatureTextBox.Size = new System.Drawing.Size(329, 23);
            this.SignatureTextBox.TabIndex = 17;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(103, 30);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(329, 23);
            this.InputTextBox.TabIndex = 16;
            // 
            // ExportPrivateKeyBtn
            // 
            this.ExportPrivateKeyBtn.Location = new System.Drawing.Point(220, 185);
            this.ExportPrivateKeyBtn.Name = "ExportPrivateKeyBtn";
            this.ExportPrivateKeyBtn.Size = new System.Drawing.Size(116, 37);
            this.ExportPrivateKeyBtn.TabIndex = 15;
            this.ExportPrivateKeyBtn.Text = "Export private key";
            this.ExportPrivateKeyBtn.UseVisualStyleBackColor = true;
            // 
            // ExportPublicKeyBtn
            // 
            this.ExportPublicKeyBtn.Location = new System.Drawing.Point(98, 185);
            this.ExportPublicKeyBtn.Name = "ExportPublicKeyBtn";
            this.ExportPublicKeyBtn.Size = new System.Drawing.Size(116, 37);
            this.ExportPublicKeyBtn.TabIndex = 14;
            this.ExportPublicKeyBtn.Text = "Export public key";
            this.ExportPublicKeyBtn.UseVisualStyleBackColor = true;
            // 
            // ChangePrivateKeyBtn
            // 
            this.ChangePrivateKeyBtn.Location = new System.Drawing.Point(282, 142);
            this.ChangePrivateKeyBtn.Name = "ChangePrivateKeyBtn";
            this.ChangePrivateKeyBtn.Size = new System.Drawing.Size(116, 37);
            this.ChangePrivateKeyBtn.TabIndex = 13;
            this.ChangePrivateKeyBtn.Text = "Change private key";
            this.ChangePrivateKeyBtn.UseVisualStyleBackColor = true;
            // 
            // VerifySignatureBtn
            // 
            this.VerifySignatureBtn.Location = new System.Drawing.Point(160, 142);
            this.VerifySignatureBtn.Name = "VerifySignatureBtn";
            this.VerifySignatureBtn.Size = new System.Drawing.Size(116, 37);
            this.VerifySignatureBtn.TabIndex = 12;
            this.VerifySignatureBtn.Text = "Verify signature";
            this.VerifySignatureBtn.UseVisualStyleBackColor = true;
            // 
            // CalculateSignatureBtn
            // 
            this.CalculateSignatureBtn.Location = new System.Drawing.Point(38, 142);
            this.CalculateSignatureBtn.Name = "CalculateSignatureBtn";
            this.CalculateSignatureBtn.Size = new System.Drawing.Size(116, 37);
            this.CalculateSignatureBtn.TabIndex = 11;
            this.CalculateSignatureBtn.Text = "Calculate signature";
            this.CalculateSignatureBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerifyInputTextBox);
            this.Controls.Add(this.SignatureTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ExportPrivateKeyBtn);
            this.Controls.Add(this.ExportPublicKeyBtn);
            this.Controls.Add(this.ChangePrivateKeyBtn);
            this.Controls.Add(this.VerifySignatureBtn);
            this.Controls.Add(this.CalculateSignatureBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox VerifyInputTextBox;
        private TextBox SignatureTextBox;
        private TextBox InputTextBox;
        private Button ExportPrivateKeyBtn;
        private Button ExportPublicKeyBtn;
        private Button ChangePrivateKeyBtn;
        private Button VerifySignatureBtn;
        private Button CalculateSignatureBtn;
    }
}