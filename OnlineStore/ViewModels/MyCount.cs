using OnlineStore.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
   public class MyCount:BaseViewModel
    {
        private int count=0;

        public int Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged(); }
        }        

    }
}
