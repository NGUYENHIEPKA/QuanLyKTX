﻿using Project_DBMS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS
{
    public partial class fHoaDonNuoc : Form
    {
        public fHoaDonNuoc()
        {
            InitializeComponent();
            Load();
            Binding();
        }
        void Load()
        {
            ClearBinding();
            dataGridView.DataSource = QLHoaDonDAO.Instance.GetListHoaDonNuoc();
        }
        void Binding()
        {
            MaPhong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            CreateDay_Date.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "NgayLapBieu", true, DataSourceUpdateMode.Never));
            oldNum_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "SoNuocCu", true, DataSourceUpdateMode.Never));
            newNum_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "SoNuocMoi", true, DataSourceUpdateMode.Never));
            money_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "TienNuoc", true, DataSourceUpdateMode.Never));
        }
        void ClearBinding()
        {
            MaPhong_tb.DataBindings.Clear();
            CreateDay_Date.DataBindings.Clear();
            oldNum_tb.DataBindings.Clear();
            newNum_tb.DataBindings.Clear();
            money_tb.DataBindings.Clear();
        }
    }
}
