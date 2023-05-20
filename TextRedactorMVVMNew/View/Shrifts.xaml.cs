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
using System.Windows.Shapes;
using TextRedactorMVVMNew.ViewModel;

namespace TextRedactorMVVMNew.View
{
    /// <summary>
    /// Логика взаимодействия для Shrifts.xaml
    /// </summary>
    public partial class Shrifts : Window
    {
        public Shrifts()
        {
            InitializeComponent();
            DataContext = new ShriftsViewModel();
        }
    }
}
