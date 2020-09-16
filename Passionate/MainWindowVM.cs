using Passionate.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passionate
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public ObservableCollection<CrendentialEntity> CrendentialEntities { get; set; } = new ObservableCollection<CrendentialEntity>();
        public int Page { get; set; }
        public int PageSize { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowVM()
        {
            Page = 1;
            PageSize = 25;
        }

    }
}
