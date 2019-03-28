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
            DB_128040_practiceEntities db = new DB_128040_practiceEntities();
            var cust = db.Customers.//Where(x =>x.State == "California");
            if (CmbBoxSelect.SelectedIndex==0)
            {
                MessageBox.Show("CustomerID");
                MessageBox.Show($"There are {cust.Count()}");

            }
            if (CmbBoxSelect.SelectedIndex==1)
            {
                MessageBox.Show("City");
            }
            
        }




        
    }
}
