using OnlineStore.Repo;
using OnlineStore.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace OnlineStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        
        public MainWindow()
        {
            InitializeComponent();
            AppViewModel appViewModel = new AppViewModel(Controls);
           
            this.DataContext = appViewModel;
           
        }
         

        private void searchTxtBox_MouseEnter(object sender, MouseEventArgs e)
        {
            searchTxtBox.Text = string.Empty;
        }

        
        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }



}
