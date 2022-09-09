using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            StiOptions.Viewer.RightToLeft = StiRightToLeftType.Yes;
        }

        private void buttonNotTransaction_Click(object sender, EventArgs e)
        {
            AddRegion();
            AddCategory();
        }

        private void AddCategory()
        {
            using (var db = new NorthWindEntities())
            {
                db.Categories.Add(new Category { CategoryName = "test 1234567890123456789" });
                db.SaveChanges();
            }
        }

        private void AddRegion()
        {
            using (var db = new NorthWindEntities())
            {
                db.Regions.Add(new Region { RegionDescription = "test 2" });
                db.SaveChanges();
            }
        }

        private void buttonTrasnactionScope_Click(object sender, EventArgs e)
        {
            using (var t = new TransactionScope())
            {
                AddRegion();
                AddCategory();
                t.Complete();
            }
        }

        

        private void AddWithTransaction()
        {
            using (var db = new NorthWindEntities())
            {
                using (var t = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Regions.Add(new Region { RegionDescription = "test 2" });
                        db.Categories.Add(new Category { CategoryName = "test 1234567890123456789" });
                        db.SaveChanges();
                        t.Commit();
                    }
                    catch (Exception e)
                    {
                        t.Rollback();
                    }
                }
                
            }
        }

        /*
         * Unit of work
         *
         */

        private void UOW()
        {
            //var db = new NorthWindEntities();
            //var regionRepo = new GenericRepo<Region>(db);
            //var categoryRepo = new GenericRepo<Category>(db);
            var uow = new UnitOfWork();
            uow.GetRegionRepo().Create(new Region { RegionDescription = "test 2" });
            uow.GetCategoryRepo().Create(new Category { CategoryName = "test 1234567890123456789" });
            uow.SaveChanges();
        }

    }
}
