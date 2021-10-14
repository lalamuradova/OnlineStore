using OnlineStore.Repo;
using OnlineStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for BorderUC.xaml
    /// </summary>
    public partial class BorderUC : UserControl
    {
        public UCViewModel UCViewModel { get; set; }
        public BorderUC( UCViewModel viewModel)
        {
            
            InitializeComponent();
            UCViewModel = viewModel;
            this.DataContext = UCViewModel;
            
        }

       

    }
}
