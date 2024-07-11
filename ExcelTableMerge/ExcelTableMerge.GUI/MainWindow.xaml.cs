using FastWpfGrid;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExcelTableMerge.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyGrid _myGrid = new();

        public MainWindow()
        {
            InitializeComponent();

            SrcDataGrid.Model = _myGrid;
        }

        private void DataGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        private void DataGrid_SelectedCellsChanged(object sender, FastWpfGrid.SelectionChangedEventArgs e)
        {
        }

        private void columnsCfgChanged(object sender, RoutedEventArgs e)
        {
            var hidden = new HashSet<int>();
            var frozen = new HashSet<int>();

            if (chbHideColumn3.IsChecked == true) hidden.Add(2);
            if (chbFreezeColumn5.IsChecked == true) frozen.Add(4);

            _myGrid.SetColumnArrange(hidden, frozen);
        }

    }
}