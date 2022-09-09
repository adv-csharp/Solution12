using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace UI.Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            using (var db = new NorthWindEntities())
            {
                var products = db.Products.ToList();
                var report = new StiReport();
                report.RegBusinessObject("ProductBO", products);
                report.Load(Path.Combine(Application.StartupPath, "ProductReport.mrt"));
                report.Show();

            }
        }
    }
}
