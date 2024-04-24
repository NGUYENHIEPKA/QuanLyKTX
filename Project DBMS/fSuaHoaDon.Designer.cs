namespace Project_DBMS
{
    partial class fSuaHoaDon
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSuaHoaDon));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label2 = new Label();
            panel1 = new Panel();
            maHoaDon_tb = new TextBox();
            label1 = new Label();
            panel8 = new Panel();
            unThanhToan_check = new Guna.UI2.WinForms.Guna2RadioButton();
            thanhToan_check = new Guna.UI2.WinForms.Guna2RadioButton();
            Status_Label = new Label();
            Add_Btn = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(469, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(196, 23);
            label2.TabIndex = 3;
            label2.Text = "Sửa trạng thái hóa đơn";
            // 
            // panel1
            // 
            panel1.Controls.Add(maHoaDon_tb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(36, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 57);
            panel1.TabIndex = 4;
            // 
            // maHoaDon_tb
            // 
            maHoaDon_tb.Location = new Point(219, 10);
            maHoaDon_tb.Name = "maHoaDon_tb";
            maHoaDon_tb.ReadOnly = true;
            maHoaDon_tb.Size = new Size(228, 27);
            maHoaDon_tb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn";
            // 
            // panel8
            // 
            panel8.Controls.Add(unThanhToan_check);
            panel8.Controls.Add(thanhToan_check);
            panel8.Controls.Add(Status_Label);
            panel8.Location = new Point(36, 147);
            panel8.Name = "panel8";
            panel8.Size = new Size(447, 57);
            panel8.TabIndex = 5;
            // 
            // unThanhToan_check
            // 
            unThanhToan_check.AutoSize = true;
            unThanhToan_check.BackColor = SystemColors.Control;
            unThanhToan_check.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            unThanhToan_check.CheckedState.BorderThickness = 0;
            unThanhToan_check.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            unThanhToan_check.CheckedState.InnerColor = Color.White;
            unThanhToan_check.CheckedState.InnerOffset = -4;
            unThanhToan_check.Location = new Point(273, 18);
            unThanhToan_check.Name = "unThanhToan_check";
            unThanhToan_check.Size = new Size(139, 24);
            unThanhToan_check.TabIndex = 3;
            unThanhToan_check.Text = "Chưa thanh toán";
            unThanhToan_check.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            unThanhToan_check.UncheckedState.BorderThickness = 2;
            unThanhToan_check.UncheckedState.FillColor = Color.Transparent;
            unThanhToan_check.UncheckedState.InnerColor = Color.Transparent;
            unThanhToan_check.UseVisualStyleBackColor = false;
            // 
            // thanhToan_check
            // 
            thanhToan_check.AutoSize = true;
            thanhToan_check.BackColor = SystemColors.Control;
            thanhToan_check.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            thanhToan_check.CheckedState.BorderThickness = 0;
            thanhToan_check.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            thanhToan_check.CheckedState.InnerColor = Color.White;
            thanhToan_check.CheckedState.InnerOffset = -4;
            thanhToan_check.Location = new Point(129, 18);
            thanhToan_check.Name = "thanhToan_check";
            thanhToan_check.Size = new Size(124, 24);
            thanhToan_check.TabIndex = 2;
            thanhToan_check.Text = "Đã thanh toán";
            thanhToan_check.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            thanhToan_check.UncheckedState.BorderThickness = 2;
            thanhToan_check.UncheckedState.FillColor = Color.Transparent;
            thanhToan_check.UncheckedState.InnerColor = Color.Transparent;
            thanhToan_check.UseVisualStyleBackColor = false;
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
            Add_Btn.Location = new Point(36, 264);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Add_Btn.Size = new Size(123, 45);
            Add_Btn.TabIndex = 6;
            Add_Btn.Text = "Cập nhật";
            Add_Btn.TextOffset = new Point(8, 0);
            Add_Btn.Click += Add_Btn_Click;
            // 
            // fSuaHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 351);
            Controls.Add(Add_Btn);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(guna2ControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fSuaHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fSuaHoaDon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label label2;
        private Panel panel1;
        private TextBox maHoaDon_tb;
        private Label label1;
        private Panel panel8;
        private Guna.UI2.WinForms.Guna2RadioButton thanhToan_check;
        private Label Status_Label;
        private Guna.UI2.WinForms.Guna2Button Add_Btn;
        private Guna.UI2.WinForms.Guna2RadioButton unThanhToan_check;
    }
}