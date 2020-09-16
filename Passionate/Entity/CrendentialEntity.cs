using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passionate.Entity
{
    class CrendentialEntity : INotifyPropertyChanged
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string location { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
