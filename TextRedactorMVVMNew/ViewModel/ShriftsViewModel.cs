using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TextRedactorMVVMNew.View;
using TextRedactorMVVMNew.ViewModel.Helpers;

namespace TextRedactorMVVMNew.ViewModel
{
    internal class ShriftsViewModel : BindingHelper
    {

        MainWindow Form = Application.Current.Windows[0] as MainWindow; //Другого я не нашел
        public BinableCommands Arial { get; set; }
        public BinableCommands TimesNR { get; set; }
        public BinableCommands Calibri { get; set; }
        public ShriftsViewModel()
        {
            Arial = new BinableCommands(_ => ARM());
            TimesNR = new BinableCommands(_ => TNRM());
            Calibri = new BinableCommands(_ => CAM());
        }
     
        public void ARM()
        {
            Form.BoxTXT.FontFamily = new FontFamily("Arial");
        }
        public void TNRM()
        {
            Form.BoxTXT.FontFamily = new FontFamily("Times New Roman");
        }
        public void CAM()
        {
            Form.BoxTXT.FontFamily = new FontFamily("Calibri");
        }
    }
}
