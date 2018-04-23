using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraPivotGrid;

namespace WindowsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CubeToTableAdapter adapter;
        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new CubeToTableAdapter(pivotGridControl1);
        }



        void button1_Click(object sender, EventArgs e)
        {
            adapter.RefreshDataSource();
            pivotGridControl1.CollapseAll();   
        }
    }

}