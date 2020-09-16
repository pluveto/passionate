using Passionate.Windows;
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

namespace Passionate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.VM = new MainWindowVM();
            this.DataContext = VM;
            InitializeComponent();
        }

        internal MainWindowVM VM { get; private set; }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            new AddWindow().Show();
        }
    }
}
