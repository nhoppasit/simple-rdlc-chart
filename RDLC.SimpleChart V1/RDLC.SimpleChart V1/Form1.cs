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
                new Model.SimpleChart() {ID=0, SERIES="AAA", X1=1.5m,Y1=0.5m,X2=1,Y2=0.5m},
                new Model.SimpleChart() {ID=1, SERIES="AAA", X1=2.5m,Y1=0.3m,X2=2,Y2=0.2m},
                new Model.SimpleChart() {ID=2, SERIES="AAA", X1=3.5m,Y1=0.6m,X2=3,Y2=0.3m},
                new Model.SimpleChart() {ID=3, SERIES="AAA", X1=4.5m,Y1=0.5m,X2=4,Y2=0.7m},

                new Model.SimpleChart() {ID=4, SERIES="BBB", X1=3.5m,Y1=0.5m,X2=1,Y2=0.5m},
                new Model.SimpleChart() {ID=5, SERIES="BBB", X1=4.5m,Y1=0.3m,X2=2,Y2=0.2m},
                new Model.SimpleChart() {ID=6, SERIES="BBB", X1=5.5m,Y1=0.6m,X2=3,Y2=0.3m},
                new Model.SimpleChart() {ID=7, SERIES="BBB", X1=6.5m,Y1=0.5m,X2=4,Y2=0.7m},
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
