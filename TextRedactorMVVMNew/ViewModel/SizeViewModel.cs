using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TextRedactorMVVMNew.ViewModel.Helpers;

namespace TextRedactorMVVMNew.ViewModel
{
    internal class SizeViewModel : BindingHelper
    {
        //private ObservableCollection<int> razm = new ObservableCollection<int>();
        View.Size newform = Application.Current.Windows[0] as View.Size; //Другого я не нашел
        MainWindow Form = Application.Current.Windows[0] as MainWindow; //Другого я не нашел
        public BinableCommands SmenaSIZE { get; set; }
        public string rM { get; set; }

        //public ObservableCollection<int> Razm
        //{
        //    get { return razm; }
        //    set
        //    {
        //        razm = value;
        //        OnPropertyChanged();
        //    }
        //}
        public SizeViewModel()
        {
            //for (int i = 1; i < 21; i++)
            //{
            //    Razm.Add(i);
            //}
            SmenaSIZE = new BinableCommands(_ => Smena());

        }
        private void Smena()
        {
            try
            {

                int newr = Convert.ToInt32(rM);
                Form.BoxTXT.FontSize = newr; //Я короче хотел тут сделать привязку к листу и мол когда жмешь на button возвращает item or index. Но возвращало null
                //Потом я решил привязять к событию SelectionChanged и ничего не вышло. Скорее всего у меня ПАТАУ (если не особо впечатлительны рекомендую загуглить xD)
            }
            catch
            {
                MessageBox.Show("Вы ввели неверные данные!");
            }
            //int r = (int)newform.Razmer.SelectedIndex;
            //Form.BoxTXT.FontSize = rM;
            
            //Хотелось бы тут сделать закрытие окна, но увы я не могу наследовать Windows (подчеркивает красным)
        }


    }
}
