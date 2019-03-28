using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataSolution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CmbBoxSelect.Items.Add("CustomerID");
            CmbBoxSelect.Items.Add("City");
            


        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            if (CmbBoxSelect.SelectedIndex==0)
            {
                MessageBox.Show("CustomerID");

            }
            if (CmbBoxSelect.SelectedIndex==1)
            {
                MessageBox.Show("City");
            }
            
        }




        
    }
}
