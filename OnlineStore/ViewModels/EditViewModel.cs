using OnlineStore.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OnlineStore.ViewModels
{
    public class EditViewModel : BaseViewModel
    {
        public EditView EditView { get; set; }
        private Coffee _coffee;

        public Coffee EditCoffee
        {
            get { return _coffee; }
            set { _coffee = value; OnPropertyChanged(); }
        }

        public RelayCommand SaveCommand { get; set; }


        public EditViewModel()
        {
            SaveCommand = new RelayCommand((e) =>
            {
                EditView.Close();
                MessageBox.Show("Saved data successfully");
            });
        }


    }
}
