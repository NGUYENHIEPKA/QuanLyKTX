namespace Project_DBMS
{
    partial class fQuanLyPhong
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyPhong));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView = new DataGridView();
            panel2 = new Panel();
            MSSV_tb = new TextBox();
            MaPhong_Label = new Label();
            panel3 = new Panel();
            LoaiPhongcb = new ComboBox();
            Loaiphong_Label = new Label();
            panel4 = new Panel();
            SVHT_tb = new TextBox();
            SVHienTai_Label = new Label();
            GiaPhong_tb = new TextBox();
            GiaPhong_Label = new Label();
            Renew_Btn = new Guna.UI2.WinForms.Guna2Button();
            Delete_Btn = new Guna.UI2.WinForms.Guna2Button();
            Edit_Btn = new Guna.UI2.WinForms.Guna2Button();
            Add_Btn = new Guna.UI2.WinForms.Guna2Button();
            panel8 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            MaPhong_Col = new DataGridViewTextBoxColumn();
            LoaiPhong_Col = new DataGridViewTextBoxColumn();
            SVHT_Col = new DataGridViewTextBoxColumn();
            GiaPhong_Col = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaPhong_Col, LoaiPhong_Col, SVHT_Col, GiaPhong_Col });
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1003, 513);
            dataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(1003, 513);
            panel2.TabIndex = 3;
            // 
            // MSSV_tb
            // 
            MSSV_tb.Location = new Point(109, 12);
            MSSV_tb.Name = "MSSV_tb";
            MSSV_tb.Size = new Size(140, 27);
            MSSV_tb.TabIndex = 1;
            // 
            // MaPhong_Label
            // 
            MaPhong_Label.AutoSize = true;
            MaPhong_Label.Location = new Point(12, 18);
            MaPhong_Label.Name = "MaPhong_Label";
            MaPhong_Label.Size = new Size(76, 20);
            MaPhong_Label.TabIndex = 1;
            MaPhong_Label.Text = "Mã Phòng";
            // 
            // panel3
            // 
            panel3.Controls.Add(MSSV_tb);
            panel3.Controls.Add(MaPhong_Label);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 57);
            panel3.TabIndex = 0;
            // 
            // LoaiPhongcb
            // 
            LoaiPhongcb.FormattingEnabled = true;
            LoaiPhongcb.Location = new Point(109, 15);
            LoaiPhongcb.Name = "LoaiPhongcb";
            LoaiPhongcb.Size = new Size(140, 28);
            LoaiPhongcb.TabIndex = 3;
            // 
            // Loaiphong_Label
            // 
            Loaiphong_Label.AutoSize = true;
            Loaiphong_Label.Location = new Point(12, 18);
            Loaiphong_Label.Name = "Loaiphong_Label";
            Loaiphong_Label.Size = new Size(83, 20);
            Loaiphong_Label.TabIndex = 1;
            Loaiphong_Label.Text = "Loại Phòng";
            // 
            // panel4
            // 
            panel4.Controls.Add(LoaiPhongcb);
            panel4.Controls.Add(Loaiphong_Label);
            panel4.Location = new Point(262, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 57);
            panel4.TabIndex = 2;
            // 
            // SVHT_tb
            // 
            SVHT_tb.Location = new Point(109, 12);
            SVHT_tb.Name = "SVHT_tb";
            SVHT_tb.Size = new Size(140, 27);
            SVHT_tb.TabIndex = 1;
            // 
            // SVHienTai_Label
            // 
            SVHienTai_Label.AutoSize = true;
            SVHienTai_Label.Location = new Point(10, 19);
            SVHienTai_Label.Name = "SVHienTai_Label";
            SVHienTai_Label.Size = new Size(77, 20);
            SVHienTai_Label.TabIndex = 1;
            SVHienTai_Label.Text = "Số SVHHT";
            // 
            // GiaPhong_tb
            // 
            GiaPhong_tb.Location = new Point(109, 12);
            GiaPhong_tb.Name = "GiaPhong_tb";
            GiaPhong_tb.Size = new Size(140, 27);
            GiaPhong_tb.TabIndex = 1;
            // 
            // GiaPhong_Label
            // 
            GiaPhong_Label.AutoSize = true;
            GiaPhong_Label.Location = new Point(12, 18);
            GiaPhong_Label.Name = "GiaPhong_Label";
            GiaPhong_Label.Size = new Size(77, 20);
            GiaPhong_Label.TabIndex = 1;
            GiaPhong_Label.Text = "Giá Phòng";
            // 
            // Renew_Btn
            // 
            Renew_Btn.CustomizableEdges = customizableEdges1;
            Renew_Btn.DisabledState.BorderColor = Color.DarkGray;
            Renew_Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Renew_Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Renew_Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Renew_Btn.FillColor = Color.White;
            Renew_Btn.Font = new Font("Segoe UI", 9F);
            Renew_Btn.ForeColor = Color.Black;
            Renew_Btn.Image = (Image)resources.GetObject("Renew_Btn.Image");
            Renew_Btn.ImageAlign = HorizontalAlignment.Left;
            Renew_Btn.Location = new Point(475, 126);
            Renew_Btn.Name = "Renew_Btn";
            Renew_Btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Renew_Btn.Size = new Size(123, 45);
            Renew_Btn.TabIndex = 7;
            Renew_Btn.Text = "Renew";
            // 
            // Delete_Btn
            // 
            Delete_Btn.CustomizableEdges = customizableEdges3;
            Delete_Btn.DisabledState.BorderColor = Color.DarkGray;
            Delete_Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Delete_Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Delete_Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Delete_Btn.FillColor = Color.White;
            Delete_Btn.Font = new Font("Segoe UI", 9F);
            Delete_Btn.ForeColor = Color.Black;
            Delete_Btn.Image = (Image)resources.GetObject("Delete_Btn.Image");
            Delete_Btn.ImageAlign = HorizontalAlignment.Left;
            Delete_Btn.Location = new Point(325, 126);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Delete_Btn.Size = new Size(123, 45);
            Delete_Btn.TabIndex = 6;
            Delete_Btn.Text = "Xóa";
            // 
            // Edit_Btn
            // 
            Edit_Btn.CustomizableEdges = customizableEdges5;
            Edit_Btn.DisabledState.BorderColor = Color.DarkGray;
            Edit_Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Edit_Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Edit_Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Edit_Btn.FillColor = Color.White;
            Edit_Btn.Font = new Font("Segoe UI", 9F);
            Edit_Btn.ForeColor = Color.Black;
            Edit_Btn.Image = (Image)resources.GetObject("Edit_Btn.Image");
            Edit_Btn.ImageAlign = HorizontalAlignment.Left;
            Edit_Btn.Location = new Point(175, 126);
            Edit_Btn.Name = "Edit_Btn";
            Edit_Btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Edit_Btn.Size = new Size(123, 45);
            Edit_Btn.TabIndex = 5;
            Edit_Btn.Text = "Sửa";
            // 
            // Add_Btn
            // 
            Add_Btn.CustomizableEdges = customizableEdges7;
            Add_Btn.DisabledState.BorderColor = Color.DarkGray;
            Add_Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Add_Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Add_Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Add_Btn.FillColor = Color.White;
            Add_Btn.Font = new Font("Segoe UI", 9F);
            Add_Btn.ForeColor = Color.Black;
            Add_Btn.Image = (Image)resources.GetObject("Add_Btn.Image");
            Add_Btn.ImageAlign = HorizontalAlignment.Left;
            Add_Btn.Location = new Point(25, 126);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Add_Btn.Size = new Size(123, 45);
            Add_Btn.TabIndex = 4;
            Add_Btn.Text = "Thêm";
            // 
            // panel8
            // 
            panel8.Controls.Add(GiaPhong_tb);
            panel8.Controls.Add(GiaPhong_Label);
            panel8.Location = new Point(0, 63);
            panel8.Name = "panel8";
            panel8.Size = new Size(266, 57);
            panel8.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(SVHT_tb);
            panel5.Controls.Add(SVHienTai_Label);
            panel5.Location = new Point(521, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 57);
            panel5.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(Renew_Btn);
            panel1.Controls.Add(Delete_Btn);
            panel1.Controls.Add(Edit_Btn);
            panel1.Controls.Add(Add_Btn);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 184);
            panel1.TabIndex = 2;
            // 
            // MaPhong_Col
            // 
            MaPhong_Col.HeaderText = "Mã Phòng";
            MaPhong_Col.MinimumWidth = 6;
            MaPhong_Col.Name = "MaPhong_Col";
            // 
            // LoaiPhong_Col
            // 
            LoaiPhong_Col.HeaderText = "Loại Phòng";
            LoaiPhong_Col.MinimumWidth = 6;
            LoaiPhong_Col.Name = "LoaiPhong_Col";
            // 
            // SVHT_Col
            // 
            SVHT_Col.HeaderText = "Số SVHT";
            SVHT_Col.MinimumWidth = 6;
            SVHT_Col.Name = "SVHT_Col";
            // 
            // GiaPhong_Col
            // 
            GiaPhong_Col.HeaderText = "Giá phòng";
            GiaPhong_Col.MinimumWidth = 6;
            GiaPhong_Col.Name = "GiaPhong_Col";
            // 
            // fQuanLyPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1003, 697);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fQuanLyPhong";
            Text = "fQuanLyPhong";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView;
        private Panel panel2;
        private TextBox MSSV_tb;
        private Label MaPhong_Label;
        private Panel panel3;
        private ComboBox LoaiPhongcb;
        private Label Loaiphong_Label;
        private Panel panel4;
        private TextBox SVHT_tb;
        private Label SVHienTai_Label;
        private TextBox GiaPhong_tb;
        private Label GiaPhong_Label;
        private Guna.UI2.WinForms.Guna2Button Renew_Btn;
        private Guna.UI2.WinForms.Guna2Button Delete_Btn;
        private Guna.UI2.WinForms.Guna2Button Edit_Btn;
        private Guna.UI2.WinForms.Guna2Button Add_Btn;
        private Panel panel8;
        private Panel panel5;
        private Panel panel1;
        private DataGridViewTextBoxColumn MaPhong_Col;
        private DataGridViewTextBoxColumn LoaiPhong_Col;
        private DataGridViewTextBoxColumn SVHT_Col;
        private DataGridViewTextBoxColumn GiaPhong_Col;
    }
}