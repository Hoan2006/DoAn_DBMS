namespace GUI
{
    partial class fSearchAccountUtil
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
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.inpAccName = new System.Windows.Forms.TextBox();
            this.inpAccEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToResizeColumns = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearch.Location = new System.Drawing.Point(0, 87);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(800, 363);
            this.dgvSearch.TabIndex = 2;
            // 
            // inpAccName
            // 
            this.inpAccName.Location = new System.Drawing.Point(142, 25);
            this.inpAccName.Name = "inpAccName";
            this.inpAccName.Size = new System.Drawing.Size(237, 22);
            this.inpAccName.TabIndex = 27;
            // 
            // inpAccEmail
            // 
            this.inpAccEmail.Location = new System.Drawing.Point(486, 23);
            this.inpAccEmail.Name = "inpAccEmail";
            this.inpAccEmail.Size = new System.Drawing.Size(237, 22);
            this.inpAccEmail.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label7.Location = new System.Drawing.Point(29, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tên tài khoản";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label10.Location = new System.Drawing.Point(431, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Email";
            // 
            // fSearchAccountUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inpAccEmail);
            this.Controls.Add(this.inpAccName);
            this.Controls.Add(this.dgvSearch);
            this.Name = "fSearchAccountUtil";
            this.Text = "fSearchAccountUtil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.TextBox inpAccName;
        private System.Windows.Forms.TextBox inpAccEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}