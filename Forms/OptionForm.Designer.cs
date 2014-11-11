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
            this.richTxtBoxMessage = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 20);
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
            // richTxtBoxMessage
            // 
            this.richTxtBoxMessage.Location = new System.Drawing.Point(15, 82);
            this.richTxtBoxMessage.Name = "richTxtBoxMessage";
            this.richTxtBoxMessage.Size = new System.Drawing.Size(267, 130);
            this.richTxtBoxMessage.TabIndex = 2;
            this.richTxtBoxMessage.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 66);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(79, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Повідомлення";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 249);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.richTxtBoxMessage);
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
        private System.Windows.Forms.RichTextBox richTxtBoxMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}