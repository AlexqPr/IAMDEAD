using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using TextRedactorMVVMNew.View;
using TextRedactorMVVMNew.ViewModel.Helpers;

namespace TextRedactorMVVMNew.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        private string mytext;
        MainWindow Form = Application.Current.Windows[0] as MainWindow; //Другого я не нашел

        public string MyText
        {
            get { return mytext; }
            set { mytext = value; }
        }

        public BinableCommands Saving { get; set; }
        public BinableCommands Reading { get; set; }
        public BinableCommands SmenaShrifta { get; set; }
        public BinableCommands SmenaSIZE { get; set; }
        public MainViewModel()
        {
            Saving = new BinableCommands(_ => Save());
            Reading = new BinableCommands(_ => Read());
            SmenaShrifta = new BinableCommands(_ => SmenaSH());
            SmenaSIZE = new BinableCommands(_ => SmenaSI());
        }

        private void Save()
        {
            SaveFileDialog Fl = new SaveFileDialog(); 
            Fl.ShowDialog();
            if(Fl.FileName.Length > 0)
            {
                if(Fl.FileName.Contains(".rtf"))
                {
                   
                }
                else
                {
                    Fl.FileName = Fl.FileName + ".rtf";
                }
                TextRange range = new TextRange(Form.BoxTXT.Document.ContentStart, Form.BoxTXT.Document.ContentEnd); //Честно хотел это сделать через привязки, но тогда текст равен =  ""
                FileStream fstream = new FileStream(Fl.FileName, FileMode.Create);
                range.Save(fstream, DataFormats.Rtf);
                fstream.Close();

            }
           
        }

        private void Read()
        {
            OpenFileDialog Fl = new OpenFileDialog();
            Fl.ShowDialog();
            if (File.Exists(Fl.FileName))
            {

                TextRange range = new TextRange(Form.BoxTXT.Document.ContentStart, Form.BoxTXT.Document.ContentEnd);
                FileStream fstream = new FileStream(Fl.FileName, FileMode.OpenOrCreate);
                range.Load(fstream, DataFormats.Rtf);
                fstream.Close();
            }
        }

        private void SmenaSH()
        {
            Shrifts win = new Shrifts();
            win.Show();
        }

        private void SmenaSI()
        {
            View.Size win = new View.Size();
            win.Show();
        }

        public void Smena()
        {
            //string Shrift = "Times New Roman";
            //MyText.FontFamily = new FontFamily((string)Shrift);
        }

    }
}
