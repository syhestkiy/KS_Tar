namespace KS_Tar.Forms
{
    partial class OptionForm
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMailToSand = new System.Windows.Forms.Label();
            this.richTxtMessage = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSenderEmail = new System.Windows.Forms.Label();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.lblEmailSubject = new System.Windows.Forms.Label();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.lblSenderEmailPass = new System.Windows.Forms.Label();
            this.txtSenderEmaiPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(15, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // lblMailToSand
            // 
            this.lblMailToSand.AutoSize = true;
            this.lblMailToSand.Location = new System.Drawing.Point(12, 13);
            this.lblMailToSand.Name = "lblMailToSand";
            this.lblMailToSand.Size = new System.Drawing.Size(185, 13);
            this.lblMailToSand.TabIndex = 1;
            this.lblMailToSand.Text = "Електронна пошта для сигналізації";
            // 
            // richTxtMessage
            // 
            this.richTxtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtMessage.Location = new System.Drawing.Point(15, 250);
            this.richTxtMessage.Name = "richTxtMessage";
            this.richTxtMessage.Size = new System.Drawing.Size(276, 154);
            this.richTxtMessage.TabIndex = 2;
            this.richTxtMessage.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 234);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(79, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Повідомлення";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(131, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(216, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSenderEmail
            // 
            this.lblSenderEmail.AutoSize = true;
            this.lblSenderEmail.Location = new System.Drawing.Point(12, 80);
            this.lblSenderEmail.Name = "lblSenderEmail";
            this.lblSenderEmail.Size = new System.Drawing.Size(136, 13);
            this.lblSenderEmail.TabIndex = 7;
            this.lblSenderEmail.Text = "Електронна пошта sender";
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenderEmail.Location = new System.Drawing.Point(15, 96);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(276, 20);
            this.txtSenderEmail.TabIndex = 6;
            // 
            // lblEmailSubject
            // 
            this.lblEmailSubject.AutoSize = true;
            this.lblEmailSubject.Location = new System.Drawing.Point(12, 195);
            this.lblEmailSubject.Name = "lblEmailSubject";
            this.lblEmailSubject.Size = new System.Drawing.Size(107, 13);
            this.lblEmailSubject.TabIndex = 11;
            this.lblEmailSubject.Text = "Тема повідомлення";
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailSubject.Location = new System.Drawing.Point(15, 211);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(276, 20);
            this.txtEmailSubject.TabIndex = 10;
            // 
            // lblSenderEmailPass
            // 
            this.lblSenderEmailPass.AutoSize = true;
            this.lblSenderEmailPass.Location = new System.Drawing.Point(12, 119);
            this.lblSenderEmailPass.Name = "lblSenderEmailPass";
            this.lblSenderEmailPass.Size = new System.Drawing.Size(48, 13);
            this.lblSenderEmailPass.TabIndex = 9;
            this.lblSenderEmailPass.Text = "Пароль ";
            // 
            // txtSenderEmaiPass
            // 
            this.txtSenderEmaiPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenderEmaiPass.Location = new System.Drawing.Point(15, 135);
            this.txtSenderEmaiPass.Name = "txtSenderEmaiPass";
            this.txtSenderEmaiPass.Size = new System.Drawing.Size(276, 20);
            this.txtSenderEmaiPass.TabIndex = 8;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 440);
            this.Controls.Add(this.lblEmailSubject);
            this.Controls.Add(this.txtEmailSubject);
            this.Controls.Add(this.lblSenderEmailPass);
            this.Controls.Add(this.txtSenderEmaiPass);
            this.Controls.Add(this.lblSenderEmail);
            this.Controls.Add(this.txtSenderEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.richTxtMessage);
            this.Controls.Add(this.lblMailToSand);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionForm";
            this.Text = "Налаштування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMailToSand;
        private System.Windows.Forms.RichTextBox richTxtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSenderEmail;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.Label lblEmailSubject;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.Label lblSenderEmailPass;
        private System.Windows.Forms.TextBox txtSenderEmaiPass;
    }
}