using OnlineStore.Command;
using OnlineStore.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OnlineStore.ViewModels
{
  public  class AppViewModel:BaseViewModel
    {
        public bool Click { get; set; } = false;
        private MyCount count;
        public WrapPanel MyPanel { set; get; }
        public MyCount Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged(); }
        }

        public RelayCommand SearchCommand { set; get; }

        public AppViewModel( WrapPanel panel)
        {
            MyPanel = panel;
            var items = new CoffeeRepository().GetAll();
            Count = new MyCount
            {
                Count = 0
            };
            foreach (var item in items)
            {
                UCViewModel VM = new UCViewModel();
                VM.Count = Count;
                VM.thickness = new Thickness(20, 0, 0, 15);
                VM.CoffeeName = item.Name;
                VM.ImagePath = item.ImagePath;
                VM.Price = item.Price;
                var uc = new BorderUC(VM);                
                MyPanel.Children.Add(uc);
            }



        }

    }
}
