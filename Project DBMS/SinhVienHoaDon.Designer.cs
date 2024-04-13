namespace Project_DBMS
{
    partial class SinhVienHoaDon
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel8 = new Panel();
            thanhToan_check = new Guna.UI2.WinForms.Guna2RadioButton();
            Status_Label = new Label();
            panel7 = new Panel();
            NgayTao_tb = new TextBox();
            NgayTaoHoaDon_Label = new Label();
            panel5 = new Panel();
            PTTT_tb = new TextBox();
            pttt_Label = new Label();
            panel6 = new Panel();
            LoaiHoaDon_tb = new TextBox();
            LoaiHoaDon_Label = new Label();
            panel3 = new Panel();
            MaHoaDon_tb = new TextBox();
            MaHoaDon_Label = new Label();
            panel2 = new Panel();
            SinhVienListHoaDon = new DataGridView();
            MaHoaDon_Col = new DataGridViewTextBoxColumn();
            TypeHoaDon_Col = new DataGridViewTextBoxColumn();
            NgayTaoHoaDon_Col = new DataGridViewTextBoxColumn();
            Pttt_Col = new DataGridViewTextBoxColumn();
            img_Col = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SinhVienListHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 122);
            panel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(thanhToan_check);
            panel8.Controls.Add(Status_Label);
            panel8.Location = new Point(0, 61);
            panel8.Name = "panel8";
            panel8.Size = new Size(266, 57);
            panel8.TabIndex = 5;
            // 
            // thanhToan_check
            // 
            thanhToan_check.AutoSize = true;
            thanhToan_check.Checked = true;
            thanhToan_check.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            thanhToan_check.CheckedState.BorderThickness = 0;
            thanhToan_check.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            thanhToan_check.CheckedState.InnerColor = Color.White;
            thanhToan_check.CheckedState.InnerOffset = -4;
            thanhToan_check.Location = new Point(116, 16);
            thanhToan_check.Name = "thanhToan_check";
            thanhToan_check.Size = new Size(124, 24);
            thanhToan_check.TabIndex = 3;
            thanhToan_check.TabStop = true;
            thanhToan_check.Text = "Đã thanh toán";
            thanhToan_check.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            thanhToan_check.UncheckedState.BorderThickness = 2;
            thanhToan_check.UncheckedState.FillColor = Color.Transparent;
            thanhToan_check.UncheckedState.InnerColor = Color.Transparent;
            // 
            // Status_Label
            // 
            Status_Label.AutoSize = true;
            Status_Label.Location = new Point(12, 18);
            Status_Label.Name = "Status_Label";
            Status_Label.Size = new Size(75, 20);
            Status_Label.TabIndex = 1;
            Status_Label.Text = "Trạng thái";
            // 
            // panel7
            // 
            panel7.Controls.Add(NgayTao_tb);
            panel7.Controls.Add(NgayTaoHoaDon_Label);
            panel7.Location = new Point(737, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(266, 57);
            panel7.TabIndex = 6;
            // 
            // NgayTao_tb
            // 
            NgayTao_tb.Location = new Point(88, 14);
            NgayTao_tb.Name = "NgayTao_tb";
            NgayTao_tb.ReadOnly = true;
            NgayTao_tb.Size = new Size(166, 27);
            NgayTao_tb.TabIndex = 2;
            // 
            // NgayTaoHoaDon_Label
            // 
            NgayTaoHoaDon_Label.AutoSize = true;
            NgayTaoHoaDon_Label.Location = new Point(12, 18);
            NgayTaoHoaDon_Label.Name = "NgayTaoHoaDon_Label";
            NgayTaoHoaDon_Label.Size = new Size(70, 20);
            NgayTaoHoaDon_Label.TabIndex = 1;
            NgayTaoHoaDon_Label.Text = "Ngày tạo";
            // 
            // panel5
            // 
            panel5.Controls.Add(PTTT_tb);
            panel5.Controls.Add(pttt_Label);
            panel5.Location = new Point(272, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(459, 57);
            panel5.TabIndex = 7;
            // 
            // PTTT_tb
            // 
            PTTT_tb.Location = new Point(184, 12);
            PTTT_tb.Name = "PTTT_tb";
            PTTT_tb.ReadOnly = true;
            PTTT_tb.Size = new Size(245, 27);
            PTTT_tb.TabIndex = 1;
            // 
            // pttt_Label
            // 
            pttt_Label.AutoSize = true;
            pttt_Label.Location = new Point(10, 19);
            pttt_Label.Name = "pttt_Label";
            pttt_Label.Size = new Size(168, 20);
            pttt_Label.TabIndex = 1;
            pttt_Label.Text = "Phương thức thanh toán";
            // 
            // panel6
            // 
            panel6.Controls.Add(LoaiHoaDon_tb);
            panel6.Controls.Add(LoaiHoaDon_Label);
            panel6.Location = new Point(272, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(459, 57);
            panel6.TabIndex = 9;
            // 
            // LoaiHoaDon_tb
            // 
            LoaiHoaDon_tb.Location = new Point(184, 12);
            LoaiHoaDon_tb.Name = "LoaiHoaDon_tb";
            LoaiHoaDon_tb.ReadOnly = true;
            LoaiHoaDon_tb.Size = new Size(245, 27);
            LoaiHoaDon_tb.TabIndex = 1;
            // 
            // LoaiHoaDon_Label
            // 
            LoaiHoaDon_Label.AutoSize = true;
            LoaiHoaDon_Label.Location = new Point(10, 19);
            LoaiHoaDon_Label.Name = "LoaiHoaDon_Label";
            LoaiHoaDon_Label.Size = new Size(96, 20);
            LoaiHoaDon_Label.TabIndex = 1;
            LoaiHoaDon_Label.Text = "Loại hóa đơn";
            // 
            // panel3
            // 
            panel3.Controls.Add(MaHoaDon_tb);
            panel3.Controls.Add(MaHoaDon_Label);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 57);
            panel3.TabIndex = 4;
            // 
            // MaHoaDon_tb
            // 
            MaHoaDon_tb.Location = new Point(109, 12);
            MaHoaDon_tb.Name = "MaHoaDon_tb";
            MaHoaDon_tb.ReadOnly = true;
            MaHoaDon_tb.Size = new Size(140, 27);
            MaHoaDon_tb.TabIndex = 1;
            // 
            // MaHoaDon_Label
            // 
            MaHoaDon_Label.AutoSize = true;
            MaHoaDon_Label.Location = new Point(12, 18);
            MaHoaDon_Label.Name = "MaHoaDon_Label";
            MaHoaDon_Label.Size = new Size(89, 20);
            MaHoaDon_Label.TabIndex = 1;
            MaHoaDon_Label.Text = "Mã hóa đơn";
            // 
            // panel2
            // 
            panel2.Controls.Add(SinhVienListHoaDon);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(1003, 573);
            panel2.TabIndex = 1;
            // 
            // SinhVienListHoaDon
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SinhVienListHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SinhVienListHoaDon.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SinhVienListHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SinhVienListHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SinhVienListHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon_Col, TypeHoaDon_Col, NgayTaoHoaDon_Col, Pttt_Col, img_Col });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SinhVienListHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            SinhVienListHoaDon.Location = new Point(0, 4);
            SinhVienListHoaDon.Name = "SinhVienListHoaDon";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            SinhVienListHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            SinhVienListHoaDon.RowHeadersVisible = false;
            SinhVienListHoaDon.RowHeadersWidth = 51;
            SinhVienListHoaDon.Size = new Size(1003, 539);
            SinhVienListHoaDon.TabIndex = 2;
            // 
            // MaHoaDon_Col
            // 
            MaHoaDon_Col.FillWeight = 75F;
            MaHoaDon_Col.HeaderText = "Mã hóa đơn";
            MaHoaDon_Col.MinimumWidth = 6;
            MaHoaDon_Col.Name = "MaHoaDon_Col";
            MaHoaDon_Col.Width = 160;
            // 
            // TypeHoaDon_Col
            // 
            TypeHoaDon_Col.FillWeight = 119.777786F;
            TypeHoaDon_Col.HeaderText = "Loại hóa đơn";
            TypeHoaDon_Col.MinimumWidth = 6;
            TypeHoaDon_Col.Name = "TypeHoaDon_Col";
            TypeHoaDon_Col.Width = 220;
            // 
            // NgayTaoHoaDon_Col
            // 
            NgayTaoHoaDon_Col.FillWeight = 85.75F;
            NgayTaoHoaDon_Col.HeaderText = "Ngày tạo";
            NgayTaoHoaDon_Col.MinimumWidth = 6;
            NgayTaoHoaDon_Col.Name = "NgayTaoHoaDon_Col";
            NgayTaoHoaDon_Col.Width = 190;
            // 
            // Pttt_Col
            // 
            Pttt_Col.FillWeight = 126.583336F;
            Pttt_Col.HeaderText = "Phương thức thanh toán";
            Pttt_Col.MinimumWidth = 6;
            Pttt_Col.Name = "Pttt_Col";
            Pttt_Col.Width = 230;
            // 
            // img_Col
            // 
            img_Col.FillWeight = 115.69445F;
            img_Col.HeaderText = "Trạng thái thanh toán";
            img_Col.MinimumWidth = 6;
            img_Col.Name = "img_Col";
            img_Col.Resizable = DataGridViewTriState.True;
            img_Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            img_Col.Width = 200;
            // 
            // SinhVienHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 697);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SinhVienHoaDon";
            Text = "SinhVienHoaDon";
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SinhVienListHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel8;
        private Label Status_Label;
        private Panel panel7;
        private Label NgayTaoHoaDon_Label;
        private Panel panel6;
        private TextBox LoaiHoaDon_tb;
        private Label LoaiHoaDon_Label;
        private Panel panel5;
        private TextBox PTTT_tb;
        private Label pttt_Label;
        private Panel panel3;
        private TextBox MaHoaDon_tb;
        private Label MaHoaDon_Label;
        private Panel panel2;
        private TextBox NgayTao_tb;
        private DataGridView SinhVienListHoaDon;
        private Guna.UI2.WinForms.Guna2RadioButton thanhToan_check;
        private DataGridViewTextBoxColumn MaHoaDon_Col;
        private DataGridViewTextBoxColumn TypeHoaDon_Col;
        private DataGridViewTextBoxColumn NgayTaoHoaDon_Col;
        private DataGridViewTextBoxColumn Pttt_Col;
        private DataGridViewTextBoxColumn img_Col;
    }
}