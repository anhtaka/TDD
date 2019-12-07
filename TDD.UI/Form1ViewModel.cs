using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TDD.UI
{
    public class Form1ViewModel : ViewModelBase
    {
        private string _aTextBoxText = string.Empty;
        public string ATextBoxText
        {
            get { return _aTextBoxText; }
            set {
                SetProperty(ref _aTextBoxText, value);
            }
        }
        private string _bTextBoxText = string.Empty;
        public string BTextBoxText
        {
            get { return _bTextBoxText; }
            set
            {
                SetProperty(ref _bTextBoxText, value);
            }
        }
        private string _resultLabelText = string.Empty;
        public string ResultLabelText
        {
            get { return _resultLabelText; }
            set
            {
                SetProperty(ref _resultLabelText, value);
                //if (_resultLabelText == value)
                //{
                //    return;
                //}
                //_resultLabelText = value;
                //OnPropertyChanged("ResultLabelText");
            }
        }
        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string propertyName)
        //{
        //    if(PropertyChanged != null)
        //    {
        //        this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        public void CaluclationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);

            ResultLabelText = Caluculation.Sum(a, b).ToString();

            //OnPropertyChanged(string.Empty);
        }
    }
}
