namespace Project_DBMS
{
    partial class SinhVienSuaChua
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
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(882, 32);
            label1.TabIndex = 0;
            label1.Text = "SINH VIÊN VUI LÒNG LIÊN HỆ BAN QUẢN LÝ ĐỂ ĐƯỢC HỖ TRỢ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(40, 282);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 63);
            panel1.TabIndex = 1;
            // 
            // SinhVienSuaChua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 697);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SinhVienSuaChua";
            Text = "SinhVienSuaChua";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
    }
}