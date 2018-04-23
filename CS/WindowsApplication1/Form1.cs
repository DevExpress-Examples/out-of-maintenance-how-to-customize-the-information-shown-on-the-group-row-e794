using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);
            gridView1.Columns["Category"].GroupIndex = 0;
            gridView1.ExpandAllGroups();
            gridView1.GroupSummary.Add(SummaryItemType.Count, "Product Name", null);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.GroupFormat = "[{0}: {1}] [Image: [#image]] [Summary: {2}]";
        }
    }
}