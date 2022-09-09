using BL;
using ViewModel;

namespace UI.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * validation * user friendly 
             */

            var productVm = new ProductVM
            {
                Name = "az ui",
                Description = "az ui"
            };

            var productService = new ProductService();
            productService.Create(productVm);
        }
    }
}