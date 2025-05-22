namespace GUI
{
    partial class fStatistic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvtheLoai = new System.Windows.Forms.DataGridView();
            this.Total_Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.Total_Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.Total_Publishers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartSach = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTaiKhoan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 579);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvtheLoai);
            this.tabPage1.Controls.Add(this.dgvTacGia);
            this.tabPage1.Controls.Add(this.dgvNXB);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvtheLoai
            // 
            this.dgvtheLoai.AllowUserToAddRows = false;
            this.dgvtheLoai.AllowUserToDeleteRows = false;
            this.dgvtheLoai.AllowUserToResizeColumns = false;
            this.dgvtheLoai.AllowUserToResizeRows = false;
            this.dgvtheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtheLoai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Total_Categories});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtheLoai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtheLoai.Location = new System.Drawing.Point(711, 202);
            this.dgvtheLoai.Name = "dgvtheLoai";
            this.dgvtheLoai.ReadOnly = true;
            this.dgvtheLoai.RowHeadersVisible = false;
            this.dgvtheLoai.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtheLoai.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtheLoai.RowTemplate.Height = 24;
            this.dgvtheLoai.Size = new System.Drawing.Size(240, 150);
            this.dgvtheLoai.TabIndex = 4;
            // 
            // Total_Categories
            // 
            this.Total_Categories.DataPropertyName = "Total_Categories";
            this.Total_Categories.HeaderText = "Tổng thể loại";
            this.Total_Categories.MinimumWidth = 6;
            this.Total_Categories.Name = "Total_Categories";
            this.Total_Categories.ReadOnly = true;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AllowUserToDeleteRows = false;
            this.dgvTacGia.AllowUserToResizeColumns = false;
            this.dgvTacGia.AllowUserToResizeRows = false;
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Total_Authors});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTacGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTacGia.Location = new System.Drawing.Point(711, 6);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.RowHeadersVisible = false;
            this.dgvTacGia.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTacGia.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.Size = new System.Drawing.Size(240, 150);
            this.dgvTacGia.TabIndex = 3;
            // 
            // Total_Authors
            // 
            this.Total_Authors.DataPropertyName = "Total_Authors";
            this.Total_Authors.HeaderText = "Tổng tác giả";
            this.Total_Authors.MinimumWidth = 6;
            this.Total_Authors.Name = "Total_Authors";
            this.Total_Authors.ReadOnly = true;
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AllowUserToDeleteRows = false;
            this.dgvNXB.AllowUserToResizeColumns = false;
            this.dgvNXB.AllowUserToResizeRows = false;
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Total_Publishers});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNXB.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNXB.Location = new System.Drawing.Point(711, 392);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            this.dgvNXB.RowHeadersVisible = false;
            this.dgvNXB.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvNXB.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNXB.RowTemplate.Height = 24;
            this.dgvNXB.Size = new System.Drawing.Size(240, 150);
            this.dgvNXB.TabIndex = 2;
            // 
            // Total_Publishers
            // 
            this.Total_Publishers.DataPropertyName = "Total_Publishers";
            this.Total_Publishers.HeaderText = "Tổng nhà xuất bản";
            this.Total_Publishers.MinimumWidth = 6;
            this.Total_Publishers.Name = "Total_Publishers";
            this.Total_Publishers.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartSach);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 541);
            this.panel2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(959, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tài khoản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartTaiKhoan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 541);
            this.panel3.TabIndex = 2;
            // 
            // chartSach
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSach.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSach.Legends.Add(legend1);
            this.chartSach.Location = new System.Drawing.Point(0, 0);
            this.chartSach.Name = "chartSach";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "SachSeries";
            this.chartSach.Series.Add(series1);
            this.chartSach.Size = new System.Drawing.Size(699, 541);
            this.chartSach.TabIndex = 0;
            this.chartSach.Text = "chart1";
            // 
            // chartTaiKhoan
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTaiKhoan.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTaiKhoan.Legends.Add(legend2);
            this.chartTaiKhoan.Location = new System.Drawing.Point(1, 2);
            this.chartTaiKhoan.Name = "chartTaiKhoan";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "TaiKhoanSeries";
            this.chartTaiKhoan.Series.Add(series2);
            this.chartTaiKhoan.Size = new System.Drawing.Size(952, 539);
            this.chartTaiKhoan.TabIndex = 0;
            this.chartTaiKhoan.Text = "chart1";
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStatistic";
            this.Text = "fStatistic";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvtheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Categories;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Authors;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Publishers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSach;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTaiKhoan;
    }
}