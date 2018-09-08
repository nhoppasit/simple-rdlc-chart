using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLC.SimpleChart_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Table from database
            List<Model.SimpleChart> list = new List<Model.SimpleChart>
            {
                new Model.SimpleChart() {ID=0, SERIES="AAA", X1=1m,Y1=0.5m,X2=3,Y2=0.5m,COMMENT="ก1"},
                new Model.SimpleChart() {ID=1, SERIES="AAA", X1=2m,Y1=0.3m,X2=5,Y2=0.2m,COMMENT="ก2"},
                new Model.SimpleChart() {ID=2, SERIES="AAA", X1=3m,Y1=0.6m,X2=7,Y2=0.3m,COMMENT="ก3"},
                new Model.SimpleChart() {ID=3, SERIES="AAA", X1=4m,Y1=0.5m,X2=9,Y2=0.7m,COMMENT="ก4"},

                new Model.SimpleChart() {ID=4, SERIES="BBB", X1=5m,Y1=0.5m,X2=5.5m,Y2=0.5m,COMMENT="ข1"},
                new Model.SimpleChart() {ID=5, SERIES="BBB", X1=6m,Y1=0.3m,X2=6.5m,Y2=0.2m,COMMENT="ข2"},
                new Model.SimpleChart() {ID=6, SERIES="BBB", X1=7m,Y1=0.6m,X2=7.5m,Y2=0.3m,COMMENT="ข3"},
                new Model.SimpleChart() {ID=7, SERIES="BBB", X1=8m,Y1=0.5m,X2=8.5m,Y2=0.7m,COMMENT="ข4"},
            };
            ReportDataSource rd1 = new ReportDataSource("SimpleData", list);

            // assing and refresh report
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rd1);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);  //ปรับเป็นหน้า PrintLayout
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();

            //this.reportViewer1.RefreshReport();
        }
    }
}
