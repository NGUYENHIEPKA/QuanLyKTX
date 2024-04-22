namespace Project_DBMS
{
    partial class fThemHoaDonDien
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemHoaDonDien));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label2 = new Label();
            panel2 = new Panel();
            maPhong_tb = new TextBox();
            label3 = new Label();
            Add_Btn = new Guna.UI2.WinForms.Guna2Button();
            panel3 = new Panel();
            newNum_tb = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            oldNum_tb = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            dateTimePicker = new DateTimePicker();
            label6 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(476, -1);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 4;
            label2.Text = "Thêm hóa đơn";
            // 
            // panel2
            // 
            panel2.Controls.Add(maPhong_tb);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(34, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 57);
            panel2.TabIndex = 5;
            // 
            // maPhong_tb
            // 
            maPhong_tb.Location = new Point(219, 10);
            maPhong_tb.Name = "maPhong_tb";
            maPhong_tb.Size = new Size(228, 27);
            maPhong_tb.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 17);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã phòng";
            // 
            // Add_Btn
            // 
            Add_Btn.CustomizableEdges = customizableEdges3;
            Add_Btn.DisabledState.BorderColor = Color.DarkGray;
            Add_Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Add_Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Add_Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Add_Btn.FillColor = Color.White;
            Add_Btn.Font = new Font("Segoe UI", 9F);
            Add_Btn.ForeColor = Color.Black;
            Add_Btn.Image = (Image)resources.GetObject("Add_Btn.Image");
            Add_Btn.ImageAlign = HorizontalAlignment.Left;
            Add_Btn.Location = new Point(34, 357);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Add_Btn.Size = new Size(123, 45);
            Add_Btn.TabIndex = 11;
            Add_Btn.Text = "Thêm";
            Add_Btn.Click += Add_Btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(newNum_tb);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(34, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 57);
            panel3.TabIndex = 10;
            // 
            // newNum_tb
            // 
            newNum_tb.Location = new Point(219, 10);
            newNum_tb.Name = "newNum_tb";
            newNum_tb.Size = new Size(228, 27);
            newNum_tb.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 17);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 0;
            label4.Text = "Số điện mới";
            // 
            // panel1
            // 
            panel1.Controls.Add(oldNum_tb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 57);
            panel1.TabIndex = 9;
            // 
            // oldNum_tb
            // 
            oldNum_tb.Location = new Point(219, 10);
            oldNum_tb.Name = "oldNum_tb";
            oldNum_tb.Size = new Size(228, 27);
            oldNum_tb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Số điện cũ";
            // 
            // panel5
            // 
            panel5.Controls.Add(dateTimePicker);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(34, 124);
            panel5.Name = "panel5";
            panel5.Size = new Size(450, 57);
            panel5.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(219, 12);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(228, 27);
            dateTimePicker.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 17);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 0;
            label6.Text = "Ngày tạo hóa đơn";
            // 
            // fThemHoaDonDien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 450);
            Controls.Add(Add_Btn);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(guna2ControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fThemHoaDonDien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fThemHoaDonDien";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label label2;
        private Panel panel2;
        private TextBox maPhong_tb;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button Add_Btn;
        private Panel panel3;
        private TextBox newNum_tb;
        private Label label4;
        private Panel panel1;
        private TextBox oldNum_tb;
        private Label label1;
        private Panel panel5;
        private DateTimePicker dateTimePicker;
        private Label label6;
    }
}