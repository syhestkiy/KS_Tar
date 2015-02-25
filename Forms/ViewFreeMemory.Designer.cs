namespace KS_Tar.Forms
{
    partial class ViewFreeMemoryForm
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
            this.DGVFreeMemoryView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFreeMemoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFreeMemoryView
            // 
            this.DGVFreeMemoryView.AllowUserToAddRows = false;
            this.DGVFreeMemoryView.AllowUserToDeleteRows = false;
            this.DGVFreeMemoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFreeMemoryView.Location = new System.Drawing.Point(13, 12);
            this.DGVFreeMemoryView.Name = "DGVFreeMemoryView";
            this.DGVFreeMemoryView.ReadOnly = true;
            this.DGVFreeMemoryView.Size = new System.Drawing.Size(331, 198);
            this.DGVFreeMemoryView.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(269, 221);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ViewFreeMemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 256);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DGVFreeMemoryView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewFreeMemoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Free memory ";
            ((System.ComponentModel.ISupportInitialize)(this.DGVFreeMemoryView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFreeMemoryView;
        private System.Windows.Forms.Button btnClose;
    }
}