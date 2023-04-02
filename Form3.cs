using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalReports
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            CrystalReport1 crpt = new CrystalReport1();
            crystalReportViewer2.ReportSource = null;
            crystalReportViewer2.ReportSource = crpt;
        }
    }
}
