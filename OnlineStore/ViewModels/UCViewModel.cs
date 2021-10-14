using OnlineStore.Command;
using OnlineStore.Repo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OnlineStore.ViewModels
{
    public class UCViewModel : BaseViewModel
    {
        private MyCount myCount;

        public MyCount Count
        {
            get { return myCount; }
            set { myCount = value; }
        }

        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; OnPropertyChanged(); }
        }
        private string coffeeName;

        public string CoffeeName
        {
            get { return coffeeName; }
            set { coffeeName = value; OnPropertyChanged(); }
        }

        private double price;

        public Thickness thickness { get; set; }
        public double Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }

        public CoffeeRepository CoffeeRepo { get; set; }
        public ObservableCollection<Coffee> Coffees { get; set; }
        private Coffee coffee;

        public Coffee Coffee
        {
            get { return coffee; }
            set
            {
                coffee = value;
                OnPropertyChanged();
            }

        }
        public RelayCommand IncrementCommand { get; set; }
        public EditViewModel EditViewModel { get; set; }

       public RelayCommand OpenImageCommand { get; set; }

        public UCViewModel()
        {
            IncrementCommand = new RelayCommand((e) =>
            {
                Count.Count++;
            });

            OpenImageCommand = new RelayCommand((e) =>
            {
                var coffee_ = new Coffee();
                coffee_.Name = CoffeeName;
                coffee_.ImagePath = ImagePath;
                coffee_.Price = Price;
                   var view = new EditView() ;
            EditViewModel = new EditViewModel();
            EditViewModel.EditCoffee = coffee_;
            EditViewModel.EditView = view;
            view.DataContext = EditViewModel;
            view.ShowDialog();
            });
        
}


        //Coffee = new Coffee
        //        {                  
        //             ImagePath="Icons/mehmetEfendi.png",
        //              Name="Mehmet E.",
        //               Price=7

        //        };


        //    CoffeeRepo = new CoffeeRepository ();
        //Printers = new ObservableCollection<Printer>(PrinterRepository.GetAll());






    }
}
