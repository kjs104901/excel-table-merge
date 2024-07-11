using unvell.ReoGrid.IO;

namespace ExcelTableMerge.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //reoGridControl1.Load("D:\\Project\\excel-table-merge\\TestData\\ch02-065.xlsx", FileFormat.Excel2007);
            reoGridControl1.Load("D:\\Project\\excel-table-merge\\TestData\\164.xlsx", FileFormat.Excel2007);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reoGridControl1.Save("D:\\Project\\excel-table-merge\\TestData\\164_new.xlsx", FileFormat.Excel2007);
        }
    }
}
