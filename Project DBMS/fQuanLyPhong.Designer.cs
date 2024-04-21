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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView = new DataGridView();
            MaTang = new DataGridViewTextBoxColumn();
            MaPhong_Col = new DataGridViewTextBoxColumn();
            MaLoaiPhong = new DataGridViewTextBoxColumn();
            LoaiPhong_Col = new DataGridViewTextBoxColumn();
            SVHT_Col = new DataGridViewTextBoxColumn();
            GiaPhong_Col = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            MaPhong_tb = new TextBox();
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
            panel8 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            Update_Btn = new Guna.UI2.WinForms.Guna2Button();
            panel7 = new Panel();
            MaLoaiPhong_tb = new TextBox();
            label2 = new Label();
            panel6 = new Panel();
            Matang_tb = new TextBox();
            label1 = new Label();
            Edit_Btn = new Guna.UI2.WinForms.Guna2Button();
            Add_Btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaTang, MaPhong_Col, MaLoaiPhong, LoaiPhong_Col, SVHT_Col, GiaPhong_Col });
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
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1003, 513);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // MaTang
            // 
            MaTang.DataPropertyName = "MaTang";
            MaTang.HeaderText = "Mã Tầng";
            MaTang.MinimumWidth = 6;
            MaTang.Name = "MaTang";
            // 
            // MaPhong_Col
            // 
            MaPhong_Col.DataPropertyName = "MaPhong";
            MaPhong_Col.HeaderText = "Mã Phòng";
            MaPhong_Col.MinimumWidth = 6;
            MaPhong_Col.Name = "MaPhong_Col";
            // 
            // MaLoaiPhong
            // 
            MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            MaLoaiPhong.HeaderText = "Mã Loại Phòng";
            MaLoaiPhong.MinimumWidth = 6;
            MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // LoaiPhong_Col
            // 
            LoaiPhong_Col.DataPropertyName = "LoaiPhong";
            LoaiPhong_Col.HeaderText = "Loại Phòng";
            LoaiPhong_Col.MinimumWidth = 6;
            LoaiPhong_Col.Name = "LoaiPhong_Col";
            // 
            // SVHT_Col
            // 
            SVHT_Col.DataPropertyName = "SoNguoi";
            SVHT_Col.HeaderText = "Số SVHT";
            SVHT_Col.MinimumWidth = 6;
            SVHT_Col.Name = "SVHT_Col";
            // 
            // GiaPhong_Col
            // 
            GiaPhong_Col.DataPropertyName = "GiaTien";
            GiaPhong_Col.HeaderText = "Giá phòng";
            GiaPhong_Col.MinimumWidth = 6;
            GiaPhong_Col.Name = "GiaPhong_Col";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(1003, 497);
            panel2.TabIndex = 3;
            // 
            // MaPhong_tb
            // 
            MaPhong_tb.Location = new Point(94, 12);
            MaPhong_tb.Name = "MaPhong_tb";
            MaPhong_tb.Size = new Size(140, 27);
            MaPhong_tb.TabIndex = 1;
            //MaPhong_tb.TextChanged += MaPhong_tb_TextChanged;
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
            panel3.Controls.Add(MaPhong_tb);
            panel3.Controls.Add(MaPhong_Label);
            panel3.Location = new Point(253, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 57);
            panel3.TabIndex = 0;
            // 
            // LoaiPhongcb
            // 
            LoaiPhongcb.FormattingEnabled = true;
            LoaiPhongcb.Location = new Point(101, 15);
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
            panel4.Location = new Point(755, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 57);
            panel4.TabIndex = 2;
            // 
            // SVHT_tb
            // 
            SVHT_tb.Location = new Point(102, 12);
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
            GiaPhong_tb.Location = new Point(101, 12);
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
            Renew_Btn.Location = new Point(263, 70);
            Renew_Btn.Name = "Renew_Btn";
            Renew_Btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Renew_Btn.Size = new Size(123, 45);
            Renew_Btn.TabIndex = 7;
            Renew_Btn.Text = "Renew";
            Renew_Btn.Click += Renew_Btn_Click;
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
            Delete_Btn.Location = new Point(263, 133);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Delete_Btn.Size = new Size(123, 45);
            Delete_Btn.TabIndex = 6;
            Delete_Btn.Text = "Xóa";
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(GiaPhong_tb);
            panel8.Controls.Add(GiaPhong_Label);
            panel8.Location = new Point(755, 63);
            panel8.Name = "panel8";
            panel8.Size = new Size(245, 57);
            panel8.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(SVHT_tb);
            panel5.Controls.Add(SVHienTai_Label);
            panel5.Location = new Point(504, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 57);
            panel5.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(Edit_Btn);
            panel1.Controls.Add(Add_Btn);
            panel1.Controls.Add(Update_Btn);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(Renew_Btn);
            panel1.Controls.Add(Delete_Btn);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 200);
            panel1.TabIndex = 2;
            // 
            // Update_Btn
            // 
            Update_Btn.CustomizableEdges = customizableEdges9;
            Update_Btn.DisabledState.BorderColor = Color.DarkGray;
            Update_Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Update_Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Update_Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Update_Btn.FillColor = Color.White;
            Update_Btn.Font = new Font("Segoe UI", 9F);
            Update_Btn.ForeColor = Color.Black;
            Update_Btn.Image = (Image)resources.GetObject("Update_Btn.Image");
            Update_Btn.ImageAlign = HorizontalAlignment.Left;
            Update_Btn.Location = new Point(542, 136);
            Update_Btn.Name = "Update_Btn";
            Update_Btn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Update_Btn.Size = new Size(123, 45);
            Update_Btn.TabIndex = 10;
            Update_Btn.Text = "Cập nhật";
            Update_Btn.TextOffset = new Point(6, 0);
            Update_Btn.Click += Update_Btn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(MaLoaiPhong_tb);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(504, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(245, 57);
            panel7.TabIndex = 9;
            // 
            // MaLoaiPhong_tb
            // 
            MaLoaiPhong_tb.Location = new Point(115, 12);
            MaLoaiPhong_tb.Name = "MaLoaiPhong_tb";
            MaLoaiPhong_tb.Size = new Size(120, 27);
            MaLoaiPhong_tb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã loại phòng";
            // 
            // panel6
            // 
            panel6.Controls.Add(Matang_tb);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 57);
            panel6.TabIndex = 8;
            // 
            // Matang_tb
            // 
            Matang_tb.Location = new Point(85, 12);
            Matang_tb.Name = "Matang_tb";
            Matang_tb.Size = new Size(140, 27);
            Matang_tb.TabIndex = 1;
            Matang_tb.TextChanged += Matang_tb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Tầng";
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
            Edit_Btn.Location = new Point(85, 133);
            Edit_Btn.Name = "Edit_Btn";
            Edit_Btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Edit_Btn.Size = new Size(123, 45);
            Edit_Btn.TabIndex = 12;
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
            Add_Btn.Location = new Point(85, 70);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Add_Btn.Size = new Size(123, 45);
            Add_Btn.TabIndex = 11;
            Add_Btn.Text = "Thêm";
            Add_Btn.Click += Add_Btn_Click;
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
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView;
        private Panel panel2;
        private TextBox MaPhong_tb;
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
        private Panel panel8;
        private Panel panel5;
        private Panel panel1;
        private Panel panel7;
        private TextBox MaLoaiPhong_tb;
        private Label label2;
        private Panel panel6;
        private TextBox Matang_tb;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button Update_Btn;
        private DataGridViewTextBoxColumn MaTang;
        private DataGridViewTextBoxColumn MaPhong_Col;
        private DataGridViewTextBoxColumn MaLoaiPhong;
        private DataGridViewTextBoxColumn LoaiPhong_Col;
        private DataGridViewTextBoxColumn SVHT_Col;
        private DataGridViewTextBoxColumn GiaPhong_Col;
        private Guna.UI2.WinForms.Guna2Button Edit_Btn;
        private Guna.UI2.WinForms.Guna2Button Add_Btn;
    }
}